using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
using System.IO.Ports;
using System.Collections;
using System.Security.Cryptography;

namespace WLM
{    
    
    public partial class Form1 : MetroForm
    {
        //DataSet principale
        DataSet ds = new DataSet("DB");
        DataTable armdt = new DataTable("NewARM");

        public static SerialPort mySerialPort = new SerialPort();
      

        //Variabili globali
        public string PercorsoApriFile;
        public string TempDescrizione;
        public string ArchivioInUso;
        public string ApplicationFolder = System.IO.Directory.GetCurrentDirectory();
        public string SerialPortBuffer = "";
        public bool SerialPortEnumerated = false;
        public string GlobalSerial;

        //Per move del form
        private bool mouseDown;
        private Point lastLocation;

        //Per gestione stampa
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();     //Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();    //Used to save column widths
        int iCellHeight = 0;    //Used to get/set the datagridview cell height
        int iTotalWidth = 0; 
        int iRow = 0;
        bool bFirstPage = false;    //Used to check whether we are printing first page
        bool bNewPage = false;      // Used to check whether we are printing a new page
        int iHeaderHeight = 0;      //Used for the header height


        /***************** PUNTO DI INGRESSO *****************/
        public Form1()
        {
            /***************** PUNTO DI INGRESSO *****************/
            
            InitializeComponent();
            armdt.Columns.Add("serial_no");
            armdt.Columns.Add("qr_code");
            armdt.Columns.Add("added_on");
            armdt.Columns.Add("added_by");
            armdt.Columns.Add("active");

            GridViewSerials.DataSource = armdt;
            cmbSpeedSP.SelectedIndex = 4;       //Setto 115.200 bps di default per la COM
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();

            //Visualizzazione versione sw nella title bar del form e nella scheda About
            this.Text = "WhiteListManager - v." + Application.ProductVersion;
            lblFormTitle.Text = "WhiteListManager - v." + Application.ProductVersion;
            lblSWVersion.Text = "Version: " + Application.ProductVersion;

            //Disabilito tutte le Tab ed imposto la prima come attiva
            TabControl.Controls[1].Enabled = false;
            TabControl.Controls[2].Enabled = false;
            TabControl.SelectedIndex = 0;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //Azioni su resize del form
            lblFormTitle.Width = this.Width - 95;
            pictureBox1.Location = new Point(lblFormTitle.Width, 5);
            TabControl.Width = this.Width - 5;
            TabControl.Height = this.Height - 25;
        }

        private void LoadSettings()
        {
            
            //Lettura Percorso default file DB
            if (Properties.Settings.Default.OpenFilePath == "")
            {
                //Percorso open file non settato, uso il default
                string TempPath = Directory.GetCurrentDirectory() + "\\DB";
                Properties.Settings.Default.OpenFilePath = TempPath;
                Properties.Settings.Default.Save();
            }
            txtFolderOpen.Text = Properties.Settings.Default.OpenFilePath;

            if (Directory.Exists(txtFolderOpen.Text.Trim()))
            {
                PercorsoApriFile = txtFolderOpen.Text.Trim();
                PopulateDBList();
            }
        }

        private void PopulateDBList()
        {

            Open_FileList.Items.Clear();

            var Elenco = Directory.EnumerateFiles(PercorsoApriFile, "*.*")
                 .Select(p => Path.GetFileName(p))
                 .Where(s => s.EndsWith(".xml", StringComparison.OrdinalIgnoreCase) || s.EndsWith(".XML", StringComparison.OrdinalIgnoreCase)).ToArray();

            foreach (String file in Elenco)
            {
            Open_FileList.Items.Add(file);
            }
        }

        private void btnGoToFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", PercorsoApriFile);
        }

