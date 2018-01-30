namespace WinFormsUI
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LiveViewPicBox = new System.Windows.Forms.PictureBox();
            this.LiveViewButton = new System.Windows.Forms.Button();
            this.CameraListBox = new System.Windows.Forms.ListBox();
            this.SessionButton = new System.Windows.Forms.Button();
            this.SessionLabel = new System.Windows.Forms.Label();
            this.InitGroupBox = new System.Windows.Forms.GroupBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LiveViewGroupBox = new System.Windows.Forms.GroupBox();
            this.action_panel = new System.Windows.Forms.Panel();
            this.accept_btn = new System.Windows.Forms.Button();
            this.reject_btn = new System.Windows.Forms.Button();
            this.FocusFar3Button = new System.Windows.Forms.Button();
            this.FocusFar2Button = new System.Windows.Forms.Button();
            this.FocusFar1Button = new System.Windows.Forms.Button();
            this.FocusNear1Button = new System.Windows.Forms.Button();
            this.FocusNear2Button = new System.Windows.Forms.Button();
            this.FocusNear3Button = new System.Windows.Forms.Button();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.WBCoBox = new System.Windows.Forms.ComboBox();
            this.SavePathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SaveToGroupBox = new System.Windows.Forms.GroupBox();
            this.STBothButton = new System.Windows.Forms.RadioButton();
            this.STComputerButton = new System.Windows.Forms.RadioButton();
            this.STCameraButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RecordVideoButton = new System.Windows.Forms.Button();
            this.TakePhotoButton = new System.Windows.Forms.Button();
            this.BulbUpDo = new System.Windows.Forms.NumericUpDown();
            this.ISOCoBox = new System.Windows.Forms.ComboBox();
            this.TvCoBox = new System.Windows.Forms.ComboBox();
            this.AvCoBox = new System.Windows.Forms.ComboBox();
            this.SaveFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.serial_number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.keypress_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LiveViewPicBox)).BeginInit();
            this.InitGroupBox.SuspendLayout();
            this.LiveViewGroupBox.SuspendLayout();
            this.action_panel.SuspendLayout();
            this.SettingsGroupBox.SuspendLayout();
            this.SaveToGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulbUpDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LiveViewPicBox
            // 
            this.LiveViewPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveViewPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LiveViewPicBox.Location = new System.Drawing.Point(10, 51);
            this.LiveViewPicBox.Name = "LiveViewPicBox";
            this.LiveViewPicBox.Size = new System.Drawing.Size(1036, 424);
            this.LiveViewPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LiveViewPicBox.TabIndex = 1;
            this.LiveViewPicBox.TabStop = false;
            this.LiveViewPicBox.SizeChanged += new System.EventHandler(this.LiveViewPicBox_SizeChanged);
            this.LiveViewPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LiveViewPicBox_MouseDown);
            // 
            // LiveViewButton
            // 
            this.LiveViewButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LiveViewButton.ForeColor = System.Drawing.Color.Black;
            this.LiveViewButton.Location = new System.Drawing.Point(8, 20);
            this.LiveViewButton.Name = "LiveViewButton";
            this.LiveViewButton.Size = new System.Drawing.Size(70, 22);
            this.LiveViewButton.TabIndex = 2;
            this.LiveViewButton.Text = "Start LV";
            this.LiveViewButton.UseVisualStyleBackColor = false;
            this.LiveViewButton.Click += new System.EventHandler(this.LiveViewButton_Click);
            // 
            // CameraListBox
            // 
            this.CameraListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CameraListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CameraListBox.FormattingEnabled = true;
            this.CameraListBox.Location = new System.Drawing.Point(8, 35);
            this.CameraListBox.Name = "CameraListBox";
            this.CameraListBox.Size = new System.Drawing.Size(121, 82);
            this.CameraListBox.TabIndex = 6;
            // 
            // SessionButton
            // 
            this.SessionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SessionButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SessionButton.ForeColor = System.Drawing.Color.Black;
            this.SessionButton.Location = new System.Drawing.Point(6, 127);
            this.SessionButton.Name = "SessionButton";
            this.SessionButton.Size = new System.Drawing.Size(84, 23);
            this.SessionButton.TabIndex = 7;
            this.SessionButton.Text = "Open Session";
            this.SessionButton.UseVisualStyleBackColor = false;
            this.SessionButton.Click += new System.EventHandler(this.SessionButton_Click);
            // 
            // SessionLabel
            // 
            this.SessionLabel.AutoSize = true;
            this.SessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionLabel.Location = new System.Drawing.Point(6, 16);
            this.SessionLabel.Name = "SessionLabel";
            this.SessionLabel.Size = new System.Drawing.Size(110, 16);
            this.SessionLabel.TabIndex = 8;
            this.SessionLabel.Text = "No open session";
            // 
            // InitGroupBox
            // 
            this.InitGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.InitGroupBox.Controls.Add(this.RefreshButton);
            this.InitGroupBox.Controls.Add(this.CameraListBox);
            this.InitGroupBox.Controls.Add(this.SessionLabel);
            this.InitGroupBox.Controls.Add(this.SessionButton);
            this.InitGroupBox.ForeColor = System.Drawing.Color.White;
            this.InitGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InitGroupBox.Name = "InitGroupBox";
            this.InitGroupBox.Size = new System.Drawing.Size(135, 158);
            this.InitGroupBox.TabIndex = 9;
            this.InitGroupBox.TabStop = false;
            this.InitGroupBox.Text = "Connected Cameras";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefreshButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.Black;
            this.RefreshButton.Location = new System.Drawing.Point(96, 127);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(31, 23);
            this.RefreshButton.TabIndex = 9;
            this.RefreshButton.Text = "↻";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LiveViewGroupBox
            // 
            this.LiveViewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveViewGroupBox.Controls.Add(this.action_panel);
            this.LiveViewGroupBox.Controls.Add(this.FocusFar3Button);
            this.LiveViewGroupBox.Controls.Add(this.FocusFar2Button);
            this.LiveViewGroupBox.Controls.Add(this.FocusFar1Button);
            this.LiveViewGroupBox.Controls.Add(this.FocusNear1Button);
            this.LiveViewGroupBox.Controls.Add(this.FocusNear2Button);
            this.LiveViewGroupBox.Controls.Add(this.FocusNear3Button);
            this.LiveViewGroupBox.Controls.Add(this.LiveViewPicBox);
            this.LiveViewGroupBox.Controls.Add(this.LiveViewButton);
            this.LiveViewGroupBox.Enabled = false;
            this.LiveViewGroupBox.ForeColor = System.Drawing.Color.White;
            this.LiveViewGroupBox.Location = new System.Drawing.Point(12, 176);
            this.LiveViewGroupBox.Name = "LiveViewGroupBox";
            this.LiveViewGroupBox.Size = new System.Drawing.Size(1060, 490);
            this.LiveViewGroupBox.TabIndex = 10;
            this.LiveViewGroupBox.TabStop = false;
            this.LiveViewGroupBox.Text = "LiveView";
            // 
            // action_panel
            // 
            this.action_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.action_panel.Controls.Add(this.accept_btn);
            this.action_panel.Controls.Add(this.reject_btn);
            this.action_panel.Location = new System.Drawing.Point(789, 13);
            this.action_panel.Margin = new System.Windows.Forms.Padding(2);
            this.action_panel.Name = "action_panel";
            this.action_panel.Size = new System.Drawing.Size(163, 33);
            this.action_panel.TabIndex = 9;
            // 
            // accept_btn
            // 
            this.accept_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.accept_btn.Enabled = false;
            this.accept_btn.ForeColor = System.Drawing.Color.Black;
            this.accept_btn.Location = new System.Drawing.Point(3, 4);
            this.accept_btn.Name = "accept_btn";
            this.accept_btn.Size = new System.Drawing.Size(75, 23);
            this.accept_btn.TabIndex = 7;
            this.accept_btn.Text = "Accept";
            this.accept_btn.UseVisualStyleBackColor = false;
            this.accept_btn.Click += new System.EventHandler(this.accept_btn_Click);
            // 
            // reject_btn
            // 
            this.reject_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reject_btn.Enabled = false;
            this.reject_btn.ForeColor = System.Drawing.Color.Black;
            this.reject_btn.Location = new System.Drawing.Point(84, 4);
            this.reject_btn.Name = "reject_btn";
            this.reject_btn.Size = new System.Drawing.Size(75, 23);
            this.reject_btn.TabIndex = 8;
            this.reject_btn.Text = "Reject";
            this.reject_btn.UseVisualStyleBackColor = false;
            this.reject_btn.Click += new System.EventHandler(this.reject_btn_Click);
            // 
            // FocusFar3Button
            // 
            this.FocusFar3Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FocusFar3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusFar3Button.ForeColor = System.Drawing.Color.Black;
            this.FocusFar3Button.Location = new System.Drawing.Point(345, 20);
            this.FocusFar3Button.Name = "FocusFar3Button";
            this.FocusFar3Button.Size = new System.Drawing.Size(28, 23);
            this.FocusFar3Button.TabIndex = 6;
            this.FocusFar3Button.Text = ">>>";
            this.FocusFar3Button.UseVisualStyleBackColor = false;
            this.FocusFar3Button.Click += new System.EventHandler(this.FocusFar3Button_Click);
            // 
            // FocusFar2Button
            // 
            this.FocusFar2Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FocusFar2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusFar2Button.ForeColor = System.Drawing.Color.Black;
            this.FocusFar2Button.Location = new System.Drawing.Point(311, 20);
            this.FocusFar2Button.Name = "FocusFar2Button";
            this.FocusFar2Button.Size = new System.Drawing.Size(28, 23);
            this.FocusFar2Button.TabIndex = 6;
            this.FocusFar2Button.Text = ">>";
            this.FocusFar2Button.UseVisualStyleBackColor = false;
            this.FocusFar2Button.Click += new System.EventHandler(this.FocusFar2Button_Click);
            // 
            // FocusFar1Button
            // 
            this.FocusFar1Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FocusFar1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusFar1Button.ForeColor = System.Drawing.Color.Black;
            this.FocusFar1Button.Location = new System.Drawing.Point(277, 20);
            this.FocusFar1Button.Name = "FocusFar1Button";
            this.FocusFar1Button.Size = new System.Drawing.Size(28, 23);
            this.FocusFar1Button.TabIndex = 6;
            this.FocusFar1Button.Text = ">";
            this.FocusFar1Button.UseVisualStyleBackColor = false;
            this.FocusFar1Button.Click += new System.EventHandler(this.FocusFar1Button_Click);
            // 
            // FocusNear1Button
            // 
            this.FocusNear1Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FocusNear1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusNear1Button.ForeColor = System.Drawing.Color.Black;
            this.FocusNear1Button.Location = new System.Drawing.Point(243, 20);
            this.FocusNear1Button.Name = "FocusNear1Button";
            this.FocusNear1Button.Size = new System.Drawing.Size(28, 23);
            this.FocusNear1Button.TabIndex = 6;
            this.FocusNear1Button.Text = "<";
            this.FocusNear1Button.UseVisualStyleBackColor = false;
            this.FocusNear1Button.Click += new System.EventHandler(this.FocusNear1Button_Click);
            // 
            // FocusNear2Button
            // 
            this.FocusNear2Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FocusNear2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusNear2Button.ForeColor = System.Drawing.Color.Black;
            this.FocusNear2Button.Location = new System.Drawing.Point(209, 20);
            this.FocusNear2Button.Name = "FocusNear2Button";
            this.FocusNear2Button.Size = new System.Drawing.Size(28, 23);
            this.FocusNear2Button.TabIndex = 6;
            this.FocusNear2Button.Text = "<<";
            this.FocusNear2Button.UseVisualStyleBackColor = false;
            this.FocusNear2Button.Click += new System.EventHandler(this.FocusNear2Button_Click);
            // 
            // FocusNear3Button
            // 
            this.FocusNear3Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FocusNear3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FocusNear3Button.ForeColor = System.Drawing.Color.Black;
            this.FocusNear3Button.Location = new System.Drawing.Point(175, 20);
            this.FocusNear3Button.Name = "FocusNear3Button";
            this.FocusNear3Button.Size = new System.Drawing.Size(28, 23);
            this.FocusNear3Button.TabIndex = 6;
            this.FocusNear3Button.Text = "<<<";
            this.FocusNear3Button.UseVisualStyleBackColor = false;
            this.FocusNear3Button.Click += new System.EventHandler(this.FocusNear3Button_Click);
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.MainProgressBar);
            this.SettingsGroupBox.Controls.Add(this.WBCoBox);
            this.SettingsGroupBox.Controls.Add(this.SavePathTextBox);
            this.SettingsGroupBox.Controls.Add(this.BrowseButton);
            this.SettingsGroupBox.Controls.Add(this.SaveToGroupBox);
            this.SettingsGroupBox.Controls.Add(this.label4);
            this.SettingsGroupBox.Controls.Add(this.label3);
            this.SettingsGroupBox.Controls.Add(this.label2);
            this.SettingsGroupBox.Controls.Add(this.label5);
            this.SettingsGroupBox.Controls.Add(this.label1);
            this.SettingsGroupBox.Controls.Add(this.RecordVideoButton);
            this.SettingsGroupBox.Controls.Add(this.TakePhotoButton);
            this.SettingsGroupBox.Controls.Add(this.BulbUpDo);
            this.SettingsGroupBox.Controls.Add(this.ISOCoBox);
            this.SettingsGroupBox.Controls.Add(this.TvCoBox);
            this.SettingsGroupBox.Controls.Add(this.AvCoBox);
            this.SettingsGroupBox.Enabled = false;
            this.SettingsGroupBox.ForeColor = System.Drawing.Color.White;
            this.SettingsGroupBox.Location = new System.Drawing.Point(153, 12);
            this.SettingsGroupBox.MinimumSize = new System.Drawing.Size(407, 158);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(407, 158);
            this.SettingsGroupBox.TabIndex = 11;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainProgressBar.Location = new System.Drawing.Point(6, 100);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(130, 20);
            this.MainProgressBar.TabIndex = 8;
            this.MainProgressBar.Click += new System.EventHandler(this.MainProgressBar_Click);
            // 
            // WBCoBox
            // 
            this.WBCoBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WBCoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WBCoBox.FormattingEnabled = true;
            this.WBCoBox.Items.AddRange(new object[] {
            "Auto",
            "Daylight",
            "Cloudy",
            "Tungsten",
            "Fluorescent",
            "Strobe",
            "White Paper",
            "Shade"});
            this.WBCoBox.Location = new System.Drawing.Point(142, 19);
            this.WBCoBox.Name = "WBCoBox";
            this.WBCoBox.Size = new System.Drawing.Size(110, 21);
            this.WBCoBox.TabIndex = 7;
            this.WBCoBox.SelectedIndexChanged += new System.EventHandler(this.WBCoBox_SelectedIndexChanged);
            // 
            // SavePathTextBox
            // 
            this.SavePathTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SavePathTextBox.Enabled = false;
            this.SavePathTextBox.Location = new System.Drawing.Point(6, 126);
            this.SavePathTextBox.Name = "SavePathTextBox";
            this.SavePathTextBox.Size = new System.Drawing.Size(282, 20);
            this.SavePathTextBox.TabIndex = 6;
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BrowseButton.Enabled = false;
            this.BrowseButton.ForeColor = System.Drawing.Color.Black;
            this.BrowseButton.Location = new System.Drawing.Point(294, 123);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(99, 23);
            this.BrowseButton.TabIndex = 5;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SaveToGroupBox
            // 
            this.SaveToGroupBox.Controls.Add(this.STBothButton);
            this.SaveToGroupBox.Controls.Add(this.STComputerButton);
            this.SaveToGroupBox.Controls.Add(this.STCameraButton);
            this.SaveToGroupBox.ForeColor = System.Drawing.Color.White;
            this.SaveToGroupBox.Location = new System.Drawing.Point(297, 20);
            this.SaveToGroupBox.Name = "SaveToGroupBox";
            this.SaveToGroupBox.Size = new System.Drawing.Size(96, 100);
            this.SaveToGroupBox.TabIndex = 4;
            this.SaveToGroupBox.TabStop = false;
            this.SaveToGroupBox.Text = "Save To";
            // 
            // STBothButton
            // 
            this.STBothButton.AutoSize = true;
            this.STBothButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STBothButton.Location = new System.Drawing.Point(6, 71);
            this.STBothButton.Name = "STBothButton";
            this.STBothButton.Size = new System.Drawing.Size(53, 20);
            this.STBothButton.TabIndex = 0;
            this.STBothButton.Text = "Both";
            this.STBothButton.UseVisualStyleBackColor = true;
            this.STBothButton.CheckedChanged += new System.EventHandler(this.SaveToButton_CheckedChanged);
            // 
            // STComputerButton
            // 
            this.STComputerButton.AutoSize = true;
            this.STComputerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STComputerButton.Location = new System.Drawing.Point(6, 45);
            this.STComputerButton.Name = "STComputerButton";
            this.STComputerButton.Size = new System.Drawing.Size(84, 20);
            this.STComputerButton.TabIndex = 0;
            this.STComputerButton.Text = "Computer";
            this.STComputerButton.UseVisualStyleBackColor = true;
            this.STComputerButton.CheckedChanged += new System.EventHandler(this.SaveToButton_CheckedChanged);
            // 
            // STCameraButton
            // 
            this.STCameraButton.AutoSize = true;
            this.STCameraButton.Checked = true;
            this.STCameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STCameraButton.Location = new System.Drawing.Point(6, 19);
            this.STCameraButton.Name = "STCameraButton";
            this.STCameraButton.Size = new System.Drawing.Size(74, 20);
            this.STCameraButton.TabIndex = 0;
            this.STCameraButton.TabStop = true;
            this.STCameraButton.Text = "Camera";
            this.STCameraButton.UseVisualStyleBackColor = true;
            this.STCameraButton.CheckedChanged += new System.EventHandler(this.SaveToButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bulb (s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "WB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Av";
            // 
            // RecordVideoButton
            // 
            this.RecordVideoButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RecordVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordVideoButton.ForeColor = System.Drawing.Color.Black;
            this.RecordVideoButton.Location = new System.Drawing.Point(217, 72);
            this.RecordVideoButton.Name = "RecordVideoButton";
            this.RecordVideoButton.Size = new System.Drawing.Size(71, 48);
            this.RecordVideoButton.TabIndex = 2;
            this.RecordVideoButton.Text = "Record Video";
            this.RecordVideoButton.UseVisualStyleBackColor = false;
            this.RecordVideoButton.Click += new System.EventHandler(this.RecordVideoButton_Click);
            // 
            // TakePhotoButton
            // 
            this.TakePhotoButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TakePhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakePhotoButton.ForeColor = System.Drawing.Color.Black;
            this.TakePhotoButton.Location = new System.Drawing.Point(142, 72);
            this.TakePhotoButton.Name = "TakePhotoButton";
            this.TakePhotoButton.Size = new System.Drawing.Size(71, 48);
            this.TakePhotoButton.TabIndex = 2;
            this.TakePhotoButton.Text = "Take Photo";
            this.TakePhotoButton.UseVisualStyleBackColor = false;
            this.TakePhotoButton.Click += new System.EventHandler(this.TakePhotoButton_Click);
            // 
            // BulbUpDo
            // 
            this.BulbUpDo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BulbUpDo.Location = new System.Drawing.Point(142, 46);
            this.BulbUpDo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BulbUpDo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BulbUpDo.Name = "BulbUpDo";
            this.BulbUpDo.Size = new System.Drawing.Size(94, 20);
            this.BulbUpDo.TabIndex = 1;
            this.BulbUpDo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BulbUpDo.ValueChanged += new System.EventHandler(this.BulbUpDo_ValueChanged);
            // 
            // ISOCoBox
            // 
            this.ISOCoBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ISOCoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ISOCoBox.FormattingEnabled = true;
            this.ISOCoBox.Location = new System.Drawing.Point(6, 73);
            this.ISOCoBox.Name = "ISOCoBox";
            this.ISOCoBox.Size = new System.Drawing.Size(94, 21);
            this.ISOCoBox.TabIndex = 0;
            this.ISOCoBox.SelectedIndexChanged += new System.EventHandler(this.ISOCoBox_SelectedIndexChanged);
            // 
            // TvCoBox
            // 
            this.TvCoBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TvCoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TvCoBox.FormattingEnabled = true;
            this.TvCoBox.Location = new System.Drawing.Point(6, 46);
            this.TvCoBox.Name = "TvCoBox";
            this.TvCoBox.Size = new System.Drawing.Size(94, 21);
            this.TvCoBox.TabIndex = 0;
            this.TvCoBox.SelectedIndexChanged += new System.EventHandler(this.TvCoBox_SelectedIndexChanged);
            // 
            // AvCoBox
            // 
            this.AvCoBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AvCoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvCoBox.FormattingEnabled = true;
            this.AvCoBox.Location = new System.Drawing.Point(6, 19);
            this.AvCoBox.Name = "AvCoBox";
            this.AvCoBox.Size = new System.Drawing.Size(94, 21);
            this.AvCoBox.TabIndex = 0;
            this.AvCoBox.SelectedIndexChanged += new System.EventHandler(this.AvCoBox_SelectedIndexChanged);
            // 
            // SaveFolderBrowser
            // 
            this.SaveFolderBrowser.Description = "Save Images To...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(711, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 109);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(579, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Serial Number:";
            // 
            // serial_number
            // 
            this.serial_number.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.serial_number.Location = new System.Drawing.Point(661, 148);
            this.serial_number.MaxLength = 12;
            this.serial_number.Name = "serial_number";
            this.serial_number.Size = new System.Drawing.Size(386, 20);
            this.serial_number.TabIndex = 14;
            this.serial_number.TextChanged += new System.EventHandler(this.serial_number_TextChanged);
            this.serial_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serial_number_KeyPress);
            this.serial_number.LostFocus += new System.EventHandler(this.serial_lost_focus);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(471, 680);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Powered by Orchid Studios";
            // 
            // keypress_timer
            // 
            this.keypress_timer.Interval = 3000;
            this.keypress_timer.Tick += new System.EventHandler(this.keypress_timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.serial_number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.LiveViewGroupBox);
            this.Controls.Add(this.InitGroupBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(588, 638);
            this.Name = "MainForm";
            this.Text = "Jason Bohrer Photo Booth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.LiveViewPicBox)).EndInit();
            this.InitGroupBox.ResumeLayout(false);
            this.InitGroupBox.PerformLayout();
            this.LiveViewGroupBox.ResumeLayout(false);
            this.action_panel.ResumeLayout(false);
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.SaveToGroupBox.ResumeLayout(false);
            this.SaveToGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulbUpDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LiveViewPicBox;
        private System.Windows.Forms.Button LiveViewButton;
        private System.Windows.Forms.ListBox CameraListBox;
        private System.Windows.Forms.Button SessionButton;
        private System.Windows.Forms.Label SessionLabel;
        private System.Windows.Forms.GroupBox InitGroupBox;
        private System.Windows.Forms.GroupBox LiveViewGroupBox;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Button TakePhotoButton;
        private System.Windows.Forms.NumericUpDown BulbUpDo;
        private System.Windows.Forms.ComboBox ISOCoBox;
        private System.Windows.Forms.ComboBox TvCoBox;
        private System.Windows.Forms.ComboBox AvCoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SaveToGroupBox;
        private System.Windows.Forms.RadioButton STBothButton;
        private System.Windows.Forms.RadioButton STComputerButton;
        private System.Windows.Forms.RadioButton STCameraButton;
        private System.Windows.Forms.TextBox SavePathTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.FolderBrowserDialog SaveFolderBrowser;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox WBCoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RecordVideoButton;
        private System.Windows.Forms.Button FocusFar3Button;
        private System.Windows.Forms.Button FocusFar2Button;
        private System.Windows.Forms.Button FocusFar1Button;
        private System.Windows.Forms.Button FocusNear1Button;
        private System.Windows.Forms.Button FocusNear2Button;
        private System.Windows.Forms.Button FocusNear3Button;
        private System.Windows.Forms.ProgressBar MainProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serial_number;
        private System.Windows.Forms.Button reject_btn;
        private System.Windows.Forms.Button accept_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer keypress_timer;
        private System.Windows.Forms.Panel action_panel;
    }
}

