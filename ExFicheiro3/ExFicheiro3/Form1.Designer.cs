namespace ExFicheiro3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssLabelName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computadorDrivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesjpgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagesgifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagespngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsdocxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentspdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCountries = new System.Windows.Forms.TabPage();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.tabPageCities = new System.Windows.Forms.TabPage();
            this.buttonAddCities = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.tabPageInformations = new System.Windows.Forms.TabPage();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxPersonCity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDrives = new System.Windows.Forms.TabPage();
            this.textBoxDrives = new System.Windows.Forms.TextBox();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCountries.SuspendLayout();
            this.tabPageCities.SuspendLayout();
            this.tabPageInformations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageDrives.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabelName,
            this.tssLabelDate,
            this.tssLabelTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssLabelName
            // 
            this.tssLabelName.Name = "tssLabelName";
            this.tssLabelName.Size = new System.Drawing.Size(81, 17);
            this.tssLabelName.Text = "tssLabelName";
            // 
            // tssLabelDate
            // 
            this.tssLabelDate.Name = "tssLabelDate";
            this.tssLabelDate.Size = new System.Drawing.Size(73, 17);
            this.tssLabelDate.Text = "tssLabelDate";
            // 
            // tssLabelTime
            // 
            this.tssLabelTime.Name = "tssLabelTime";
            this.tssLabelTime.Size = new System.Drawing.Size(76, 17);
            this.tssLabelTime.Text = "tssLabelTime";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.folderToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.downloadToolStripMenuItem.Text = "Download";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFolderToolStripMenuItem,
            this.eraseFolderToolStripMenuItem,
            this.folderPropertiesToolStripMenuItem,
            this.eraseFilesToolStripMenuItem,
            this.showPropertiesToolStripMenuItem,
            this.computadorDrivesToolStripMenuItem,
            this.getFilesToolStripMenuItem});
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // createFolderToolStripMenuItem
            // 
            this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
            this.createFolderToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.createFolderToolStripMenuItem.Text = "Create Folder";
            // 
            // eraseFolderToolStripMenuItem
            // 
            this.eraseFolderToolStripMenuItem.Name = "eraseFolderToolStripMenuItem";
            this.eraseFolderToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.eraseFolderToolStripMenuItem.Text = "Erase Folder";
            // 
            // folderPropertiesToolStripMenuItem
            // 
            this.folderPropertiesToolStripMenuItem.Name = "folderPropertiesToolStripMenuItem";
            this.folderPropertiesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.folderPropertiesToolStripMenuItem.Text = "Folder Properties";
            // 
            // eraseFilesToolStripMenuItem
            // 
            this.eraseFilesToolStripMenuItem.Name = "eraseFilesToolStripMenuItem";
            this.eraseFilesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.eraseFilesToolStripMenuItem.Text = "Erase Files";
            // 
            // showPropertiesToolStripMenuItem
            // 
            this.showPropertiesToolStripMenuItem.Name = "showPropertiesToolStripMenuItem";
            this.showPropertiesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showPropertiesToolStripMenuItem.Text = "Show Properties";
            // 
            // computadorDrivesToolStripMenuItem
            // 
            this.computadorDrivesToolStripMenuItem.Name = "computadorDrivesToolStripMenuItem";
            this.computadorDrivesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.computadorDrivesToolStripMenuItem.Text = "Computador Drives";
            // 
            // getFilesToolStripMenuItem
            // 
            this.getFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagesjpgToolStripMenuItem,
            this.imagesgifToolStripMenuItem,
            this.imagespngToolStripMenuItem,
            this.documentsdocxToolStripMenuItem,
            this.documentspdfToolStripMenuItem});
            this.getFilesToolStripMenuItem.Name = "getFilesToolStripMenuItem";
            this.getFilesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.getFilesToolStripMenuItem.Text = "Get Files";
            // 
            // imagesjpgToolStripMenuItem
            // 
            this.imagesjpgToolStripMenuItem.Name = "imagesjpgToolStripMenuItem";
            this.imagesjpgToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.imagesjpgToolStripMenuItem.Text = "Images (*.jpg)";
            // 
            // imagesgifToolStripMenuItem
            // 
            this.imagesgifToolStripMenuItem.Name = "imagesgifToolStripMenuItem";
            this.imagesgifToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.imagesgifToolStripMenuItem.Text = "Images (*.gif)";
            // 
            // imagespngToolStripMenuItem
            // 
            this.imagespngToolStripMenuItem.Name = "imagespngToolStripMenuItem";
            this.imagespngToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.imagespngToolStripMenuItem.Text = "Images (*.png)";
            // 
            // documentsdocxToolStripMenuItem
            // 
            this.documentsdocxToolStripMenuItem.Name = "documentsdocxToolStripMenuItem";
            this.documentsdocxToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.documentsdocxToolStripMenuItem.Text = "Documents (*.docx)";
            // 
            // documentspdfToolStripMenuItem
            // 
            this.documentspdfToolStripMenuItem.Name = "documentspdfToolStripMenuItem";
            this.documentspdfToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.documentspdfToolStripMenuItem.Text = "Documents(*.pdf)";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.aboutMeToolStripMenuItem.Text = "About me";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCountries);
            this.tabControl1.Controls.Add(this.tabPageCities);
            this.tabControl1.Controls.Add(this.tabPageInformations);
            this.tabControl1.Controls.Add(this.tabPageDrives);
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 249);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageCountries
            // 
            this.tabPageCountries.Controls.Add(this.buttonAddCountry);
            this.tabPageCountries.Controls.Add(this.textBoxCountry);
            this.tabPageCountries.Controls.Add(this.comboBoxCountries);
            this.tabPageCountries.Location = new System.Drawing.Point(4, 22);
            this.tabPageCountries.Name = "tabPageCountries";
            this.tabPageCountries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCountries.Size = new System.Drawing.Size(516, 223);
            this.tabPageCountries.TabIndex = 0;
            this.tabPageCountries.Text = "Countries";
            this.tabPageCountries.UseVisualStyleBackColor = true;
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCountry.Location = new System.Drawing.Point(34, 83);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(88, 48);
            this.buttonAddCountry.TabIndex = 2;
            this.buttonAddCountry.Text = "Add Country";
            this.buttonAddCountry.UseVisualStyleBackColor = true;
            this.buttonAddCountry.Click += new System.EventHandler(this.buttonAddCountry_Click);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(34, 57);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(229, 20);
            this.textBoxCountry.TabIndex = 1;
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(34, 27);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(154, 24);
            this.comboBoxCountries.TabIndex = 0;
            // 
            // tabPageCities
            // 
            this.tabPageCities.Controls.Add(this.buttonAddCities);
            this.tabPageCities.Controls.Add(this.textBoxCity);
            this.tabPageCities.Controls.Add(this.comboBoxCities);
            this.tabPageCities.Location = new System.Drawing.Point(4, 22);
            this.tabPageCities.Name = "tabPageCities";
            this.tabPageCities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCities.Size = new System.Drawing.Size(516, 223);
            this.tabPageCities.TabIndex = 1;
            this.tabPageCities.Text = "Cities";
            this.tabPageCities.UseVisualStyleBackColor = true;
            // 
            // buttonAddCities
            // 
            this.buttonAddCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCities.Location = new System.Drawing.Point(15, 71);
            this.buttonAddCities.Name = "buttonAddCities";
            this.buttonAddCities.Size = new System.Drawing.Size(88, 48);
            this.buttonAddCities.TabIndex = 5;
            this.buttonAddCities.Text = "Add City";
            this.buttonAddCities.UseVisualStyleBackColor = true;
            this.buttonAddCities.Click += new System.EventHandler(this.buttonAddCities_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(15, 45);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(229, 20);
            this.textBoxCity.TabIndex = 4;
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(15, 15);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(154, 24);
            this.comboBoxCities.TabIndex = 3;
            // 
            // tabPageInformations
            // 
            this.tabPageInformations.Controls.Add(this.buttonAddPerson);
            this.tabPageInformations.Controls.Add(this.button1);
            this.tabPageInformations.Controls.Add(this.groupBox1);
            this.tabPageInformations.Controls.Add(this.comboBoxPerson);
            this.tabPageInformations.Controls.Add(this.label1);
            this.tabPageInformations.Location = new System.Drawing.Point(4, 22);
            this.tabPageInformations.Name = "tabPageInformations";
            this.tabPageInformations.Size = new System.Drawing.Size(516, 223);
            this.tabPageInformations.TabIndex = 2;
            this.tabPageInformations.Text = "Data";
            this.tabPageInformations.UseVisualStyleBackColor = true;
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPerson.Location = new System.Drawing.Point(375, 158);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(127, 43);
            this.buttonAddPerson.TabIndex = 4;
            this.buttonAddPerson.Text = "Add Person";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.dateTimePickerBirthDay);
            this.groupBox1.Controls.Add(this.comboBoxCountry);
            this.groupBox1.Controls.Add(this.comboBoxPersonCity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(85, 53);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(186, 20);
            this.textBoxAddress.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(83, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(83, 79);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(186, 20);
            this.dateTimePickerBirthDay.TabIndex = 11;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(84, 133);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(187, 21);
            this.comboBoxCountry.TabIndex = 10;
            // 
            // comboBoxPersonCity
            // 
            this.comboBoxPersonCity.FormattingEnabled = true;
            this.comboBoxPersonCity.Location = new System.Drawing.Point(84, 106);
            this.comboBoxPersonCity.Name = "comboBoxPersonCity";
            this.comboBoxPersonCity.Size = new System.Drawing.Size(187, 21);
            this.comboBoxPersonCity.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birth Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.Location = new System.Drawing.Point(102, 11);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(187, 21);
            this.comboBoxPerson.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person ID";
            // 
            // tabPageDrives
            // 
            this.tabPageDrives.Controls.Add(this.textBoxDrives);
            this.tabPageDrives.Location = new System.Drawing.Point(4, 22);
            this.tabPageDrives.Name = "tabPageDrives";
            this.tabPageDrives.Size = new System.Drawing.Size(516, 223);
            this.tabPageDrives.TabIndex = 3;
            this.tabPageDrives.Text = "Drives";
            this.tabPageDrives.UseVisualStyleBackColor = true;
            // 
            // textBoxDrives
            // 
            this.textBoxDrives.Location = new System.Drawing.Point(13, 13);
            this.textBoxDrives.Multiline = true;
            this.textBoxDrives.Name = "textBoxDrives";
            this.textBoxDrives.Size = new System.Drawing.Size(370, 146);
            this.textBoxDrives.TabIndex = 0;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.textBoxInfo);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(516, 223);
            this.tabPageInfo.TabIndex = 4;
            this.tabPageInfo.Text = "Information";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(6, 6);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(348, 145);
            this.textBoxInfo.TabIndex = 0;
            // 
            // buttonClean
            // 
            this.buttonClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClean.Location = new System.Drawing.Point(631, 27);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(147, 58);
            this.buttonClean.TabIndex = 3;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(631, 91);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(147, 58);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(631, 155);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(147, 58);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 301);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCountries.ResumeLayout(false);
            this.tabPageCountries.PerformLayout();
            this.tabPageCities.ResumeLayout(false);
            this.tabPageCities.PerformLayout();
            this.tabPageInformations.ResumeLayout(false);
            this.tabPageInformations.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageDrives.ResumeLayout(false);
            this.tabPageDrives.PerformLayout();
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computadorDrivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getFilesToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem imagesjpgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagesgifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagespngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentsdocxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentspdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssLabelName;
        private System.Windows.Forms.ToolStripStatusLabel tssLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel tssLabelTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCountries;
        private System.Windows.Forms.TabPage tabPageCities;
        private System.Windows.Forms.TabPage tabPageInformations;
        private System.Windows.Forms.TabPage tabPageDrives;
        private System.Windows.Forms.Button buttonAddCountry;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.Button buttonAddCities;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDay;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxPersonCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDrives;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}

