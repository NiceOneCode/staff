namespace WLM
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Open_FileList = new MetroFramework.Controls.MetroListView();
            this.dpLastModify = new System.Windows.Forms.DateTimePicker();
            this.dpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.dpAddedOnEdit = new System.Windows.Forms.DateTimePicker();
            this.btnGoToFolder = new MetroFramework.Controls.MetroButton();
            this.cmdAddNewDB = new MetroFramework.Controls.MetroButton();
            this.cmdSavePath = new MetroFramework.Controls.MetroButton();
            this.btnOpenFolder = new MetroFramework.Controls.MetroButton();
            this.cmdPrintPreview = new MetroFramework.Controls.MetroButton();
            this.cmdExportDB = new MetroFramework.Controls.MetroButton();
            this.cmdPrint = new MetroFramework.Controls.MetroButton();
            this.cmdExportToCSV = new MetroFramework.Controls.MetroButton();
            this.cmdSaveToXML = new MetroFramework.Controls.MetroButton();
            this.cmdAddToDB = new MetroFramework.Controls.MetroButton();
            this.cmdAddToTmpList = new MetroFramework.Controls.MetroButton();
            this.cmdStopSP = new MetroFramework.Controls.MetroButton();
            this.cmdSerialPortUpdate = new MetroFramework.Controls.MetroButton();
            this.cmdStartSP = new MetroFramework.Controls.MetroButton();
            this.txtAddArmAddedBy = new MetroFramework.Controls.MetroTextBox();
            this.txtQRCode = new MetroFramework.Controls.MetroTextBox();
            this.txtReadFromSP = new MetroFramework.Controls.MetroTextBox();
            this.cmbSpeedSP = new MetroFramework.Controls.MetroComboBox();
            this.SerialPortNumber = new MetroFramework.Controls.MetroComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.TabPageOpen = new MetroFramework.Controls.MetroTabPage();
            this.lblDBProperties = new MetroFramework.Controls.MetroLabel();
            this.txtFolderOpen = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TabPageEdit = new MetroFramework.Controls.MetroTabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddedByEdit = new MetroFramework.Controls.MetroTextBox();
            this.chkActiveEdit = new MetroFramework.Controls.MetroCheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtQR = new MetroFramework.Controls.MetroTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtARMsnEdit = new MetroFramework.Controls.MetroTextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBCreatedBy = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDBDescription = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDBCustomer = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDBTitle = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnUpdateSerialPortList = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridViewSerials = new System.Windows.Forms.DataGridView();
            this.chkAddARMActive = new MetroFramework.Controls.MetroCheckBox();
            this.dpAddARMAddedOn = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabAbout = new MetroFramework.Controls.MetroTabPage();
            this.lblSWVersion = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TabControl.SuspendLayout();
            this.TabPageOpen.SuspendLayout();
            this.TabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.btnUpdateSerialPortList.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSerials)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.TabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 5);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(666, 20);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "WhiteListManager - v0.1";
            this.lblFormTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblFormTitle_MouseDown);
            this.lblFormTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblFormTitle_MouseMove);
            this.lblFormTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblFormTitle_MouseUp);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.toolTip.ForeColor = System.Drawing.Color.Black;
            this.toolTip.InitialDelay = 500;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // Open_FileList
            // 
            this.Open_FileList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open_FileList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Open_FileList.FullRowSelect = true;
            this.Open_FileList.Location = new System.Drawing.Point(8, 70);
            this.Open_FileList.MultiSelect = false;
            this.Open_FileList.Name = "Open_FileList";
            this.Open_FileList.OwnerDraw = true;
            this.Open_FileList.Size = new System.Drawing.Size(746, 373);
            this.Open_FileList.TabIndex = 1;
            this.toolTip.SetToolTip(this.Open_FileList, "One click for archive file properties, double click to open it");
            this.Open_FileList.UseCompatibleStateImageBehavior = false;
            this.Open_FileList.UseSelectable = true;
            this.Open_FileList.View = System.Windows.Forms.View.List;
            this.Open_FileList.SelectedIndexChanged += new System.EventHandler(this.Open_FileList_SelectedIndexChanged);
            this.Open_FileList.Click += new System.EventHandler(this.Open_FileList_Click);
            this.Open_FileList.DoubleClick += new System.EventHandler(this.Open_FileList_DoubleClick);
            // 
            // dpLastModify
            // 
            this.dpLastModify.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpLastModify.Location = new System.Drawing.Point(323, 85);
            this.dpLastModify.Name = "dpLastModify";
            this.dpLastModify.Size = new System.Drawing.Size(122, 23);
            this.dpLastModify.TabIndex = 12;
            this.toolTip.SetToolTip(this.dpLastModify, "Last time that DB was updated");
            // 
            // dpCreationDate
            // 
            this.dpCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpCreationDate.Location = new System.Drawing.Point(90, 85);
            this.dpCreationDate.Name = "dpCreationDate";
            this.dpCreationDate.Size = new System.Drawing.Size(122, 23);
            this.dpCreationDate.TabIndex = 11;
            this.toolTip.SetToolTip(this.dpCreationDate, "Date of creation of this DB");
            // 
            // dpAddedOnEdit
            // 
            this.dpAddedOnEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpAddedOnEdit.Location = new System.Drawing.Point(96, 467);
            this.dpAddedOnEdit.Name = "dpAddedOnEdit";
            this.dpAddedOnEdit.Size = new System.Drawing.Size(122, 20);
            this.dpAddedOnEdit.TabIndex = 20;
            this.toolTip.SetToolTip(this.dpAddedOnEdit, "Date of creation of this DB");
            // 
            // btnGoToFolder
            // 
            this.btnGoToFolder.AccessibleDescription = "Click to choose folder in which browse into.";
            this.btnGoToFolder.BackColor = System.Drawing.Color.White;
            this.btnGoToFolder.BackgroundImage = global::WLM.Properties.Resources.folder_16x16;
            this.btnGoToFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoToFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoToFolder.Location = new System.Drawing.Point(760, 145);
            this.btnGoToFolder.Name = "btnGoToFolder";
            this.btnGoToFolder.Size = new System.Drawing.Size(70, 58);
            this.btnGoToFolder.TabIndex = 5;
            this.toolTip.SetToolTip(this.btnGoToFolder, "Open selected folder in Windows");
            this.btnGoToFolder.UseSelectable = true;
            this.btnGoToFolder.Click += new System.EventHandler(this.btnGoToFolder_Click_1);
            // 
            // cmdAddNewDB
            // 
            this.cmdAddNewDB.AccessibleDescription = "";
            this.cmdAddNewDB.BackColor = System.Drawing.Color.White;
            this.cmdAddNewDB.BackgroundImage = global::WLM.Properties.Resources.new_file_32x321;
            this.cmdAddNewDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdAddNewDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAddNewDB.Location = new System.Drawing.Point(760, 70);
            this.cmdAddNewDB.Name = "cmdAddNewDB";
            this.cmdAddNewDB.Size = new System.Drawing.Size(70, 58);
            this.cmdAddNewDB.TabIndex = 4;
            this.toolTip.SetToolTip(this.cmdAddNewDB, "Create new empty XML archive file inside this folder");
            this.cmdAddNewDB.UseSelectable = true;
            this.cmdAddNewDB.Click += new System.EventHandler(this.cmdAddNewDB_Click);
            // 
            // cmdSavePath
            // 
            this.cmdSavePath.AccessibleDescription = "Click to choose folder in which browse into.";
            this.cmdSavePath.BackColor = System.Drawing.Color.White;
            this.cmdSavePath.BackgroundImage = global::WLM.Properties.Resources.floppy_bn_16x16;
            this.cmdSavePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdSavePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSavePath.Location = new System.Drawing.Point(798, 34);
            this.cmdSavePath.Name = "cmdSavePath";
            this.cmdSavePath.Size = new System.Drawing.Size(32, 23);
            this.cmdSavePath.TabIndex = 3;
            this.toolTip.SetToolTip(this.cmdSavePath, "Save current path as default on application open");
            this.cmdSavePath.UseSelectable = true;
            this.cmdSavePath.Click += new System.EventHandler(this.cmdSavePath_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.AccessibleDescription = "Click to choose folder in which browse into.";
            this.btnOpenFolder.BackColor = System.Drawing.Color.White;
            this.btnOpenFolder.BackgroundImage = global::WLM.Properties.Resources.open_folder_bn_16x16;
            this.btnOpenFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFolder.Location = new System.Drawing.Point(760, 34);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(32, 23);
            this.btnOpenFolder.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnOpenFolder, "Select XML Archive files folder");
            this.btnOpenFolder.UseSelectable = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // cmdPrintPreview
            // 
            this.cmdPrintPreview.AccessibleDescription = "";
            this.cmdPrintPreview.BackgroundImage = global::WLM.Properties.Resources.print_preview_16x16;
            this.cmdPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPrintPreview.Location = new System.Drawing.Point(716, 56);
            this.cmdPrintPreview.Name = "cmdPrintPreview";
            this.cmdPrintPreview.Size = new System.Drawing.Size(39, 23);
            this.cmdPrintPreview.TabIndex = 15;
            this.toolTip.SetToolTip(this.cmdPrintPreview, "Print preview of current white list");
            this.cmdPrintPreview.UseSelectable = true;
            this.cmdPrintPreview.Click += new System.EventHandler(this.cmdPrintPreview_Click);
            // 
            // cmdExportDB
            // 
            this.cmdExportDB.AccessibleDescription = "";
            this.cmdExportDB.BackgroundImage = global::WLM.Properties.Resources.document_secure_32x32;
            this.cmdExportDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdExportDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdExportDB.Location = new System.Drawing.Point(761, 20);
            this.cmdExportDB.Name = "cmdExportDB";
            this.cmdExportDB.Size = new System.Drawing.Size(57, 92);
            this.cmdExportDB.TabIndex = 17;
            this.toolTip.SetToolTip(this.cmdExportDB, "Encrypt and export current white list. If the file already exist in the destinati" +
        "on folder, it will be overwritten.");
            this.cmdExportDB.UseSelectable = true;
            this.cmdExportDB.Click += new System.EventHandler(this.cmdExportDB_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.AccessibleDescription = "";
            this.cmdPrint.BackgroundImage = global::WLM.Properties.Resources.Printer_16x16;
            this.cmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPrint.Location = new System.Drawing.Point(716, 89);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(39, 23);
            this.cmdPrint.TabIndex = 16;
            this.toolTip.SetToolTip(this.cmdPrint, "Print current white list");
            this.cmdPrint.UseSelectable = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdExportToCSV
            // 
            this.cmdExportToCSV.AccessibleDescription = "";
            this.cmdExportToCSV.BackgroundImage = global::WLM.Properties.Resources.Export_16x16;
            this.cmdExportToCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdExportToCSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdExportToCSV.Location = new System.Drawing.Point(716, 20);
            this.cmdExportToCSV.Name = "cmdExportToCSV";
            this.cmdExportToCSV.Size = new System.Drawing.Size(39, 23);
            this.cmdExportToCSV.TabIndex = 14;
            this.toolTip.SetToolTip(this.cmdExportToCSV, "Export current white list to CSV file");
            this.cmdExportToCSV.UseSelectable = true;
            this.cmdExportToCSV.Click += new System.EventHandler(this.cmdExportToCSV_Click);
            // 
            // cmdSaveToXML
            // 
            this.cmdSaveToXML.AccessibleDescription = "";
            this.cmdSaveToXML.BackColor = System.Drawing.Color.White;
            this.cmdSaveToXML.BackgroundImage = global::WLM.Properties.Resources.floppy_bn_16x161;
            this.cmdSaveToXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdSaveToXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSaveToXML.Location = new System.Drawing.Point(767, 436);
            this.cmdSaveToXML.Name = "cmdSaveToXML";
            this.cmdSaveToXML.Size = new System.Drawing.Size(57, 60);
            this.cmdSaveToXML.TabIndex = 23;
            this.toolTip.SetToolTip(this.cmdSaveToXML, "Save changes of this white list");
            this.cmdSaveToXML.UseSelectable = true;
            this.cmdSaveToXML.Click += new System.EventHandler(this.cmdSaveToXML_Click);
            // 
            // cmdAddToDB
            // 
            this.cmdAddToDB.AccessibleDescription = "";
            this.cmdAddToDB.BackgroundImage = global::WLM.Properties.Resources.add_db_16x16;
            this.cmdAddToDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdAddToDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAddToDB.Location = new System.Drawing.Point(773, 25);
            this.cmdAddToDB.Name = "cmdAddToDB";
            this.cmdAddToDB.Size = new System.Drawing.Size(39, 36);
            this.cmdAddToDB.TabIndex = 7;
            this.toolTip.SetToolTip(this.cmdAddToDB, "Add temporary list to XML DB archive");
            this.cmdAddToDB.UseCustomBackColor = true;
            this.cmdAddToDB.UseSelectable = true;
            this.cmdAddToDB.Click += new System.EventHandler(this.cmdAddToDB_Click);
            // 
            // cmdAddToTmpList
            // 
            this.cmdAddToTmpList.AccessibleDescription = "";
            this.cmdAddToTmpList.BackgroundImage = global::WLM.Properties.Resources.add_document_16x16;
            this.cmdAddToTmpList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdAddToTmpList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAddToTmpList.Location = new System.Drawing.Point(719, 25);
            this.cmdAddToTmpList.Name = "cmdAddToTmpList";
            this.cmdAddToTmpList.Size = new System.Drawing.Size(39, 36);
            this.cmdAddToTmpList.TabIndex = 6;
            this.toolTip.SetToolTip(this.cmdAddToTmpList, "Add this ARM to temporary list");
            this.cmdAddToTmpList.UseSelectable = true;
            this.cmdAddToTmpList.Click += new System.EventHandler(this.cmdAddToTmpList_Click);
            // 
            // cmdStopSP
            // 
            this.cmdStopSP.AccessibleDescription = "";
            this.cmdStopSP.BackgroundImage = global::WLM.Properties.Resources.stop_16x16;
            this.cmdStopSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdStopSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdStopSP.Location = new System.Drawing.Point(774, 18);
            this.cmdStopSP.Name = "cmdStopSP";
            this.cmdStopSP.Size = new System.Drawing.Size(39, 36);
            this.cmdStopSP.TabIndex = 3;
            this.toolTip.SetToolTip(this.cmdStopSP, "Stop serial port acquiring");
            this.cmdStopSP.UseSelectable = true;
            this.cmdStopSP.Click += new System.EventHandler(this.cmdStopSP_Click);
            // 
            // cmdSerialPortUpdate
            // 
            this.cmdSerialPortUpdate.AccessibleDescription = "";
            this.cmdSerialPortUpdate.BackgroundImage = global::WLM.Properties.Resources.reload_16x16;
            this.cmdSerialPortUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdSerialPortUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSerialPortUpdate.Location = new System.Drawing.Point(12, 18);
            this.cmdSerialPortUpdate.Name = "cmdSerialPortUpdate";
            this.cmdSerialPortUpdate.Size = new System.Drawing.Size(39, 36);
            this.cmdSerialPortUpdate.TabIndex = 18;
            this.toolTip.SetToolTip(this.cmdSerialPortUpdate, "Refresh available serial port list");
            this.cmdSerialPortUpdate.UseSelectable = true;
            this.cmdSerialPortUpdate.Click += new System.EventHandler(this.cmdSerialPortUpdate_Click);
            // 
            // cmdStartSP
            // 
            this.cmdStartSP.AccessibleDescription = "";
            this.cmdStartSP.BackgroundImage = global::WLM.Properties.Resources.play_16x16;
            this.cmdStartSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdStartSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdStartSP.Enabled = false;
            this.cmdStartSP.Location = new System.Drawing.Point(720, 18);
            this.cmdStartSP.Name = "cmdStartSP";
            this.cmdStartSP.Size = new System.Drawing.Size(39, 36);
            this.cmdStartSP.TabIndex = 2;
            this.toolTip.SetToolTip(this.cmdStartSP, "Start serial port acquiring");
            this.cmdStartSP.UseSelectable = true;
            this.cmdStartSP.Click += new System.EventHandler(this.cmdStartSP_Click);
            // 
            // txtAddArmAddedBy
            // 
            // 
            // 
            // 
            this.txtAddArmAddedBy.CustomButton.Image = null;
            this.txtAddArmAddedBy.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtAddArmAddedBy.CustomButton.Name = "";
            this.txtAddArmAddedBy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddArmAddedBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddArmAddedBy.CustomButton.TabIndex = 1;
            this.txtAddArmAddedBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddArmAddedBy.CustomButton.UseSelectable = true;
            this.txtAddArmAddedBy.CustomButton.Visible = false;
            this.txtAddArmAddedBy.Lines = new string[0];
            this.txtAddArmAddedBy.Location = new System.Drawing.Point(107, 78);
            this.txtAddArmAddedBy.MaxLength = 32;
            this.txtAddArmAddedBy.Name = "txtAddArmAddedBy";
            this.txtAddArmAddedBy.PasswordChar = '\0';
            this.txtAddArmAddedBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddArmAddedBy.SelectedText = "";
            this.txtAddArmAddedBy.SelectionLength = 0;
            this.txtAddArmAddedBy.SelectionStart = 0;
            this.txtAddArmAddedBy.ShortcutsEnabled = true;
            this.txtAddArmAddedBy.Size = new System.Drawing.Size(192, 23);
            this.txtAddArmAddedBy.TabIndex = 8;
            this.toolTip.SetToolTip(this.txtAddArmAddedBy, "Person how is adding these devices");
            this.txtAddArmAddedBy.UseSelectable = true;
            this.txtAddArmAddedBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddArmAddedBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtQRCode
            // 
            // 
            // 
            // 
            this.txtQRCode.CustomButton.Image = null;
            this.txtQRCode.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.txtQRCode.CustomButton.Name = "";
            this.txtQRCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQRCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQRCode.CustomButton.TabIndex = 1;
            this.txtQRCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQRCode.CustomButton.UseSelectable = true;
            this.txtQRCode.CustomButton.Visible = false;
            this.txtQRCode.Lines = new string[0];
            this.txtQRCode.Location = new System.Drawing.Point(387, 42);
            this.txtQRCode.MaxLength = 64;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.PasswordChar = '\0';
            this.txtQRCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQRCode.SelectedText = "";
            this.txtQRCode.SelectionLength = 0;
            this.txtQRCode.SelectionStart = 0;
            this.txtQRCode.ShortcutsEnabled = true;
            this.txtQRCode.Size = new System.Drawing.Size(287, 23);
            this.txtQRCode.TabIndex = 5;
            this.toolTip.SetToolTip(this.txtQRCode, "QR Code read");
            this.txtQRCode.UseSelectable = true;
            this.txtQRCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQRCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQRCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQRCode_KeyPress);
            // 
            // txtReadFromSP
            // 
            this.txtReadFromSP.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtReadFromSP.CustomButton.Image = null;
            this.txtReadFromSP.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.txtReadFromSP.CustomButton.Name = "";
            this.txtReadFromSP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReadFromSP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReadFromSP.CustomButton.TabIndex = 1;
            this.txtReadFromSP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReadFromSP.CustomButton.UseSelectable = true;
            this.txtReadFromSP.CustomButton.Visible = false;
            this.txtReadFromSP.ForeColor = System.Drawing.Color.Red;
            this.txtReadFromSP.Lines = new string[0];
            this.txtReadFromSP.Location = new System.Drawing.Point(12, 42);
            this.txtReadFromSP.MaxLength = 16;
            this.txtReadFromSP.Name = "txtReadFromSP";
            this.txtReadFromSP.PasswordChar = '\0';
            this.txtReadFromSP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReadFromSP.SelectedText = "";
            this.txtReadFromSP.SelectionLength = 0;
            this.txtReadFromSP.SelectionStart = 0;
            this.txtReadFromSP.ShortcutsEnabled = true;
            this.txtReadFromSP.Size = new System.Drawing.Size(287, 23);
            this.txtReadFromSP.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtReadFromSP, "Serial number from ARM SOC");
            this.txtReadFromSP.UseCustomBackColor = true;
            this.txtReadFromSP.UseSelectable = true;
            this.txtReadFromSP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReadFromSP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtReadFromSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReadFromSP_KeyPress);
            // 
            // cmbSpeedSP
            // 
            this.cmbSpeedSP.FormattingEnabled = true;
            this.cmbSpeedSP.ItemHeight = 23;
            this.cmbSpeedSP.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmbSpeedSP.Location = new System.Drawing.Point(388, 20);
            this.cmbSpeedSP.Name = "cmbSpeedSP";
            this.cmbSpeedSP.Size = new System.Drawing.Size(140, 29);
            this.cmbSpeedSP.TabIndex = 1;
            this.toolTip.SetToolTip(this.cmbSpeedSP, "Choose baud spped to use.");
            this.cmbSpeedSP.UseSelectable = true;
            // 
            // SerialPortNumber
            // 
            this.SerialPortNumber.FormattingEnabled = true;
            this.SerialPortNumber.ItemHeight = 23;
            this.SerialPortNumber.Location = new System.Drawing.Point(176, 20);
            this.SerialPortNumber.Name = "SerialPortNumber";
            this.SerialPortNumber.Size = new System.Drawing.Size(94, 29);
            this.SerialPortNumber.TabIndex = 0;
            this.toolTip.SetToolTip(this.SerialPortNumber, "Choose serial port number to use.");
            this.SerialPortNumber.UseSelectable = true;
            this.SerialPortNumber.SelectedIndexChanged += new System.EventHandler(this.SerialPortNumber_SelectedIndexChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageOpen);
            this.TabControl.Controls.Add(this.TabPageEdit);
            this.TabControl.Controls.Add(this.btnUpdateSerialPortList);
            this.TabControl.Controls.Add(this.TabAbout);
            this.TabControl.HotTrack = true;
            this.TabControl.Location = new System.Drawing.Point(3, 28);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(846, 566);
            this.TabControl.TabIndex = 3;
            this.TabControl.UseSelectable = true;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            this.TabControl.TabIndexChanged += new System.EventHandler(this.TabControl_TabIndexChanged);
            // 
            // TabPageOpen
            // 
            this.TabPageOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TabPageOpen.Controls.Add(this.btnGoToFolder);
            this.TabPageOpen.Controls.Add(this.cmdAddNewDB);
            this.TabPageOpen.Controls.Add(this.lblDBProperties);
            this.TabPageOpen.Controls.Add(this.cmdSavePath);
            this.TabPageOpen.Controls.Add(this.Open_FileList);
            this.TabPageOpen.Controls.Add(this.btnOpenFolder);
            this.TabPageOpen.Controls.Add(this.txtFolderOpen);
            this.TabPageOpen.Controls.Add(this.metroLabel1);
            this.TabPageOpen.HorizontalScrollbarBarColor = true;
            this.TabPageOpen.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageOpen.HorizontalScrollbarSize = 10;
            this.TabPageOpen.Location = new System.Drawing.Point(4, 38);
            this.TabPageOpen.Name = "TabPageOpen";
            this.TabPageOpen.Size = new System.Drawing.Size(838, 524);
            this.TabPageOpen.TabIndex = 0;
            this.TabPageOpen.Text = "Open Archive      ";
            this.TabPageOpen.VerticalScrollbarBarColor = true;
            this.TabPageOpen.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageOpen.VerticalScrollbarSize = 10;
            // 
            // lblDBProperties
            // 
            this.lblDBProperties.AutoSize = true;
            this.lblDBProperties.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblDBProperties.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDBProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDBProperties.Location = new System.Drawing.Point(8, 448);
            this.lblDBProperties.Name = "lblDBProperties";
            this.lblDBProperties.Size = new System.Drawing.Size(126, 15);
            this.lblDBProperties.TabIndex = 15;
            this.lblDBProperties.Text = "No valid file selected.";
            // 
            // txtFolderOpen
            // 
            // 
            // 
            // 
            this.txtFolderOpen.CustomButton.Image = null;
            this.txtFolderOpen.CustomButton.Location = new System.Drawing.Point(724, 1);
            this.txtFolderOpen.CustomButton.Name = "";
            this.txtFolderOpen.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFolderOpen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFolderOpen.CustomButton.TabIndex = 1;
            this.txtFolderOpen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFolderOpen.CustomButton.UseSelectable = true;
            this.txtFolderOpen.CustomButton.Visible = false;
            this.txtFolderOpen.Lines = new string[0];
            this.txtFolderOpen.Location = new System.Drawing.Point(8, 34);
            this.txtFolderOpen.MaxLength = 32767;
            this.txtFolderOpen.Name = "txtFolderOpen";
            this.txtFolderOpen.PasswordChar = '\0';
            this.txtFolderOpen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFolderOpen.SelectedText = "";
            this.txtFolderOpen.SelectionLength = 0;
            this.txtFolderOpen.SelectionStart = 0;
            this.txtFolderOpen.ShortcutsEnabled = true;
            this.txtFolderOpen.Size = new System.Drawing.Size(746, 23);
            this.txtFolderOpen.TabIndex = 0;
            this.txtFolderOpen.UseSelectable = true;
            this.txtFolderOpen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFolderOpen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFolderOpen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolderOpen_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(302, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Path to looking into for XML white list archive files:";
            // 
            // TabPageEdit
            // 
            this.TabPageEdit.Controls.Add(this.label15);
            this.TabPageEdit.Controls.Add(this.txtAddedByEdit);
            this.TabPageEdit.Controls.Add(this.chkActiveEdit);
            this.TabPageEdit.Controls.Add(this.dpAddedOnEdit);
            this.TabPageEdit.Controls.Add(this.label17);
            this.TabPageEdit.Controls.Add(this.label18);
            this.TabPageEdit.Controls.Add(this.label20);
            this.TabPageEdit.Controls.Add(this.txtQR);
            this.TabPageEdit.Controls.Add(this.label21);
            this.TabPageEdit.Controls.Add(this.txtARMsnEdit);
            this.TabPageEdit.Controls.Add(this.bindingNavigator1);
            this.TabPageEdit.Controls.Add(this.groupBox1);
            this.TabPageEdit.Controls.Add(this.dataGridView);
            this.TabPageEdit.Controls.Add(this.cmdSaveToXML);
            this.TabPageEdit.HorizontalScrollbarBarColor = true;
            this.TabPageEdit.HorizontalScrollbarHighlightOnWheel = false;
            this.TabPageEdit.HorizontalScrollbarSize = 10;
            this.TabPageEdit.Location = new System.Drawing.Point(4, 38);
            this.TabPageEdit.Name = "TabPageEdit";
            this.TabPageEdit.Size = new System.Drawing.Size(838, 524);
            this.TabPageEdit.TabIndex = 1;
            this.TabPageEdit.Text = "Edit/Export Archive      ";
            this.TabPageEdit.VerticalScrollbarBarColor = true;
            this.TabPageEdit.VerticalScrollbarHighlightOnWheel = false;
            this.TabPageEdit.VerticalScrollbarSize = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(261, 471);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Added by:";
            // 
            // txtAddedByEdit
            // 
            // 
            // 
            // 
            this.txtAddedByEdit.CustomButton.Image = null;
            this.txtAddedByEdit.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtAddedByEdit.CustomButton.Name = "";
            this.txtAddedByEdit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddedByEdit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddedByEdit.CustomButton.TabIndex = 1;
            this.txtAddedByEdit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddedByEdit.CustomButton.UseSelectable = true;
            this.txtAddedByEdit.CustomButton.Visible = false;
            this.txtAddedByEdit.Lines = new string[0];
            this.txtAddedByEdit.Location = new System.Drawing.Point(332, 468);
            this.txtAddedByEdit.MaxLength = 32;
            this.txtAddedByEdit.Name = "txtAddedByEdit";
            this.txtAddedByEdit.PasswordChar = '\0';
            this.txtAddedByEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddedByEdit.SelectedText = "";
            this.txtAddedByEdit.SelectionLength = 0;
            this.txtAddedByEdit.SelectionStart = 0;
            this.txtAddedByEdit.ShortcutsEnabled = true;
            this.txtAddedByEdit.Size = new System.Drawing.Size(263, 23);
            this.txtAddedByEdit.TabIndex = 21;
            this.txtAddedByEdit.UseSelectable = true;
            this.txtAddedByEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddedByEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkActiveEdit
            // 
            this.chkActiveEdit.AutoSize = true;
            this.chkActiveEdit.Location = new System.Drawing.Point(699, 468);
            this.chkActiveEdit.Name = "chkActiveEdit";
            this.chkActiveEdit.Size = new System.Drawing.Size(26, 15);
            this.chkActiveEdit.TabIndex = 22;
            this.chkActiveEdit.Text = " ";
            this.chkActiveEdit.UseSelectable = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 471);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Added on:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(628, 468);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Active:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(380, 435);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "QR Code:";
            // 
            // txtQR
            // 
            // 
            // 
            // 
            this.txtQR.CustomButton.Image = null;
            this.txtQR.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtQR.CustomButton.Name = "";
            this.txtQR.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQR.CustomButton.TabIndex = 1;
            this.txtQR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQR.CustomButton.UseSelectable = true;
            this.txtQR.CustomButton.Visible = false;
            this.txtQR.Lines = new string[0];
            this.txtQR.Location = new System.Drawing.Point(451, 432);
            this.txtQR.MaxLength = 64;
            this.txtQR.Name = "txtQR";
            this.txtQR.PasswordChar = '\0';
            this.txtQR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQR.SelectedText = "";
            this.txtQR.SelectionLength = 0;
            this.txtQR.SelectionStart = 0;
            this.txtQR.ShortcutsEnabled = true;
            this.txtQR.Size = new System.Drawing.Size(263, 23);
            this.txtQR.TabIndex = 19;
            this.txtQR.UseSelectable = true;
            this.txtQR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 435);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "ARM S/N:";
            // 
            // txtARMsnEdit
            // 
            // 
            // 
            // 
            this.txtARMsnEdit.CustomButton.Image = null;
            this.txtARMsnEdit.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtARMsnEdit.CustomButton.Name = "";
            this.txtARMsnEdit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtARMsnEdit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtARMsnEdit.CustomButton.TabIndex = 1;
            this.txtARMsnEdit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtARMsnEdit.CustomButton.UseSelectable = true;
            this.txtARMsnEdit.CustomButton.Visible = false;
            this.txtARMsnEdit.Lines = new string[0];
            this.txtARMsnEdit.Location = new System.Drawing.Point(96, 432);
            this.txtARMsnEdit.MaxLength = 16;
            this.txtARMsnEdit.Name = "txtARMsnEdit";
            this.txtARMsnEdit.PasswordChar = '\0';
            this.txtARMsnEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtARMsnEdit.SelectedText = "";
            this.txtARMsnEdit.SelectionLength = 0;
            this.txtARMsnEdit.SelectionStart = 0;
            this.txtARMsnEdit.ShortcutsEnabled = true;
            this.txtARMsnEdit.Size = new System.Drawing.Size(263, 23);
            this.txtARMsnEdit.TabIndex = 18;
            this.txtARMsnEdit.UseSelectable = true;
            this.txtARMsnEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtARMsnEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtARMsnEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtARMsnEdit_KeyPress);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 499);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(838, 25);
            this.bindingNavigator1.TabIndex = 10;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Aggiungi nuovo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 22);
            this.bindingNavigatorCountItem.Text = "di {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Numero totale di elementi";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Elimina";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Sposta indietro";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posizione";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posizione corrente";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Sposta avanti";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cmdPrintPreview);
            this.groupBox1.Controls.Add(this.cmdExportDB);
            this.groupBox1.Controls.Add(this.lblRecordCount);
            this.groupBox1.Controls.Add(this.dpLastModify);
            this.groupBox1.Controls.Add(this.dpCreationDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDBCreatedBy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDBDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDBCustomer);
            this.groupBox1.Controls.Add(this.cmdPrint);
            this.groupBox1.Controls.Add(this.cmdExportToCSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDBTitle);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 118);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XML DB Properties";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(462, 89);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(88, 13);
            this.lblRecordCount.TabIndex = 21;
            this.lblRecordCount.Text = "Record count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Last modify:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Creation date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Created by:";
            // 
            // txtDBCreatedBy
            // 
            // 
            // 
            // 
            this.txtDBCreatedBy.CustomButton.Image = null;
            this.txtDBCreatedBy.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtDBCreatedBy.CustomButton.Name = "";
            this.txtDBCreatedBy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDBCreatedBy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBCreatedBy.CustomButton.TabIndex = 1;
            this.txtDBCreatedBy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBCreatedBy.CustomButton.UseSelectable = true;
            this.txtDBCreatedBy.CustomButton.Visible = false;
            this.txtDBCreatedBy.Lines = new string[0];
            this.txtDBCreatedBy.Location = new System.Drawing.Point(445, 52);
            this.txtDBCreatedBy.MaxLength = 32;
            this.txtDBCreatedBy.Name = "txtDBCreatedBy";
            this.txtDBCreatedBy.PasswordChar = '\0';
            this.txtDBCreatedBy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBCreatedBy.SelectedText = "";
            this.txtDBCreatedBy.SelectionLength = 0;
            this.txtDBCreatedBy.SelectionStart = 0;
            this.txtDBCreatedBy.ShortcutsEnabled = true;
            this.txtDBCreatedBy.Size = new System.Drawing.Size(263, 23);
            this.txtDBCreatedBy.TabIndex = 10;
            this.txtDBCreatedBy.UseSelectable = true;
            this.txtDBCreatedBy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBCreatedBy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Description:";
            // 
            // txtDBDescription
            // 
            // 
            // 
            // 
            this.txtDBDescription.CustomButton.Image = null;
            this.txtDBDescription.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtDBDescription.CustomButton.Name = "";
            this.txtDBDescription.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDBDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBDescription.CustomButton.TabIndex = 1;
            this.txtDBDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBDescription.CustomButton.UseSelectable = true;
            this.txtDBDescription.CustomButton.Visible = false;
            this.txtDBDescription.Lines = new string[0];
            this.txtDBDescription.Location = new System.Drawing.Point(90, 52);
            this.txtDBDescription.MaxLength = 64;
            this.txtDBDescription.Name = "txtDBDescription";
            this.txtDBDescription.PasswordChar = '\0';
            this.txtDBDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBDescription.SelectedText = "";
            this.txtDBDescription.SelectionLength = 0;
            this.txtDBDescription.SelectionStart = 0;
            this.txtDBDescription.ShortcutsEnabled = true;
            this.txtDBDescription.Size = new System.Drawing.Size(263, 23);
            this.txtDBDescription.TabIndex = 9;
            this.txtDBDescription.UseSelectable = true;
            this.txtDBDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Customer:";
            // 
            // txtDBCustomer
            // 
            // 
            // 
            // 
            this.txtDBCustomer.CustomButton.Image = null;
            this.txtDBCustomer.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtDBCustomer.CustomButton.Name = "";
            this.txtDBCustomer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDBCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBCustomer.CustomButton.TabIndex = 1;
            this.txtDBCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBCustomer.CustomButton.UseSelectable = true;
            this.txtDBCustomer.CustomButton.Visible = false;
            this.txtDBCustomer.Lines = new string[0];
            this.txtDBCustomer.Location = new System.Drawing.Point(445, 20);
            this.txtDBCustomer.MaxLength = 32;
            this.txtDBCustomer.Name = "txtDBCustomer";
            this.txtDBCustomer.PasswordChar = '\0';
            this.txtDBCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBCustomer.SelectedText = "";
            this.txtDBCustomer.SelectionLength = 0;
            this.txtDBCustomer.SelectionStart = 0;
            this.txtDBCustomer.ShortcutsEnabled = true;
            this.txtDBCustomer.Size = new System.Drawing.Size(263, 23);
            this.txtDBCustomer.TabIndex = 8;
            this.txtDBCustomer.UseSelectable = true;
            this.txtDBCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Title:";
            // 
            // txtDBTitle
            // 
            // 
            // 
            // 
            this.txtDBTitle.CustomButton.Image = null;
            this.txtDBTitle.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.txtDBTitle.CustomButton.Name = "";
            this.txtDBTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDBTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBTitle.CustomButton.TabIndex = 1;
            this.txtDBTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBTitle.CustomButton.UseSelectable = true;
            this.txtDBTitle.CustomButton.Visible = false;
            this.txtDBTitle.Lines = new string[0];
            this.txtDBTitle.Location = new System.Drawing.Point(90, 20);
            this.txtDBTitle.MaxLength = 32;
            this.txtDBTitle.Name = "txtDBTitle";
            this.txtDBTitle.PasswordChar = '\0';
            this.txtDBTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBTitle.SelectedText = "";
            this.txtDBTitle.SelectionLength = 0;
            this.txtDBTitle.SelectionStart = 0;
            this.txtDBTitle.ShortcutsEnabled = true;
            this.txtDBTitle.Size = new System.Drawing.Size(263, 23);
            this.txtDBTitle.TabIndex = 7;
            this.txtDBTitle.UseSelectable = true;
            this.txtDBTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Format = ">";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 136);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.Size = new System.Drawing.Size(827, 290);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // btnUpdateSerialPortList
            // 
            this.btnUpdateSerialPortList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateSerialPortList.Controls.Add(this.metroLabel4);
            this.btnUpdateSerialPortList.Controls.Add(this.groupBox3);
            this.btnUpdateSerialPortList.Controls.Add(this.groupBox2);
            this.btnUpdateSerialPortList.HorizontalScrollbarBarColor = true;
            this.btnUpdateSerialPortList.HorizontalScrollbarHighlightOnWheel = false;
            this.btnUpdateSerialPortList.HorizontalScrollbarSize = 10;
            this.btnUpdateSerialPortList.Location = new System.Drawing.Point(4, 38);
            this.btnUpdateSerialPortList.Name = "btnUpdateSerialPortList";
            this.btnUpdateSerialPortList.Size = new System.Drawing.Size(838, 524);
            this.btnUpdateSerialPortList.TabIndex = 2;
            this.btnUpdateSerialPortList.Text = "Read from device      ";
            this.btnUpdateSerialPortList.VerticalScrollbarBarColor = true;
            this.btnUpdateSerialPortList.VerticalScrollbarHighlightOnWheel = false;
            this.btnUpdateSerialPortList.VerticalScrollbarSize = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.GridViewSerials);
            this.groupBox3.Controls.Add(this.chkAddARMActive);
            this.groupBox3.Controls.Add(this.dpAddARMAddedOn);
            this.groupBox3.Controls.Add(this.txtAddArmAddedBy);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmdAddToDB);
            this.groupBox3.Controls.Add(this.cmdAddToTmpList);
            this.groupBox3.Controls.Add(this.txtQRCode);
            this.groupBox3.Controls.Add(this.txtReadFromSP);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(826, 407);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acquire data from device";
            // 
            // GridViewSerials
            // 
            this.GridViewSerials.AllowUserToOrderColumns = true;
            this.GridViewSerials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewSerials.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.Format = ">";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewSerials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.GridViewSerials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSerials.Location = new System.Drawing.Point(12, 111);
            this.GridViewSerials.MultiSelect = false;
            this.GridViewSerials.Name = "GridViewSerials";
            this.GridViewSerials.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridViewSerials.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewSerials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewSerials.Size = new System.Drawing.Size(800, 281);
            this.GridViewSerials.TabIndex = 11;
            // 
            // chkAddARMActive
            // 
            this.chkAddARMActive.AutoSize = true;
            this.chkAddARMActive.Checked = true;
            this.chkAddARMActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAddARMActive.Location = new System.Drawing.Point(490, 83);
            this.chkAddARMActive.Name = "chkAddARMActive";
            this.chkAddARMActive.Size = new System.Drawing.Size(26, 15);
            this.chkAddARMActive.TabIndex = 9;
            this.chkAddARMActive.Text = " ";
            this.chkAddARMActive.UseSelectable = true;
            // 
            // dpAddARMAddedOn
            // 
            this.dpAddARMAddedOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpAddARMAddedOn.Location = new System.Drawing.Point(596, 80);
            this.dpAddARMAddedOn.Name = "dpAddARMAddedOn";
            this.dpAddARMAddedOn.Size = new System.Drawing.Size(122, 20);
            this.dpAddARMAddedOn.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(525, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Added on:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(384, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Activate this ARM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "ARM added by:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(384, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Serial number from QR Code:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Serial number read from ARM (must be 16 chars):";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmdStopSP);
            this.groupBox2.Controls.Add(this.cmdSerialPortUpdate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmdStartSP);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbSpeedSP);
            this.groupBox2.Controls.Add(this.SerialPortNumber);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial port settings";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(582, 35);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(116, 19);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "COM Port:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(579, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "START/STOP Acquire:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Speed:";
            // 
            // TabAbout
            // 
            this.TabAbout.Controls.Add(this.metroLabel3);
            this.TabAbout.Controls.Add(this.metroLabel2);
            this.TabAbout.Controls.Add(this.metroLink1);
            this.TabAbout.Controls.Add(this.lblSWVersion);
            this.TabAbout.HorizontalScrollbarBarColor = true;
            this.TabAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.TabAbout.HorizontalScrollbarSize = 10;
            this.TabAbout.Location = new System.Drawing.Point(4, 38);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Size = new System.Drawing.Size(838, 524);
            this.TabAbout.TabIndex = 3;
            this.TabAbout.Text = "About";
            this.TabAbout.VerticalScrollbarBarColor = true;
            this.TabAbout.VerticalScrollbarHighlightOnWheel = false;
            this.TabAbout.VerticalScrollbarSize = 10;
            // 
            // lblSWVersion
            // 
            this.lblSWVersion.AutoSize = true;
            this.lblSWVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSWVersion.Location = new System.Drawing.Point(17, 14);
            this.lblSWVersion.Name = "lblSWVersion";
            this.lblSWVersion.Size = new System.Drawing.Size(94, 19);
            this.lblSWVersion.TabIndex = 2;
            this.lblSWVersion.Text = "metroLabel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WLM.Properties.Resources.Arch1;
            this.pictureBox1.Location = new System.Drawing.Point(664, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 20);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroLink1
            // 
            this.metroLink1.ForeColor = System.Drawing.Color.Blue;
            this.metroLink1.Location = new System.Drawing.Point(17, 102);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(148, 23);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "www.dmgengineering.it";
            this.metroLink1.UseCustomForeColor = true;
            this.metroLink1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(138, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "D.M.G. Engineering srl";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 46);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(169, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "STAFF - WhiteList Manager";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.Red;
            this.metroLabel4.Location = new System.Drawing.Point(18, 503);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(464, 15);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Remember to add this temporary list to the archive before closing the application" +
    "!";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 600);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFormTitle);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.TabControl.ResumeLayout(false);
            this.TabPageOpen.ResumeLayout(false);
            this.TabPageOpen.PerformLayout();
            this.TabPageEdit.ResumeLayout(false);
            this.TabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.btnUpdateSerialPortList.ResumeLayout(false);
            this.btnUpdateSerialPortList.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSerials)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TabAbout.ResumeLayout(false);
            this.TabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage TabPageOpen;
        private MetroFramework.Controls.MetroTabPage TabPageEdit;
        private MetroFramework.Controls.MetroTabPage btnUpdateSerialPortList;
        private MetroFramework.Controls.MetroTabPage TabAbout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.DateTimePicker dpLastModify;
        private System.Windows.Forms.DateTimePicker dpCreationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtDBCreatedBy;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtDBDescription;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtDBCustomer;
        private MetroFramework.Controls.MetroButton cmdPrint;
        private MetroFramework.Controls.MetroButton cmdExportToCSV;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtDBTitle;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private MetroFramework.Controls.MetroButton btnGoToFolder;
        private MetroFramework.Controls.MetroButton cmdAddNewDB;
        private MetroFramework.Controls.MetroLabel lblDBProperties;
        private MetroFramework.Controls.MetroButton cmdSavePath;
        private MetroFramework.Controls.MetroListView Open_FileList;
        private MetroFramework.Controls.MetroButton btnOpenFolder;
        private MetroFramework.Controls.MetroTextBox txtFolderOpen;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox SerialPortNumber;
        private MetroFramework.Controls.MetroComboBox cmbSpeedSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroButton cmdStartSP;
        private MetroFramework.Controls.MetroButton cmdAddToTmpList;
        private MetroFramework.Controls.MetroTextBox txtQRCode;
        private MetroFramework.Controls.MetroTextBox txtReadFromSP;
        private MetroFramework.Controls.MetroButton cmdSerialPortUpdate;
        private MetroFramework.Controls.MetroButton cmdStopSP;
        private MetroFramework.Controls.MetroButton cmdExportDB;
        private MetroFramework.Controls.MetroButton cmdAddToDB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroLabel lblSWVersion;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroCheckBox chkAddARMActive;
        private System.Windows.Forms.DateTimePicker dpAddARMAddedOn;
        private MetroFramework.Controls.MetroTextBox txtAddArmAddedBy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private MetroFramework.Controls.MetroButton cmdPrintPreview;
        private System.Windows.Forms.BindingSource bindingSource2;
        private MetroFramework.Controls.MetroCheckBox chkActiveEdit;
        private System.Windows.Forms.DateTimePicker dpAddedOnEdit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private MetroFramework.Controls.MetroTextBox txtQR;
        private System.Windows.Forms.Label label21;
        private MetroFramework.Controls.MetroTextBox txtARMsnEdit;
        private MetroFramework.Controls.MetroButton cmdSaveToXML;
        private System.Windows.Forms.DataGridView GridViewSerials;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroTextBox txtAddedByEdit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