        private void LoadXMLContent()
        {

            ds.ReadXml(ArchivioInUso);

            dataGridView.DataSource = ds.Tables[1];
            ds.AcceptChanges();


            bindingSource1.DataSource = ds;
            bindingSource1.DataMember = "description";

            bindingSource2.DataSource = ds;
            bindingSource2.DataMember = "arm";

            bindingNavigator1.BindingSource = bindingSource2;


            txtARMsnEdit.DataBindings.Add("Text", bindingSource2, "serial_no");
            txtQR.DataBindings.Add("Text", bindingSource2, "qr_code");
            txtAddedByEdit.DataBindings.Add("Text", bindingSource2, "added_by");
            dpAddedOnEdit.DataBindings.Add("Value", bindingSource2, "added_on", true);
            chkActiveEdit.DataBindings.Add("Checked", bindingSource2, "active", true);


            txtDBTitle.DataBindings.Add("Text", bindingSource1, "title");
            txtDBCustomer.DataBindings.Add("Text", bindingSource1, "customer");
            txtDBDescription.DataBindings.Add("Text", bindingSource1, "notes");
            txtDBCreatedBy.DataBindings.Add("Text", bindingSource1, "created_by");
            dpCreationDate.DataBindings.Add("Value", bindingSource1, "creation_date", true);
            dpLastModify.DataBindings.Add("Value", bindingSource1, "last_modify", true);
            lblRecordCount.Text = "Record count: " + (dataGridView.RowCount - 1).ToString();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index < dataGridView.RowCount - 1)
                {

                    string RowType = row.Cells[4].Value.ToString();


                    if (RowType == "False")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSalmon;
                        //row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (RowType == "True")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        //row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }



        }

        private void UpdateSerialPortEnum()
        {

            if (SerialPortEnumerated == false) { 
                SerialPortNumber.Items.Clear();
                string[] ports = SerialPort.GetPortNames();

                foreach (string port in ports)
                {
                    SerialPortNumber.Items.Add(port);
                }
                SerialPortEnumerated = true;
            }
        }

