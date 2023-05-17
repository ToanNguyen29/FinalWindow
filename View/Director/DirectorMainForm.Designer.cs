namespace FinalWindow
{
    partial class DirectorMainForm
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
            this.label_birthDate = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_directorImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.button_editInformation = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage_profile = new System.Windows.Forms.TabPage();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tabControl_director = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage_managerManagement = new System.Windows.Forms.TabPage();
            this.button_removeManager = new Guna.UI2.WinForms.Guna2Button();
            this.button_updateManager = new Guna.UI2.WinForms.Guna2Button();
            this.button_resetData = new Guna.UI2.WinForms.Guna2Button();
            this.button_addManager = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_listManager = new System.Windows.Forms.DataGridView();
            this.tabPage_facilityManagement = new System.Windows.Forms.TabPage();
            this.button_removeFacility = new Guna.UI2.WinForms.Guna2Button();
            this.button_updateFacility = new Guna.UI2.WinForms.Guna2Button();
            this.button_resetFacility = new Guna.UI2.WinForms.Guna2Button();
            this.button_addFacility = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_listFacility = new System.Windows.Forms.DataGridView();
            this.tabPage_shift = new System.Windows.Forms.TabPage();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.button_resetListShift = new Guna.UI2.WinForms.Guna2Button();
            this.button_addShift = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_listShift = new System.Windows.Forms.DataGridView();
            this.button_reset = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_directorImage)).BeginInit();
            this.tabPage_profile.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.tabControl_director.SuspendLayout();
            this.tabPage_managerManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listManager)).BeginInit();
            this.tabPage_facilityManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listFacility)).BeginInit();
            this.tabPage_shift.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listShift)).BeginInit();
            this.SuspendLayout();
            // 
            // label_birthDate
            // 
            this.label_birthDate.AutoSize = true;
            this.label_birthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_birthDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_birthDate.Location = new System.Drawing.Point(345, 170);
            this.label_birthDate.Name = "label_birthDate";
            this.label_birthDate.Size = new System.Drawing.Size(86, 23);
            this.label_birthDate.TabIndex = 32;
            this.label_birthDate.Text = "Birthdate";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_address.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_address.Location = new System.Drawing.Point(345, 325);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(74, 23);
            this.label_address.TabIndex = 31;
            this.label_address.Text = "Address";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_email.Location = new System.Drawing.Point(345, 271);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(54, 23);
            this.label_email.TabIndex = 30;
            this.label_email.Text = "Email";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_phone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_phone.Location = new System.Drawing.Point(345, 220);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(59, 23);
            this.label_phone.TabIndex = 29;
            this.label_phone.Text = "Phone";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_gender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_gender.Location = new System.Drawing.Point(345, 118);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(68, 23);
            this.label_gender.TabIndex = 28;
            this.label_gender.Text = "Gender";
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_lastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_lastName.Location = new System.Drawing.Point(345, 68);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(94, 23);
            this.label_lastName.TabIndex = 27;
            this.label_lastName.Text = "Last Name";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_firstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_firstName.Location = new System.Drawing.Point(345, 19);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(97, 23);
            this.label_firstName.TabIndex = 26;
            this.label_firstName.Text = "First Name";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label_username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_username.Location = new System.Drawing.Point(32, 40);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(89, 23);
            this.label_username.TabIndex = 25;
            this.label_username.Text = "Username";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(159, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 377);
            this.label8.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(192, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 23;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(192, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Birthdate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(192, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(192, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(192, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(192, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(192, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name:";
            // 
            // pictureBox_directorImage
            // 
            this.pictureBox_directorImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pictureBox_directorImage.ImageRotate = 0F;
            this.pictureBox_directorImage.Location = new System.Drawing.Point(26, 85);
            this.pictureBox_directorImage.Name = "pictureBox_directorImage";
            this.pictureBox_directorImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox_directorImage.Size = new System.Drawing.Size(108, 99);
            this.pictureBox_directorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_directorImage.TabIndex = 0;
            this.pictureBox_directorImage.TabStop = false;
            // 
            // button_editInformation
            // 
            this.button_editInformation.BorderRadius = 20;
            this.button_editInformation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_editInformation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_editInformation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_editInformation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_editInformation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editInformation.ForeColor = System.Drawing.Color.White;
            this.button_editInformation.Location = new System.Drawing.Point(6, 409);
            this.button_editInformation.Name = "button_editInformation";
            this.button_editInformation.Size = new System.Drawing.Size(710, 84);
            this.button_editInformation.TabIndex = 1;
            this.button_editInformation.Text = "Edit your information";
            this.button_editInformation.Click += new System.EventHandler(this.button_editInformation_Click);
            // 
            // tabPage_profile
            // 
            this.tabPage_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.tabPage_profile.Controls.Add(this.button_reset);
            this.tabPage_profile.Controls.Add(this.button_editInformation);
            this.tabPage_profile.Controls.Add(this.guna2GroupBox1);
            this.tabPage_profile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_profile.Location = new System.Drawing.Point(184, 4);
            this.tabPage_profile.Name = "tabPage_profile";
            this.tabPage_profile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_profile.Size = new System.Drawing.Size(845, 603);
            this.tabPage_profile.TabIndex = 0;
            this.tabPage_profile.Text = "Profile";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.label_birthDate);
            this.guna2GroupBox1.Controls.Add(this.label_address);
            this.guna2GroupBox1.Controls.Add(this.label_email);
            this.guna2GroupBox1.Controls.Add(this.label_phone);
            this.guna2GroupBox1.Controls.Add(this.label_gender);
            this.guna2GroupBox1.Controls.Add(this.label_lastName);
            this.guna2GroupBox1.Controls.Add(this.label_firstName);
            this.guna2GroupBox1.Controls.Add(this.label_username);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.pictureBox_directorImage);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox1.Location = new System.Drawing.Point(6, 6);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(710, 382);
            this.guna2GroupBox1.TabIndex = 0;
            // 
            // tabControl_director
            // 
            this.tabControl_director.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl_director.Controls.Add(this.tabPage_profile);
            this.tabControl_director.Controls.Add(this.tabPage_managerManagement);
            this.tabControl_director.Controls.Add(this.tabPage_facilityManagement);
            this.tabControl_director.Controls.Add(this.tabPage_shift);
            this.tabControl_director.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_director.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl_director.Location = new System.Drawing.Point(12, 12);
            this.tabControl_director.Name = "tabControl_director";
            this.tabControl_director.SelectedIndex = 0;
            this.tabControl_director.Size = new System.Drawing.Size(1033, 611);
            this.tabControl_director.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_director.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl_director.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_director.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl_director.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl_director.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_director.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl_director.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_director.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl_director.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl_director.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl_director.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl_director.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl_director.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl_director.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl_director.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl_director.TabIndex = 3;
            this.tabControl_director.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tabPage_managerManagement
            // 
            this.tabPage_managerManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.tabPage_managerManagement.Controls.Add(this.button_removeManager);
            this.tabPage_managerManagement.Controls.Add(this.button_updateManager);
            this.tabPage_managerManagement.Controls.Add(this.button_resetData);
            this.tabPage_managerManagement.Controls.Add(this.button_addManager);
            this.tabPage_managerManagement.Controls.Add(this.dataGridView_listManager);
            this.tabPage_managerManagement.Location = new System.Drawing.Point(184, 4);
            this.tabPage_managerManagement.Name = "tabPage_managerManagement";
            this.tabPage_managerManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_managerManagement.Size = new System.Drawing.Size(845, 603);
            this.tabPage_managerManagement.TabIndex = 1;
            this.tabPage_managerManagement.Text = "Managers";
            // 
            // button_removeManager
            // 
            this.button_removeManager.BorderRadius = 20;
            this.button_removeManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_removeManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_removeManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_removeManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_removeManager.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeManager.ForeColor = System.Drawing.Color.White;
            this.button_removeManager.Location = new System.Drawing.Point(283, 503);
            this.button_removeManager.Name = "button_removeManager";
            this.button_removeManager.Size = new System.Drawing.Size(222, 47);
            this.button_removeManager.TabIndex = 3;
            this.button_removeManager.Text = "Remove Manager";
            // 
            // button_updateManager
            // 
            this.button_updateManager.BorderRadius = 20;
            this.button_updateManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_updateManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_updateManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_updateManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_updateManager.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateManager.ForeColor = System.Drawing.Color.White;
            this.button_updateManager.Location = new System.Drawing.Point(545, 503);
            this.button_updateManager.Name = "button_updateManager";
            this.button_updateManager.Size = new System.Drawing.Size(222, 47);
            this.button_updateManager.TabIndex = 4;
            this.button_updateManager.Text = "Update Manager";
            this.button_updateManager.Click += new System.EventHandler(this.button_editManager_Click);
            // 
            // button_resetData
            // 
            this.button_resetData.BorderRadius = 10;
            this.button_resetData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_resetData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_resetData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_resetData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_resetData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetData.ForeColor = System.Drawing.Color.White;
            this.button_resetData.Location = new System.Drawing.Point(18, 437);
            this.button_resetData.Name = "button_resetData";
            this.button_resetData.Size = new System.Drawing.Size(92, 32);
            this.button_resetData.TabIndex = 3;
            this.button_resetData.Text = "Reset";
            this.button_resetData.Click += new System.EventHandler(this.button_resetData_Click);
            // 
            // button_addManager
            // 
            this.button_addManager.BorderRadius = 20;
            this.button_addManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_addManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_addManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_addManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_addManager.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addManager.ForeColor = System.Drawing.Color.White;
            this.button_addManager.Location = new System.Drawing.Point(18, 503);
            this.button_addManager.Name = "button_addManager";
            this.button_addManager.Size = new System.Drawing.Size(222, 47);
            this.button_addManager.TabIndex = 2;
            this.button_addManager.Text = "Add Manager";
            this.button_addManager.Click += new System.EventHandler(this.button_addManager_Click);
            // 
            // dataGridView_listManager
            // 
            this.dataGridView_listManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listManager.Location = new System.Drawing.Point(18, 23);
            this.dataGridView_listManager.Name = "dataGridView_listManager";
            this.dataGridView_listManager.RowHeadersWidth = 51;
            this.dataGridView_listManager.RowTemplate.Height = 24;
            this.dataGridView_listManager.Size = new System.Drawing.Size(749, 408);
            this.dataGridView_listManager.TabIndex = 0;
            // 
            // tabPage_facilityManagement
            // 
            this.tabPage_facilityManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.tabPage_facilityManagement.Controls.Add(this.button_removeFacility);
            this.tabPage_facilityManagement.Controls.Add(this.button_updateFacility);
            this.tabPage_facilityManagement.Controls.Add(this.button_resetFacility);
            this.tabPage_facilityManagement.Controls.Add(this.button_addFacility);
            this.tabPage_facilityManagement.Controls.Add(this.dataGridView_listFacility);
            this.tabPage_facilityManagement.Location = new System.Drawing.Point(184, 4);
            this.tabPage_facilityManagement.Name = "tabPage_facilityManagement";
            this.tabPage_facilityManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_facilityManagement.Size = new System.Drawing.Size(845, 603);
            this.tabPage_facilityManagement.TabIndex = 2;
            this.tabPage_facilityManagement.Text = "Facilities";
            // 
            // button_removeFacility
            // 
            this.button_removeFacility.BorderRadius = 20;
            this.button_removeFacility.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_removeFacility.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_removeFacility.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_removeFacility.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_removeFacility.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_removeFacility.ForeColor = System.Drawing.Color.White;
            this.button_removeFacility.Location = new System.Drawing.Point(550, 509);
            this.button_removeFacility.Name = "button_removeFacility";
            this.button_removeFacility.Size = new System.Drawing.Size(222, 47);
            this.button_removeFacility.TabIndex = 7;
            this.button_removeFacility.Text = "Remove Facility";
            // 
            // button_updateFacility
            // 
            this.button_updateFacility.BorderRadius = 20;
            this.button_updateFacility.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_updateFacility.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_updateFacility.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_updateFacility.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_updateFacility.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateFacility.ForeColor = System.Drawing.Color.White;
            this.button_updateFacility.Location = new System.Drawing.Point(286, 509);
            this.button_updateFacility.Name = "button_updateFacility";
            this.button_updateFacility.Size = new System.Drawing.Size(222, 47);
            this.button_updateFacility.TabIndex = 6;
            this.button_updateFacility.Text = "Update Facility";
            this.button_updateFacility.Click += new System.EventHandler(this.button_updateFacility_Click);
            // 
            // button_resetFacility
            // 
            this.button_resetFacility.BorderRadius = 20;
            this.button_resetFacility.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_resetFacility.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_resetFacility.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_resetFacility.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_resetFacility.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetFacility.ForeColor = System.Drawing.Color.White;
            this.button_resetFacility.Location = new System.Drawing.Point(23, 447);
            this.button_resetFacility.Name = "button_resetFacility";
            this.button_resetFacility.Size = new System.Drawing.Size(92, 47);
            this.button_resetFacility.TabIndex = 5;
            this.button_resetFacility.Text = "Reset";
            this.button_resetFacility.Click += new System.EventHandler(this.button_resetFacility_Click);
            // 
            // button_addFacility
            // 
            this.button_addFacility.BorderRadius = 20;
            this.button_addFacility.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_addFacility.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_addFacility.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_addFacility.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_addFacility.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addFacility.ForeColor = System.Drawing.Color.White;
            this.button_addFacility.Location = new System.Drawing.Point(23, 509);
            this.button_addFacility.Name = "button_addFacility";
            this.button_addFacility.Size = new System.Drawing.Size(222, 47);
            this.button_addFacility.TabIndex = 4;
            this.button_addFacility.Text = "Add Facility";
            this.button_addFacility.Click += new System.EventHandler(this.button_addFacility_Click);
            // 
            // dataGridView_listFacility
            // 
            this.dataGridView_listFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listFacility.Location = new System.Drawing.Point(23, 22);
            this.dataGridView_listFacility.Name = "dataGridView_listFacility";
            this.dataGridView_listFacility.RowHeadersWidth = 51;
            this.dataGridView_listFacility.RowTemplate.Height = 24;
            this.dataGridView_listFacility.Size = new System.Drawing.Size(749, 408);
            this.dataGridView_listFacility.TabIndex = 1;
            this.dataGridView_listFacility.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_listFacility_CellContentClick);
            // 
            // tabPage_shift
            // 
            this.tabPage_shift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.tabPage_shift.Controls.Add(this.guna2Button1);
            this.tabPage_shift.Controls.Add(this.button_resetListShift);
            this.tabPage_shift.Controls.Add(this.button_addShift);
            this.tabPage_shift.Controls.Add(this.dataGridView_listShift);
            this.tabPage_shift.Location = new System.Drawing.Point(184, 4);
            this.tabPage_shift.Name = "tabPage_shift";
            this.tabPage_shift.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_shift.Size = new System.Drawing.Size(845, 603);
            this.tabPage_shift.TabIndex = 3;
            this.tabPage_shift.Text = "Shift";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(335, 380);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(222, 47);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Remove Shift";
            // 
            // button_resetListShift
            // 
            this.button_resetListShift.BorderRadius = 10;
            this.button_resetListShift.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_resetListShift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_resetListShift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_resetListShift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_resetListShift.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetListShift.ForeColor = System.Drawing.Color.White;
            this.button_resetListShift.Location = new System.Drawing.Point(63, 303);
            this.button_resetListShift.Name = "button_resetListShift";
            this.button_resetListShift.Size = new System.Drawing.Size(92, 32);
            this.button_resetListShift.TabIndex = 12;
            this.button_resetListShift.Text = "Reset";
            this.button_resetListShift.Click += new System.EventHandler(this.button_resetListShift_Click);
            // 
            // button_addShift
            // 
            this.button_addShift.BorderRadius = 20;
            this.button_addShift.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_addShift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_addShift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_addShift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_addShift.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addShift.ForeColor = System.Drawing.Color.White;
            this.button_addShift.Location = new System.Drawing.Point(63, 380);
            this.button_addShift.Name = "button_addShift";
            this.button_addShift.Size = new System.Drawing.Size(222, 47);
            this.button_addShift.TabIndex = 10;
            this.button_addShift.Text = "Add Shift";
            this.button_addShift.Click += new System.EventHandler(this.button_addShift_Click);
            // 
            // dataGridView_listShift
            // 
            this.dataGridView_listShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listShift.Location = new System.Drawing.Point(63, 52);
            this.dataGridView_listShift.Name = "dataGridView_listShift";
            this.dataGridView_listShift.RowHeadersWidth = 51;
            this.dataGridView_listShift.RowTemplate.Height = 24;
            this.dataGridView_listShift.Size = new System.Drawing.Size(646, 235);
            this.dataGridView_listShift.TabIndex = 9;
            this.dataGridView_listShift.Click += new System.EventHandler(this.dataGridView_listShift_Click);
            // 
            // button_reset
            // 
            this.button_reset.BorderRadius = 20;
            this.button_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_reset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.White;
            this.button_reset.Location = new System.Drawing.Point(6, 546);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(95, 34);
            this.button_reset.TabIndex = 4;
            this.button_reset.Text = "Reset";
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // DirectorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1053, 634);
            this.Controls.Add(this.tabControl_director);
            this.Name = "DirectorMainForm";
            this.Text = "DirectorMainForm";
            this.Load += new System.EventHandler(this.DirectorMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_directorImage)).EndInit();
            this.tabPage_profile.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.tabControl_director.ResumeLayout(false);
            this.tabPage_managerManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listManager)).EndInit();
            this.tabPage_facilityManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listFacility)).EndInit();
            this.tabPage_shift.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listShift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_birthDate;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox_directorImage;
        private Guna.UI2.WinForms.Guna2Button button_editInformation;
        private System.Windows.Forms.TabPage tabPage_profile;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TabControl tabControl_director;
        private System.Windows.Forms.TabPage tabPage_managerManagement;
        private System.Windows.Forms.TabPage tabPage_facilityManagement;
        private System.Windows.Forms.DataGridView dataGridView_listManager;
        private Guna.UI2.WinForms.Guna2Button button_addManager;
        private Guna.UI2.WinForms.Guna2Button button_resetData;
        private Guna.UI2.WinForms.Guna2Button button_resetFacility;
        private Guna.UI2.WinForms.Guna2Button button_addFacility;
        private System.Windows.Forms.DataGridView dataGridView_listFacility;
        private Guna.UI2.WinForms.Guna2Button button_updateManager;
        private Guna.UI2.WinForms.Guna2Button button_removeManager;
        private Guna.UI2.WinForms.Guna2Button button_removeFacility;
        private Guna.UI2.WinForms.Guna2Button button_updateFacility;
        private System.Windows.Forms.TabPage tabPage_shift;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button button_resetListShift;
        private Guna.UI2.WinForms.Guna2Button button_addShift;
        private System.Windows.Forms.DataGridView dataGridView_listShift;
        private Guna.UI2.WinForms.Guna2Button button_reset;
    }
}