        private void cmdSerialPortUpdate_Click(object sender, EventArgs e)
        {
            SerialPortEnumerated = false;
            UpdateSerialPortEnum();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select a folder";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PercorsoApriFile = dlg.SelectedPath;
                    txtFolderOpen.Text = PercorsoApriFile;
                    if (txtFolderOpen.Text != Properties.Settings.Default.OpenFilePath)
                    {
                        cmdSavePath.BackColor = Color.Red;
                    }
                    else
                    {
                        cmdSavePath.BackColor = Color.White;
                    }
                    PopulateDBList();
                }
            }
        }

        private void cmdSavePath_Click(object sender, EventArgs e)
        {
            if (PercorsoApriFile != "")
            {
                Properties.Settings.Default.OpenFilePath = PercorsoApriFile;
                Properties.Settings.Default.Save();
                cmdSavePath.BackColor = Color.White;
            }
        }

        private void lblFormTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void lblFormTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void lblFormTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void txtFolderOpen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                if (!Directory.Exists(txtFolderOpen.Text.Trim()))
                {
                    MessageBox.Show("This is not a valid folder...", "Folder error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PercorsoApriFile = txtFolderOpen.Text.Trim();
                    if (txtFolderOpen.Text != Properties.Settings.Default.OpenFilePath)
                    {
                        cmdSavePath.BackColor = Color.Red;
                    }
                    else
                    {
                        cmdSavePath.BackColor = Color.White;
                    }
                    PopulateDBList();
                }
        }

        private void Open_FileList_Click(object sender, EventArgs e)
        {
            //Apre il file selezionato per verificarne il contenuto
            XmlDocument readDoc = new XmlDocument();
            try
            {

                string CheckFile = PercorsoApriFile + "\\" + Open_FileList.SelectedItems[0].Text.Trim();
                readDoc.Load(CheckFile);

                int ARMcount = readDoc.SelectNodes("whitelist/arm").Count;
                TempDescrizione = "N° of entries: " + ARMcount.ToString();
            }
            catch (Exception ex)
            {
                TempDescrizione = "Error. Not valid XML DB file...\n" + ex.Message;
                goto fine;
            }

            XmlNodeList nodelist = readDoc.SelectNodes("whitelist/description");

            foreach (XmlNode node in nodelist)
            {
                try
                {
                    string DataCreazione = node.SelectSingleNode("creation_date").InnerText;
                    string Titolo = node.SelectSingleNode("title").InnerText;
                    string UltimaModifica = node.SelectSingleNode("last_modify").InnerText;
                    TempDescrizione = TempDescrizione + "\nCreated on: " + DataCreazione + "\nLast modify on: " + UltimaModifica + "\nTitle: " + Titolo;
                }
                catch (Exception ex)
                {
                    TempDescrizione = "Error. Not valid XML DB file...\n" + ex.Message;
                }
            }

            fine:
            lblDBProperties.Text = TempDescrizione;
        }

        private void Open_FileList_DoubleClick(object sender, EventArgs e)
        {
            //Passo alla scheda di Editing del DB e leggo il contenuto
            TabControl.Controls[0].Enabled = false;
            TabControl.Controls[1].Enabled = true;
            TabControl.Controls[2].Enabled = true;
            TabControl.SelectedIndex = 1;
            ArchivioInUso = PercorsoApriFile + "\\" + Open_FileList.SelectedItems[0].Text.Trim();
            LoadXMLContent();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            //Open the print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "Test Page Print";
                printDocument1.Print();
            }


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set margine sinistro
                int iLeftMargin = e.MarginBounds.Left;
                //Set top margin
                int iTopMargin = e.MarginBounds.Top;
                //Considero se vanno stampante altre pagine o no
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= dataGridView.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Print Header
                            e.Graphics.DrawString("Whitelisted ARMs", new Font(dataGridView.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Whitelisted ARMs", new Font(dataGridView.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = "Printed on: " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Print della data
                            e.Graphics.DrawString(strDate, new Font(dataGridView.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(dataGridView.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Whitelisted ARMs", new Font(new Font(dataGridView.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Disegno le colonne                
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Disegno il contenuto delle colonne                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                var a = (int)arrColumnLefts[iCount];
                                var b = (float)iTopMargin;
                                var c = (int)arrColumnWidths[iCount];
                                var d = (float)iCellHeight;

                                //new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                //          (int)arrColumnWidths[iCount], (float)iCellHeight);

                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Disegna i bordi delle celle
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }

                //Se ci sono ancora linee, vado su un'altra pagina
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XMLToExcel(string strXMLPath, string outputFileName, string sheetName)
        {
            string strPath = Path.GetDirectoryName(strXMLPath);
            DataSet dsXML = new DataSet();
            dsXML.ReadXml(strXMLPath);
            strPath = strPath + "\\" + outputFileName + ".xlsx";
            DataTable tblXML = dsXML.Tables[0];
            tblXML.TableName = sheetName;
            //DataTableToFilePath(tblXML, strPath);

        }

        private void cmdPrintPreview_Click(object sender, EventArgs e)
        {
            //Open the print preview dialog
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocument1;
            objPPdialog.ShowDialog();
        }

        private void Open_FileList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtARMsnEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !System.Uri.IsHexDigit(e.KeyChar) && c != 0x08;
        }

        private void cmdSaveToXML_Click(object sender, EventArgs e)
        {
            try
            {
                dpLastModify.Focus();
                dpLastModify.Value = DateTime.Now;
                txtDBTitle.Focus();
                DataSet dssave = ((DataTable)dataGridView.DataSource).DataSet;
                dssave.WriteXml(ArchivioInUso);
                MessageBox.Show("The archive was correctly saved.","Saved" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during saving the archive.\n" + ex.Message, "NOT SAVED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtReadFromSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !System.Uri.IsHexDigit(e.KeyChar) && c != 0x08;
            txtReadFromSP.BackColor = Color.White;

            if(txtReadFromSP.Text.Trim().Length == 16)
            {
                txtQRCode.Focus();
            }
        }

        private void cmdAddNewDB_Click(object sender, EventArgs e)
        {
            //Crea un nuovo archivio
            string msg = "This will create a new white list DB inside this path:\n" + PercorsoApriFile + "\nPlease specify a name for this new archive";
            //DialogResult resultmsg = MessageBox.Show(msg, "New archive confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            const int approxInputBoxWidth = 370;
            const int approxInputBoxHeight = 158;

            int left = this.Left + (this.Width / 2) - (approxInputBoxWidth / 2);
            left = left < 0 ? 0 : left;
            int top = this.Top + (this.Height / 2) - (approxInputBoxHeight / 2);
            top = top < 0 ? 0 : top;

            string input = Microsoft.VisualBasic.Interaction.InputBox(msg, "New archive confirmation", "", left, top);
            input = input.Trim();

            if (input != "")
            {

                string oldPathAndName = ApplicationFolder + "\\DO_NOT_REMOVE.xml";
                string newPathAndName = PercorsoApriFile + "\\" + input + ".xml";
                try { 
                    System.IO.File.Copy(oldPathAndName, newPathAndName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating the new archive.\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                PopulateDBList();

            }
        }

        private void cmdAddToTmpList_Click(object sender, EventArgs e)
        {

            if (txtReadFromSP.Text.Trim().Length == 16)
            {
                DataRow armdr = armdt.NewRow();
                armdr["serial_no"] = txtReadFromSP.Text.Trim();
                armdr["qr_code"] = txtQRCode.Text.Trim();
                armdr["added_on"] = dpAddARMAddedOn.Value.ToShortDateString();
                armdr["added_by"] = txtAddArmAddedBy.Text.Trim();
                if (chkAddARMActive.Checked == true)
                {
                    armdr["active"] = "True";
                }
                else
                {
                    armdr["active"] = "False";
                }
                armdt.Rows.Add(armdr);
                txtReadFromSP.Text = "";
                txtQRCode.Text = "";
                txtReadFromSP.BackColor = Color.White;
                cmdAddToDB.BackColor = Color.Red;
                txtReadFromSP.Focus();
            }
            else
            {
                MessageBox.Show("ARM Serial number length must be of 16 characters.", "Invalid ARM S/N", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell != null && dataGridView.CurrentCell.RowIndex >= 0)
            {
                if (bindingSource2.Count != 0)
                {
                    DataGridViewRow selectedRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
                    int index = bindingSource2.Find("serial_no", selectedRow.Cells["serial_no"].Value);

                    if (index >= 0)
                    {
                        bindingSource2.Position = index;
                    }
                }
            }
        }

        private void cmdAddToDB_Click(object sender, EventArgs e)
        {

            DialogResult tmp = new DialogResult();
            tmp = MessageBox.Show("Do you really want to add these entries to the white list?", "Merging confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tmp == DialogResult.Yes)
            {
                ds.Tables[1].Merge(armdt);
                armdt.Clear();
                lblRecordCount.Text = "Record count: " + (dataGridView.RowCount - 1).ToString();
                TabControl.SelectedIndex = 1;
                cmdAddToDB.BackColor = Color.White;
            }
        }

        private void TabControl_TabIndexChanged(object sender, EventArgs e)
        {



        }


        private void copyAlltoClipboard()
        {
            dataGridView.SelectAll();
            DataObject dataObj = dataGridView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void cmdExportToCSV_Click(object sender, EventArgs e)
        {
            //CopyAlltoClipboard(dataGridView);
            //Microsoft.Office.Interop.Excel.Application xlexcel;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;
            //xlexcel = new Microsoft.Office.Interop.Excel.Application();
            //xlexcel.Visible = true;
            //xlWorkBook = xlexcel.Workbooks.Add(misValue);
            //xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //xlWorkSheet.Name = "pippo";
            //Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            //CR.Select();
            //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            //((Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Range["A1"]).EntireColumn.Delete(null); // delete the first column that has rows indexes
            //xlWorkBook.SaveAs("c:\\temp\\teeeest.xlsx");
        }

        private void CopyAlltoClipboard(DataGridView dataGridViewControl)
        {
            dataGridView.SelectAll();
            DataObject dataObj = dataGridView.GetClipboardContent();
            if (dataObj != null)
                Invoke((Action)(() => { Clipboard.SetDataObject(dataObj); }));
        }


        private void cmdExportDB_Click(object sender, EventArgs e)
        {

            string PercorsoExport = "";

            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Select the folder for export";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PercorsoExport = dlg.SelectedPath;
                }
            }




            if (PercorsoExport != "")
            {

                try { 
                    string Buffer = "";

                    Buffer = "static const unsigned int OPT_ECDC[]={ \n";

                    int ContatoreVettore = 0;

                    foreach (DataGridViewRow row in dataGridView.Rows)
                        {

                            if(row.Cells["active"].Value != null && row.Cells["active"].Value.ToString().Trim().ToLower() == "true") { 
                                string RealSerial = row.Cells["serial_no"].Value.ToString().Trim().ToUpper();

                                if (RealSerial.Length == 16)
                                {
                                    string EncryptedSerial = EncryptSerial(RealSerial) + "\n";
                                    ContatoreVettore++;

                                //writer.Write(EncryptedSerial);
                                Buffer = Buffer + EncryptedSerial;
                                }
                            }
                        }


                    ContatoreVettore = ContatoreVettore * 4;

                    Buffer = Buffer + "};\n\n #define DIM_OPT_ECDC " + ContatoreVettore.ToString().Trim() + "\n#define OPOTPFAIL 0\n#define OPOTPOK 1\n";
           
                    File.WriteAllText(PercorsoExport + "\\export.h", Buffer);

                    if (ContatoreVettore < 4)
                    {
                        MessageBox.Show("The WhiteList archive was correctly exported into selected destination folder but it is empty!", "Export finished with errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("The WhiteList archive was correctly exported into selected destination folder.", "Export finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    

                }

                catch (Exception ex)
                {
                    MessageBox.Show("In orderd to open another whitelist archive, please close the application and open it again.\n" + ex.Message, "Not supported", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }







        }


        private static string EncryptSerial(string SerialToEncrypt)
        {


            string key = "603deb1015ca71be2b73aef0857d7781";
            string message = SerialToEncrypt;



            byte[] cipher = Encoding.ASCII.GetBytes(message);
            byte[] btkey = HexStringToByteArray(key);



            RijndaelManaged aes128 = new RijndaelManaged();
            aes128.Mode = CipherMode.ECB;
            aes128.Padding = PaddingMode.None;



            ICryptoTransform encryptor = aes128.CreateEncryptor(btkey, null);
            MemoryStream ms = new MemoryStream(cipher);
            CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Read);

            byte[] plain = new byte[cipher.Length];
            int encryptcount = cs.Read(plain, 0, plain.Length);

            string hex = BitConverter.ToString(plain);
            hex = hex.Replace("-", "");
            hex = hex.ToLower();

            string result = "";
            result = "0x" + hex.Substring(6, 2) + hex.Substring(4, 2) + hex.Substring(2, 2) + hex.Substring(0, 2) + ",";
            result = result + "0x" + hex.Substring(14, 2) + hex.Substring(12, 2) + hex.Substring(10, 2) + hex.Substring(8, 2) + ",";
            result = result + "0x" + hex.Substring(22, 2) + hex.Substring(20, 2) + hex.Substring(18, 2) + hex.Substring(16, 2) + ",";
            result = result + "0x" + hex.Substring(30, 2) + hex.Substring(28, 2) + hex.Substring(26, 2) + hex.Substring(24, 2) + ",";

            ms.Close();
            cs.Close();


            return result;



        }
        public static byte[] HexStringToByteArray(string s)
        {
            byte[] ret = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
            {
                ret[i / 2] = Convert.ToByte(s.Substring(i, 2), 16);
            }
            return ret;
        }

        private void cmdStartSP_Click(object sender, EventArgs e)
        {
            string SerialToOpen = "";
            string SerialToOpenSpeed = "";

            if (SerialPortNumber.Items.Count > 0)
            { 
                SerialToOpen = SerialPortNumber.SelectedItem.ToString().Trim();
                SerialToOpenSpeed = cmbSpeedSP.SelectedItem.ToString().Trim();
            }

            if (SerialToOpen != "" && SerialToOpenSpeed != "")
            {
                try
                { 
                    mySerialPort.PortName = SerialToOpen;
                    mySerialPort.BaudRate = Convert.ToInt32(SerialToOpenSpeed);
                    mySerialPort.Parity = Parity.None;
                    mySerialPort.StopBits = StopBits.One;
                    mySerialPort.DataBits = 8;
                    mySerialPort.Handshake = Handshake.None;

                    mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                    mySerialPort.Open();

                    cmdStartSP.Enabled = false;
                    cmdStopSP.Enabled = true;
                    progressBar1.MarqueeAnimationSpeed = 60;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error on serial port opening.\n" + ex.Message, "Serial port error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Invalid serial port parameters.", "Invalid Serial Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            SerialPortBuffer = SerialPortBuffer + indata;

            string ValidSerial1 = "";
            string ValidSerial = "";
            



            if (SerialPortBuffer.Length > 52)
            {

                string[] Seriali = SerialPortBuffer.Split('\n');
                SerialPortBuffer = "";

                foreach (String Seriale in Seriali)
                {
                    if(Seriale.Length == 16 && ValidSerial1 == "")
                    {
                        ValidSerial1 = Seriale;
                    }
                    if (Seriale.Length == 16 && ValidSerial1 != "")
                    {
                        if(ValidSerial1 == Seriale)
                        {
                            ValidSerial = Seriale;
                            GlobalSerial = Seriale;
                            this.Invoke(new EventHandler(CheckValidSerial));


                        }
                    }
                }



            }


        }

        private void CheckValidSerial(object sender, EventArgs e)
        {

            bool SerialeTrovato = false;

            if (GridViewSerials.RowCount <= 1)
            {
                txtReadFromSP.Text = GlobalSerial;
                txtReadFromSP.BackColor = Color.LightGreen;
                txtQRCode.Focus();
                SerialeTrovato = true;

            }


            foreach (DataGridViewRow row in GridViewSerials.Rows)
            {

                if (row.Cells["serial_no"].Value != null)
                {
                    string RealSerial = row.Cells["serial_no"].Value.ToString().Trim().ToUpper();

                    if (RealSerial == GlobalSerial)
                    {
                        SerialeTrovato = true;
                    }
                }
            }

            if (SerialeTrovato == false)
            {
                txtReadFromSP.Text = GlobalSerial;
                txtReadFromSP.BackColor = Color.LightGreen;
                txtQRCode.Focus();
            }

        }

        private void cmdStopSP_Click(object sender, EventArgs e)
        {
            mySerialPort.Close();
            cmdStartSP.Enabled = true;
            cmdStopSP.Enabled = false;
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Value = 0;
        }

        private void SerialPortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SerialPortNumber.SelectedItem.ToString() != "")
            {
                cmdStartSP.Enabled = true;
            }
            else
            {
                cmdStartSP.Enabled = false;
            }
        }

        private void txtQRCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && txtReadFromSP.Text.Length == 16)
            {
                DataRow armdr = armdt.NewRow();
                armdr["serial_no"] = txtReadFromSP.Text.Trim();
                armdr["qr_code"] = txtQRCode.Text.Trim();
                armdr["added_on"] = dpAddARMAddedOn.Value.ToShortDateString();
                armdr["added_by"] = txtAddArmAddedBy.Text.Trim();
                if (chkAddARMActive.Checked == true)
                {
                    armdr["active"] = "True";
                }
                else
                {
                    armdr["active"] = "False";
                }
                armdt.Rows.Add(armdr);
                txtReadFromSP.Text = "";
                txtQRCode.Text = "";
                txtReadFromSP.BackColor = Color.White;
                cmdAddToDB.BackColor = Color.Red;
                txtReadFromSP.Focus();

            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(TabControl.SelectedIndex == 0 && TabControl.Controls[0].Enabled == false)
            {
                MessageBox.Show("In orderd to open another whitelist archive, please close the application and open it again.", "Not supported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (TabControl.SelectedIndex == 2)
            {
                UpdateSerialPortEnum();
                txtReadFromSP.Focus();
                txtReadFromSP.BackColor = Color.White;
                txtAddArmAddedBy.Text = txtDBCreatedBy.Text;
            }
        }

        private void btnGoToFolder_Click_1(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", PercorsoApriFile);
        }
    }
}
