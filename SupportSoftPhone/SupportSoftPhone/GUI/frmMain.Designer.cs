namespace SupportSoftPhone.GUI
{
    partial class frmMain
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
            System.Windows.Forms.PictureBox picAvatar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnMainTitle = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnMiniApp = new System.Windows.Forms.Button();
            this.bntMaxApp = new System.Windows.Forms.Button();
            this.ntfMessage = new System.Windows.Forms.NotifyIcon(this.components);
            this.ntfMessageMicro = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbHistories = new System.Windows.Forms.GroupBox();
            this.dgvHistories = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAllHistories = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSoftPhone = new System.Windows.Forms.Button();
            this.btnAllCall = new System.Windows.Forms.Button();
            this.btnCallIn = new System.Windows.Forms.Button();
            this.btnCallOut = new System.Windows.Forms.Button();
            this.gbCall = new System.Windows.Forms.GroupBox();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.grSoundDevice = new System.Windows.Forms.GroupBox();
            this.cbMicrophone = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnHistories = new System.Windows.Forms.Button();
            this.cbPhoneNumber = new System.Windows.Forms.ComboBox();
            this.lbNameUser = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDeleteNumPhone = new System.Windows.Forms.Button();
            this.btnKeypad2 = new System.Windows.Forms.Button();
            this.btnKeypad0 = new System.Windows.Forms.Button();
            this.btnKeypad3 = new System.Windows.Forms.Button();
            this.btnKeypad8 = new System.Windows.Forms.Button();
            this.btnKeypad7 = new System.Windows.Forms.Button();
            this.btnKeypad6 = new System.Windows.Forms.Button();
            this.btnKeypad4 = new System.Windows.Forms.Button();
            this.btnKeypad5 = new System.Windows.Forms.Button();
            this.btnKeypadAsterisk = new System.Windows.Forms.Button();
            this.btnKeypad9 = new System.Windows.Forms.Button();
            this.btnKeypadSharp = new System.Windows.Forms.Button();
            this.btnKeypad1 = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.grpSetupAndInCall = new System.Windows.Forms.GroupBox();
            this.lbTimeCall = new System.Windows.Forms.Label();
            this.btnHangup = new System.Windows.Forms.Button();
            this.btnPickup = new System.Windows.Forms.Button();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.lblNetworkStatus = new System.Windows.Forms.Label();
            this.btnTranfer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHold = new System.Windows.Forms.Button();
            this.lblCallStatus = new System.Windows.Forms.Label();
            this.lblDialNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            picAvatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picAvatar)).BeginInit();
            this.pnMainTitle.SuspendLayout();
            this.gbHistories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistories)).BeginInit();
            this.gbAllHistories.SuspendLayout();
            this.gbCall.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.grSoundDevice.SuspendLayout();
            this.grpSetupAndInCall.SuspendLayout();
            this.SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            picAvatar.Image = global::SupportSoftPhone.Properties.Resources.avatar;
            picAvatar.Location = new System.Drawing.Point(118, 59);
            picAvatar.Margin = new System.Windows.Forms.Padding(0);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new System.Drawing.Size(90, 90);
            picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            picAvatar.TabIndex = 69;
            picAvatar.TabStop = false;
            // 
            // pnMainTitle
            // 
            this.pnMainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(71)))), ((int)(((byte)(142)))));
            this.pnMainTitle.Controls.Add(this.label4);
            this.pnMainTitle.Controls.Add(this.btnCloseApp);
            this.pnMainTitle.Controls.Add(this.btnMiniApp);
            this.pnMainTitle.Controls.Add(this.bntMaxApp);
            this.pnMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMainTitle.Location = new System.Drawing.Point(0, 0);
            this.pnMainTitle.Name = "pnMainTitle";
            this.pnMainTitle.Size = new System.Drawing.Size(336, 26);
            this.pnMainTitle.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MATBAO SUPPORT PHONE v2.4";
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseApp.BackgroundImage = global::SupportSoftPhone.Properties.Resources.close_app;
            this.btnCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Location = new System.Drawing.Point(312, 3);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(24, 23);
            this.btnCloseApp.TabIndex = 1;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnMiniApp
            // 
            this.btnMiniApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMiniApp.BackgroundImage = global::SupportSoftPhone.Properties.Resources.minimize_app;
            this.btnMiniApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMiniApp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMiniApp.FlatAppearance.BorderSize = 0;
            this.btnMiniApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniApp.Location = new System.Drawing.Point(269, 3);
            this.btnMiniApp.Name = "btnMiniApp";
            this.btnMiniApp.Size = new System.Drawing.Size(24, 23);
            this.btnMiniApp.TabIndex = 3;
            this.btnMiniApp.UseVisualStyleBackColor = true;
            this.btnMiniApp.Click += new System.EventHandler(this.btnMiniApp_Click);
            // 
            // bntMaxApp
            // 
            this.bntMaxApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntMaxApp.BackgroundImage = global::SupportSoftPhone.Properties.Resources.maximize_app;
            this.bntMaxApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntMaxApp.Enabled = false;
            this.bntMaxApp.FlatAppearance.BorderSize = 0;
            this.bntMaxApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMaxApp.Location = new System.Drawing.Point(290, 3);
            this.bntMaxApp.Name = "bntMaxApp";
            this.bntMaxApp.Size = new System.Drawing.Size(24, 23);
            this.bntMaxApp.TabIndex = 2;
            this.bntMaxApp.UseVisualStyleBackColor = true;
            // 
            // ntfMessage
            // 
            this.ntfMessage.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfMessage.Icon")));
            this.ntfMessage.Text = "Support Mat Bao";
            this.ntfMessage.Visible = true;
            this.ntfMessage.BalloonTipClicked += new System.EventHandler(this.ntfMessage_BalloonTipClicked);
            // 
            // ntfMessageMicro
            // 
            this.ntfMessageMicro.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfMessageMicro.Icon")));
            this.ntfMessageMicro.Text = "notifyIcon1";
            this.ntfMessageMicro.Visible = true;
            // 
            // gbHistories
            // 
            this.gbHistories.Controls.Add(this.dgvHistories);
            this.gbHistories.Location = new System.Drawing.Point(2, 40);
            this.gbHistories.Name = "gbHistories";
            this.gbHistories.Size = new System.Drawing.Size(327, 353);
            this.gbHistories.TabIndex = 47;
            this.gbHistories.TabStop = false;
            // 
            // dgvHistories
            // 
            this.dgvHistories.AllowUserToAddRows = false;
            this.dgvHistories.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHistories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.callDate,
            this.phone});
            this.dgvHistories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistories.Location = new System.Drawing.Point(3, 16);
            this.dgvHistories.Name = "dgvHistories";
            this.dgvHistories.ReadOnly = true;
            this.dgvHistories.Size = new System.Drawing.Size(321, 334);
            this.dgvHistories.TabIndex = 0;
            // 
            // type
            // 
            this.type.DataPropertyName = "u_phone_type";
            this.type.HeaderText = "Loại";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 50;
            // 
            // callDate
            // 
            this.callDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.callDate.DataPropertyName = "u_phone_date";
            this.callDate.HeaderText = "Ngày Gọi";
            this.callDate.Name = "callDate";
            this.callDate.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "u_phone_number";
            this.phone.HeaderText = "Số Điện Thoại";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // gbAllHistories
            // 
            this.gbAllHistories.Controls.Add(this.label3);
            this.gbAllHistories.Controls.Add(this.btnSoftPhone);
            this.gbAllHistories.Controls.Add(this.btnAllCall);
            this.gbAllHistories.Controls.Add(this.btnCallIn);
            this.gbAllHistories.Controls.Add(this.btnCallOut);
            this.gbAllHistories.Controls.Add(this.gbHistories);
            this.gbAllHistories.Location = new System.Drawing.Point(-2, 30);
            this.gbAllHistories.Name = "gbAllHistories";
            this.gbAllHistories.Size = new System.Drawing.Size(337, 478);
            this.gbAllHistories.TabIndex = 48;
            this.gbAllHistories.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Lịch sử";
            // 
            // btnSoftPhone
            // 
            this.btnSoftPhone.BackgroundImage = global::SupportSoftPhone.Properties.Resources.softphone;
            this.btnSoftPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSoftPhone.FlatAppearance.BorderSize = 0;
            this.btnSoftPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftPhone.Location = new System.Drawing.Point(268, 404);
            this.btnSoftPhone.Name = "btnSoftPhone";
            this.btnSoftPhone.Size = new System.Drawing.Size(66, 42);
            this.btnSoftPhone.TabIndex = 51;
            this.btnSoftPhone.UseVisualStyleBackColor = true;
            this.btnSoftPhone.Click += new System.EventHandler(this.btnSoftPhone_Click);
            this.btnSoftPhone.MouseLeave += new System.EventHandler(this.btnSoftPhone_MouseLeaver);
            this.btnSoftPhone.MouseHover += new System.EventHandler(this.btnSoftPhone_MouseHover);
            // 
            // btnAllCall
            // 
            this.btnAllCall.Location = new System.Drawing.Point(19, 412);
            this.btnAllCall.Name = "btnAllCall";
            this.btnAllCall.Size = new System.Drawing.Size(53, 23);
            this.btnAllCall.TabIndex = 50;
            this.btnAllCall.Text = "Tất cả";
            this.btnAllCall.UseVisualStyleBackColor = true;
            this.btnAllCall.Click += new System.EventHandler(this.btnAllCall_Click);
            // 
            // btnCallIn
            // 
            this.btnCallIn.Location = new System.Drawing.Point(185, 412);
            this.btnCallIn.Name = "btnCallIn";
            this.btnCallIn.Size = new System.Drawing.Size(77, 23);
            this.btnCallIn.TabIndex = 49;
            this.btnCallIn.Text = "Cuộc gọi tới";
            this.btnCallIn.UseVisualStyleBackColor = true;
            this.btnCallIn.Click += new System.EventHandler(this.btnCallIn_Click);
            // 
            // btnCallOut
            // 
            this.btnCallOut.FlatAppearance.BorderSize = 0;
            this.btnCallOut.Location = new System.Drawing.Point(89, 412);
            this.btnCallOut.Name = "btnCallOut";
            this.btnCallOut.Size = new System.Drawing.Size(79, 23);
            this.btnCallOut.TabIndex = 48;
            this.btnCallOut.Text = "Cuộc gọi đi";
            this.btnCallOut.UseVisualStyleBackColor = true;
            this.btnCallOut.Click += new System.EventHandler(this.btnCallOut_Click);
            // 
            // gbCall
            // 
            this.gbCall.Controls.Add(this.btnHistories);
            this.gbCall.Controls.Add(this.cbPhoneNumber);
            this.gbCall.Controls.Add(this.lbNameUser);
            this.gbCall.Controls.Add(this.btnNext);
            this.gbCall.Controls.Add(this.btnDeleteNumPhone);
            this.gbCall.Controls.Add(this.btnKeypad2);
            this.gbCall.Controls.Add(this.btnKeypad0);
            this.gbCall.Controls.Add(this.btnKeypad3);
            this.gbCall.Controls.Add(this.btnKeypad8);
            this.gbCall.Controls.Add(this.btnKeypad7);
            this.gbCall.Controls.Add(this.btnKeypad6);
            this.gbCall.Controls.Add(this.btnKeypad4);
            this.gbCall.Controls.Add(this.btnKeypad5);
            this.gbCall.Controls.Add(this.btnKeypadAsterisk);
            this.gbCall.Controls.Add(this.btnKeypad9);
            this.gbCall.Controls.Add(this.btnKeypadSharp);
            this.gbCall.Controls.Add(this.btnKeypad1);
            this.gbCall.Controls.Add(this.btnCall);
            this.gbCall.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCall.Location = new System.Drawing.Point(-2, 29);
            this.gbCall.Name = "gbCall";
            this.gbCall.Size = new System.Drawing.Size(337, 478);
            this.gbCall.TabIndex = 7;
            this.gbCall.TabStop = false;
            // 
            // gbRegister
            // 
            this.gbRegister.BackColor = System.Drawing.Color.Transparent;
            this.gbRegister.Controls.Add(this.grSoundDevice);
            this.gbRegister.Controls.Add(this.label2);
            this.gbRegister.Controls.Add(this.label1);
            this.gbRegister.Controls.Add(this.txtEmailLogin);
            this.gbRegister.Controls.Add(this.btnRegister);
            this.gbRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegister.Location = new System.Drawing.Point(0, 26);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(335, 478);
            this.gbRegister.TabIndex = 49;
            this.gbRegister.TabStop = false;
            // 
            // grSoundDevice
            // 
            this.grSoundDevice.Controls.Add(this.cbMicrophone);
            this.grSoundDevice.Location = new System.Drawing.Point(6, 330);
            this.grSoundDevice.Name = "grSoundDevice";
            this.grSoundDevice.Size = new System.Drawing.Size(323, 73);
            this.grSoundDevice.TabIndex = 11;
            this.grSoundDevice.TabStop = false;
            this.grSoundDevice.Text = "Thiết bị âm thanh:";
            // 
            // cbMicrophone
            // 
            this.cbMicrophone.BackColor = System.Drawing.SystemColors.Window;
            this.cbMicrophone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMicrophone.FormattingEnabled = true;
            this.cbMicrophone.Location = new System.Drawing.Point(20, 25);
            this.cbMicrophone.Name = "cbMicrophone";
            this.cbMicrophone.Size = new System.Drawing.Size(286, 23);
            this.cbMicrophone.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đăng nhập";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email:";
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.BackColor = System.Drawing.Color.Aquamarine;
            this.txtEmailLogin.Location = new System.Drawing.Point(71, 67);
            this.txtEmailLogin.Multiline = true;
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(227, 25);
            this.txtEmailLogin.TabIndex = 6;
            this.txtEmailLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmailLogin_KeyDown);
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = global::SupportSoftPhone.Properties.Resources.bt_register;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(70, 100);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(102, 32);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            this.btnRegister.MouseLeave += new System.EventHandler(this.btnRegister_MouseLeave);
            this.btnRegister.MouseHover += new System.EventHandler(this.btnRegister_MouseHover);
            // 
            // btnHistories
            // 
            this.btnHistories.BackColor = System.Drawing.Color.Transparent;
            this.btnHistories.BackgroundImage = global::SupportSoftPhone.Properties.Resources.history1;
            this.btnHistories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHistories.FlatAppearance.BorderSize = 0;
            this.btnHistories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistories.Location = new System.Drawing.Point(65, 375);
            this.btnHistories.Name = "btnHistories";
            this.btnHistories.Size = new System.Drawing.Size(46, 40);
            this.btnHistories.TabIndex = 78;
            this.btnHistories.UseVisualStyleBackColor = false;
            this.btnHistories.Click += new System.EventHandler(this.btnHistories_Click);
            this.btnHistories.MouseLeave += new System.EventHandler(this.btnHistories_MouseLeaver);
            this.btnHistories.MouseHover += new System.EventHandler(this.btnHistories_MouseHover);
            // 
            // cbPhoneNumber
            // 
            this.cbPhoneNumber.DropDownHeight = 120;
            this.cbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhoneNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbPhoneNumber.FormattingEnabled = true;
            this.cbPhoneNumber.IntegralHeight = false;
            this.cbPhoneNumber.Location = new System.Drawing.Point(55, 51);
            this.cbPhoneNumber.Name = "cbPhoneNumber";
            this.cbPhoneNumber.Size = new System.Drawing.Size(229, 24);
            this.cbPhoneNumber.TabIndex = 79;
            this.cbPhoneNumber.SelectedIndexChanged += new System.EventHandler(this.cbPhoneNumber_TextChanged);
            this.cbPhoneNumber.TextChanged += new System.EventHandler(this.cbPhoneNumber_TextChanged);
            this.cbPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPhoneNumber_KeyDown);
            this.cbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPhoneNumber_KeyPress);
            // 
            // lbNameUser
            // 
            this.lbNameUser.AutoEllipsis = true;
            this.lbNameUser.BackColor = System.Drawing.Color.Transparent;
            this.lbNameUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNameUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameUser.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbNameUser.Location = new System.Drawing.Point(23, 18);
            this.lbNameUser.Margin = new System.Windows.Forms.Padding(0);
            this.lbNameUser.Name = "lbNameUser";
            this.lbNameUser.Size = new System.Drawing.Size(305, 19);
            this.lbNameUser.TabIndex = 78;
            this.lbNameUser.Text = "My phone";
            this.lbNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = global::SupportSoftPhone.Properties.Resources.bt_to_main_call;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(208, 413);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 64);
            this.btnNext.TabIndex = 30;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDeleteNumPhone
            // 
            this.btnDeleteNumPhone.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteNumPhone.BackgroundImage = global::SupportSoftPhone.Properties.Resources.clear_pad;
            this.btnDeleteNumPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteNumPhone.FlatAppearance.BorderSize = 0;
            this.btnDeleteNumPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNumPhone.Location = new System.Drawing.Point(222, 384);
            this.btnDeleteNumPhone.Name = "btnDeleteNumPhone";
            this.btnDeleteNumPhone.Size = new System.Drawing.Size(38, 23);
            this.btnDeleteNumPhone.TabIndex = 29;
            this.btnDeleteNumPhone.UseVisualStyleBackColor = false;
            this.btnDeleteNumPhone.Click += new System.EventHandler(this.btnDeleteNumPhone_Click);
            this.btnDeleteNumPhone.MouseLeave += new System.EventHandler(this.btnDeleteNumPhone_MouseLeave);
            this.btnDeleteNumPhone.MouseHover += new System.EventHandler(this.btnDeleteNumPhone_MouseHover);
            // 
            // btnKeypad2
            // 
            this.btnKeypad2.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypad2.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_2;
            this.btnKeypad2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypad2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypad2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypad2.FlatAppearance.BorderSize = 0;
            this.btnKeypad2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypad2.ForeColor = System.Drawing.Color.Black;
            this.btnKeypad2.Location = new System.Drawing.Point(139, 75);
            this.btnKeypad2.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypad2.Name = "btnKeypad2";
            this.btnKeypad2.Size = new System.Drawing.Size(68, 66);
            this.btnKeypad2.TabIndex = 18;
            this.btnKeypad2.Tag = "2";
            this.btnKeypad2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeypad2.UseVisualStyleBackColor = false;
            this.btnKeypad2.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypad2.MouseLeave += new System.EventHandler(this.btnKeypad2_MouseLeave);
            this.btnKeypad2.MouseHover += new System.EventHandler(this.btnKeypad2_MouseHover);
            // 
            // btnKeypad0
            // 
            this.btnKeypad0.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypad0.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_0;
            this.btnKeypad0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypad0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypad0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypad0.FlatAppearance.BorderSize = 0;
            this.btnKeypad0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad0.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypad0.ForeColor = System.Drawing.Color.Black;
            this.btnKeypad0.Location = new System.Drawing.Point(132, 291);
            this.btnKeypad0.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypad0.Name = "btnKeypad0";
            this.btnKeypad0.Size = new System.Drawing.Size(68, 66);
            this.btnKeypad0.TabIndex = 27;
            this.btnKeypad0.Tag = "0";
            this.btnKeypad0.UseVisualStyleBackColor = false;
            this.btnKeypad0.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypad0.MouseLeave += new System.EventHandler(this.btnKeypad0_MouseLeave);
            this.btnKeypad0.MouseHover += new System.EventHandler(this.btnKeypad0_MouseHover);
            // 
            // btnKeypad3
            // 
            this.btnKeypad3.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypad3.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_3;
            this.btnKeypad3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypad3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypad3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypad3.FlatAppearance.BorderSize = 0;
            this.btnKeypad3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypad3.ForeColor = System.Drawing.Color.Black;
            this.btnKeypad3.Location = new System.Drawing.Point(216, 75);
            this.btnKeypad3.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypad3.Name = "btnKeypad3";
            this.btnKeypad3.Size = new System.Drawing.Size(68, 66);
            this.btnKeypad3.TabIndex = 19;
            this.btnKeypad3.Tag = "3";
            this.btnKeypad3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeypad3.UseVisualStyleBackColor = false;
            this.btnKeypad3.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypad3.MouseLeave += new System.EventHandler(this.btnKeypad3_MouseLeave);
            this.btnKeypad3.MouseHover += new System.EventHandler(this.btnKeypad3_MouseHover);
            // 
            // btnKeypad8
            // 
            this.btnKeypad8.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypad8.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_8;
            this.btnKeypad8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypad8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypad8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypad8.FlatAppearance.BorderSize = 0;
            this.btnKeypad8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad8.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypad8.ForeColor = System.Drawing.Color.Black;
            this.btnKeypad8.Location = new System.Drawing.Point(132, 219);
            this.btnKeypad8.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypad8.Name = "btnKeypad8";
            this.btnKeypad8.Size = new System.Drawing.Size(68, 66);
            this.btnKeypad8.TabIndex = 24;
            this.btnKeypad8.Tag = "8";
            this.btnKeypad8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeypad8.UseVisualStyleBackColor = false;
            this.btnKeypad8.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypad8.MouseLeave += new System.EventHandler(this.btnKeypad8_MouseLeave);
            this.btnKeypad8.MouseHover += new System.EventHandler(this.btnKeypad8_MouseHover);
            // 
            // btnKeypad7
            // 
            this.btnKeypad7.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypad7.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_7;
            this.btnKeypad7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypad7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypad7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypad7.FlatAppearance.BorderSize = 0;
            this.btnKeypad7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad7.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypad7.ForeColor = System.Drawing.Color.Black;
            this.btnKeypad7.Location = new System.Drawing.Point(55, 219);
            this.btnKeypad7.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypad7.Name = "btnKeypad7";
            this.btnKeypad7.Size = new System.Drawing.Size(68, 66);
            this.btnKeypad7.TabIndex = 23;
            this.btnKeypad7.Tag = "7";
            this.btnKeypad7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeypad7.UseVisualStyleBackColor = false;
            this.btnKeypad7.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypad7.MouseLeave += new System.EventHandler(this.btnKeypad7_MouseLeave);
            this.btnKeypad7.MouseHover += new System.EventHandler(this.btnKeypad7_MouseHover);
            // 
            // btnKeypad6
            // 
            this.btnKeypad6.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypad6.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_6;
            this.btnKeypad6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypad6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypad6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypad6.FlatAppearance.BorderSize = 0;
            this.btnKeypad6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad6.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypad6.ForeColor = System.Drawing.Color.Black;
            this.btnKeypad6.Location = new System.Drawing.Point(216, 147);
            this.btnKeypad6.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypad6.Name = "btnKeypad6";
            this.btnKeypad6.Size = new System.Drawing.Size(68, 66);
            this.btnKeypad6.TabIndex = 22;
            this.btnKeypad6.Tag = "6";
            this.btnKeypad6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeypad6.UseVisualStyleBackColor = false;
            this.btnKeypad6.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypad6.MouseLeave += new System.EventHandler(this.btnKeypad6_MouseLeave);
            this.btnKeypad6.MouseHover += new System.EventHandler(this.btnKeypad6_MouseHover);
            // 
            // btnKeypad4
            // 
            this.btnKeypad4.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypad4.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_4;
            this.btnKeypad4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypad4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypad4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypad4.FlatAppearance.BorderSize = 0;
            this.btnKeypad4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypad4.ForeColor = System.Drawing.Color.Black;
            this.btnKeypad4.Location = new System.Drawing.Point(55, 147);
            this.btnKeypad4.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypad4.Name = "btnKeypad4";
            this.btnKeypad4.Size = new System.Drawing.Size(68, 66);
            this.btnKeypad4.TabIndex = 20;
            this.btnKeypad4.Tag = "4";
            this.btnKeypad4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeypad4.UseVisualStyleBackColor = false;
            this.btnKeypad4.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypad4.MouseLeave += new System.EventHandler(this.btnKeypad4_MouseLeave);
            this.btnKeypad4.MouseHover += new System.EventHandler(this.btnKeypad4_MouseHover);
            // 
            // btnKeypad5
            // 
            this.btnKeypad5.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypad5.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_5;
            this.btnKeypad5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypad5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypad5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypad5.FlatAppearance.BorderSize = 0;
            this.btnKeypad5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypad5.ForeColor = System.Drawing.Color.Black;
            this.btnKeypad5.Location = new System.Drawing.Point(132, 147);
            this.btnKeypad5.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypad5.Name = "btnKeypad5";
            this.btnKeypad5.Size = new System.Drawing.Size(68, 66);
            this.btnKeypad5.TabIndex = 21;
            this.btnKeypad5.Tag = "5";
            this.btnKeypad5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeypad5.UseVisualStyleBackColor = false;
            this.btnKeypad5.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypad5.MouseLeave += new System.EventHandler(this.btnKeypad5_MouseLeave);
            this.btnKeypad5.MouseHover += new System.EventHandler(this.btnKeypad5_MouseHover);
            // 
            // btnKeypadAsterisk
            // 
            this.btnKeypadAsterisk.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypadAsterisk.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_sao;
            this.btnKeypadAsterisk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypadAsterisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypadAsterisk.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypadAsterisk.FlatAppearance.BorderSize = 0;
            this.btnKeypadAsterisk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypadAsterisk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypadAsterisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypadAsterisk.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypadAsterisk.ForeColor = System.Drawing.Color.Black;
            this.btnKeypadAsterisk.Location = new System.Drawing.Point(55, 291);
            this.btnKeypadAsterisk.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypadAsterisk.Name = "btnKeypadAsterisk";
            this.btnKeypadAsterisk.Size = new System.Drawing.Size(68, 66);
            this.btnKeypadAsterisk.TabIndex = 26;
            this.btnKeypadAsterisk.Tag = "*";
            this.btnKeypadAsterisk.UseVisualStyleBackColor = false;
            this.btnKeypadAsterisk.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypadAsterisk.MouseLeave += new System.EventHandler(this.btnKeypadAsterisk_MouseLeave);
            this.btnKeypadAsterisk.MouseHover += new System.EventHandler(this.btnKeypadAsterisk_MouseHover);
            // 
            // btnKeypad9
            // 
            this.btnKeypad9.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypad9.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_9;
            this.btnKeypad9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypad9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypad9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypad9.FlatAppearance.BorderSize = 0;
            this.btnKeypad9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad9.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypad9.ForeColor = System.Drawing.Color.Black;
            this.btnKeypad9.Location = new System.Drawing.Point(216, 219);
            this.btnKeypad9.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypad9.Name = "btnKeypad9";
            this.btnKeypad9.Size = new System.Drawing.Size(68, 66);
            this.btnKeypad9.TabIndex = 25;
            this.btnKeypad9.Tag = "9";
            this.btnKeypad9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeypad9.UseVisualStyleBackColor = false;
            this.btnKeypad9.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypad9.MouseLeave += new System.EventHandler(this.btnKeypad9_MouseLeave);
            this.btnKeypad9.MouseHover += new System.EventHandler(this.btnKeypad9_MouseHover);
            // 
            // btnKeypadSharp
            // 
            this.btnKeypadSharp.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypadSharp.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_sharp;
            this.btnKeypadSharp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypadSharp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypadSharp.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKeypadSharp.FlatAppearance.BorderSize = 0;
            this.btnKeypadSharp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypadSharp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypadSharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypadSharp.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypadSharp.ForeColor = System.Drawing.Color.Black;
            this.btnKeypadSharp.Location = new System.Drawing.Point(216, 291);
            this.btnKeypadSharp.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypadSharp.Name = "btnKeypadSharp";
            this.btnKeypadSharp.Size = new System.Drawing.Size(68, 66);
            this.btnKeypadSharp.TabIndex = 28;
            this.btnKeypadSharp.Tag = "#";
            this.btnKeypadSharp.UseVisualStyleBackColor = false;
            this.btnKeypadSharp.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypadSharp.MouseLeave += new System.EventHandler(this.btnKeypadSharp_MouseLeave);
            this.btnKeypadSharp.MouseHover += new System.EventHandler(this.btnKeypadSharp_MouseHover);
            // 
            // btnKeypad1
            // 
            this.btnKeypad1.BackColor = System.Drawing.Color.Transparent;
            this.btnKeypad1.BackgroundImage = global::SupportSoftPhone.Properties.Resources.p_1;
            this.btnKeypad1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeypad1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeypad1.FlatAppearance.BorderSize = 0;
            this.btnKeypad1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeypad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeypad1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeypad1.ForeColor = System.Drawing.Color.Black;
            this.btnKeypad1.Location = new System.Drawing.Point(55, 75);
            this.btnKeypad1.Margin = new System.Windows.Forms.Padding(0);
            this.btnKeypad1.Name = "btnKeypad1";
            this.btnKeypad1.Size = new System.Drawing.Size(68, 66);
            this.btnKeypad1.TabIndex = 17;
            this.btnKeypad1.Tag = "1";
            this.btnKeypad1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKeypad1.UseVisualStyleBackColor = false;
            this.btnKeypad1.Click += new System.EventHandler(this.Keypad_Click);
            this.btnKeypad1.MouseLeave += new System.EventHandler(this.btnKeypad1_MouseLeave);
            this.btnKeypad1.MouseHover += new System.EventHandler(this.btnKeypad1_MouseHover);
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.Color.Transparent;
            this.btnCall.BackgroundImage = global::SupportSoftPhone.Properties.Resources.call;
            this.btnCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCall.FlatAppearance.BorderSize = 0;
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCall.Location = new System.Drawing.Point(132, 360);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 65);
            this.btnCall.TabIndex = 2;
            this.btnCall.UseVisualStyleBackColor = false;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // grpSetupAndInCall
            // 
            this.grpSetupAndInCall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpSetupAndInCall.BackColor = System.Drawing.Color.White;
            this.grpSetupAndInCall.BackgroundImage = global::SupportSoftPhone.Properties.Resources.bg_green;
            this.grpSetupAndInCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpSetupAndInCall.Controls.Add(this.lbTimeCall);
            this.grpSetupAndInCall.Controls.Add(this.btnHangup);
            this.grpSetupAndInCall.Controls.Add(this.btnPickup);
            this.grpSetupAndInCall.Controls.Add(this.btnKeyboard);
            this.grpSetupAndInCall.Controls.Add(this.lblNetworkStatus);
            this.grpSetupAndInCall.Controls.Add(picAvatar);
            this.grpSetupAndInCall.Controls.Add(this.btnTranfer);
            this.grpSetupAndInCall.Controls.Add(this.label5);
            this.grpSetupAndInCall.Controls.Add(this.label8);
            this.grpSetupAndInCall.Controls.Add(this.btnHold);
            this.grpSetupAndInCall.Controls.Add(this.lblCallStatus);
            this.grpSetupAndInCall.Controls.Add(this.lblDialNumber);
            this.grpSetupAndInCall.Controls.Add(this.label11);
            this.grpSetupAndInCall.Controls.Add(this.label12);
            this.grpSetupAndInCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSetupAndInCall.Location = new System.Drawing.Point(0, 29);
            this.grpSetupAndInCall.Margin = new System.Windows.Forms.Padding(0);
            this.grpSetupAndInCall.Name = "grpSetupAndInCall";
            this.grpSetupAndInCall.Padding = new System.Windows.Forms.Padding(0);
            this.grpSetupAndInCall.Size = new System.Drawing.Size(337, 478);
            this.grpSetupAndInCall.TabIndex = 49;
            this.grpSetupAndInCall.TabStop = false;
            // 
            // lbTimeCall
            // 
            this.lbTimeCall.AutoEllipsis = true;
            this.lbTimeCall.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimeCall.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeCall.ForeColor = System.Drawing.Color.White;
            this.lbTimeCall.Location = new System.Drawing.Point(63, 177);
            this.lbTimeCall.Margin = new System.Windows.Forms.Padding(0);
            this.lbTimeCall.Name = "lbTimeCall";
            this.lbTimeCall.Size = new System.Drawing.Size(202, 34);
            this.lbTimeCall.TabIndex = 77;
            this.lbTimeCall.Text = "00:00";
            this.lbTimeCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHangup
            // 
            this.btnHangup.BackColor = System.Drawing.Color.Transparent;
            this.btnHangup.BackgroundImage = global::SupportSoftPhone.Properties.Resources.call_off;
            this.btnHangup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHangup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHangup.FlatAppearance.BorderSize = 0;
            this.btnHangup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangup.Location = new System.Drawing.Point(234, 375);
            this.btnHangup.Name = "btnHangup";
            this.btnHangup.Size = new System.Drawing.Size(62, 62);
            this.btnHangup.TabIndex = 76;
            this.btnHangup.UseVisualStyleBackColor = false;
            this.btnHangup.Click += new System.EventHandler(this.btnHangUp_Click);
            // 
            // btnPickup
            // 
            this.btnPickup.BackColor = System.Drawing.Color.Transparent;
            this.btnPickup.BackgroundImage = global::SupportSoftPhone.Properties.Resources.call;
            this.btnPickup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPickup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickup.FlatAppearance.BorderSize = 0;
            this.btnPickup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickup.Location = new System.Drawing.Point(35, 375);
            this.btnPickup.Name = "btnPickup";
            this.btnPickup.Size = new System.Drawing.Size(62, 62);
            this.btnPickup.TabIndex = 75;
            this.btnPickup.UseVisualStyleBackColor = false;
            this.btnPickup.Click += new System.EventHandler(this.btnPickup_Click);
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.BackColor = System.Drawing.Color.Transparent;
            this.btnKeyboard.BackgroundImage = global::SupportSoftPhone.Properties.Resources.keyboard;
            this.btnKeyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeyboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeyboard.FlatAppearance.BorderSize = 0;
            this.btnKeyboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnKeyboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKeyboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeyboard.Location = new System.Drawing.Point(26, 232);
            this.btnKeyboard.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(57, 57);
            this.btnKeyboard.TabIndex = 64;
            this.btnKeyboard.Tag = "";
            this.btnKeyboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeyboard.UseVisualStyleBackColor = false;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            this.btnKeyboard.MouseLeave += new System.EventHandler(this.btnKeyboard_MouseLeave);
            this.btnKeyboard.MouseHover += new System.EventHandler(this.btnKeyboard_MouseHover);
            // 
            // lblNetworkStatus
            // 
            this.lblNetworkStatus.AutoSize = true;
            this.lblNetworkStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblNetworkStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNetworkStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetworkStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblNetworkStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNetworkStatus.Location = new System.Drawing.Point(203, 34);
            this.lblNetworkStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblNetworkStatus.Name = "lblNetworkStatus";
            this.lblNetworkStatus.Size = new System.Drawing.Size(27, 14);
            this.lblNetworkStatus.TabIndex = 63;
            this.lblNetworkStatus.Text = "Tốt";
            this.lblNetworkStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTranfer
            // 
            this.btnTranfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTranfer.BackgroundImage = global::SupportSoftPhone.Properties.Resources.bt_transfer;
            this.btnTranfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTranfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTranfer.FlatAppearance.BorderSize = 0;
            this.btnTranfer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnTranfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTranfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTranfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTranfer.Location = new System.Drawing.Point(245, 232);
            this.btnTranfer.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnTranfer.Name = "btnTranfer";
            this.btnTranfer.Size = new System.Drawing.Size(57, 57);
            this.btnTranfer.TabIndex = 20;
            this.btnTranfer.Tag = "transfer";
            this.btnTranfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTranfer.UseVisualStyleBackColor = false;
            this.btnTranfer.Click += new System.EventHandler(this.btnTranfer_Click);
            this.btnTranfer.MouseLeave += new System.EventHandler(this.btnTranfer_MouseLeave);
            this.btnTranfer.MouseHover += new System.EventHandler(this.btnTranfer_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(108, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 14);
            this.label5.TabIndex = 62;
            this.label5.Text = "Đường truyền:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(32, 298);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 66;
            this.label8.Text = "Bàn phím";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.Color.Transparent;
            this.btnHold.BackgroundImage = global::SupportSoftPhone.Properties.Resources.bt_hold;
            this.btnHold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnHold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHold.Location = new System.Drawing.Point(136, 232);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(57, 57);
            this.btnHold.TabIndex = 38;
            this.btnHold.Tag = "hold";
            this.btnHold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHold.UseVisualStyleBackColor = false;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            this.btnHold.MouseLeave += new System.EventHandler(this.btnHold_MouseLeave);
            this.btnHold.MouseHover += new System.EventHandler(this.btnHold_MouseHover);
            // 
            // lblCallStatus
            // 
            this.lblCallStatus.AutoEllipsis = true;
            this.lblCallStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCallStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCallStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallStatus.ForeColor = System.Drawing.Color.White;
            this.lblCallStatus.Location = new System.Drawing.Point(11, 178);
            this.lblCallStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblCallStatus.Name = "lblCallStatus";
            this.lblCallStatus.Size = new System.Drawing.Size(300, 24);
            this.lblCallStatus.TabIndex = 74;
            this.lblCallStatus.Text = "Ringing...";
            this.lblCallStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDialNumber
            // 
            this.lblDialNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblDialNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDialNumber.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialNumber.ForeColor = System.Drawing.Color.White;
            this.lblDialNumber.Location = new System.Drawing.Point(16, 156);
            this.lblDialNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblDialNumber.Name = "lblDialNumber";
            this.lblDialNumber.Size = new System.Drawing.Size(300, 24);
            this.lblDialNumber.TabIndex = 73;
            this.lblDialNumber.Text = "0964889998";
            this.lblDialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(135, 297);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 12);
            this.label11.TabIndex = 71;
            this.label11.Text = "Giữ cuộc gọi";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Tahoma", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(255, 299);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 72;
            this.label12.Text = "Chuyển";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(336, 478);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.gbCall);
            this.Controls.Add(this.grpSetupAndInCall);
            this.Controls.Add(this.gbAllHistories);
            this.Controls.Add(this.pnMainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(picAvatar)).EndInit();
            this.pnMainTitle.ResumeLayout(false);
            this.pnMainTitle.PerformLayout();
            this.gbHistories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistories)).EndInit();
            this.gbAllHistories.ResumeLayout(false);
            this.gbAllHistories.PerformLayout();
            this.gbCall.ResumeLayout(false);
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.grSoundDevice.ResumeLayout(false);
            this.grpSetupAndInCall.ResumeLayout(false);
            this.grpSetupAndInCall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMainTitle;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Button bntMaxApp;
        private System.Windows.Forms.Button btnMiniApp;
        private System.Windows.Forms.NotifyIcon ntfMessage;
        private System.Windows.Forms.NotifyIcon ntfMessageMicro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbHistories;
        private System.Windows.Forms.DataGridView dgvHistories;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn callDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.GroupBox gbAllHistories;
        private System.Windows.Forms.Button btnCallOut;
        private System.Windows.Forms.Button btnAllCall;
        private System.Windows.Forms.Button btnCallIn;
        private System.Windows.Forms.Button btnSoftPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCall;
        private System.Windows.Forms.Button btnHistories;
        private System.Windows.Forms.ComboBox cbPhoneNumber;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnDeleteNumPhone;
        private System.Windows.Forms.Button btnKeypad2;
        private System.Windows.Forms.Button btnKeypad0;
        private System.Windows.Forms.Button btnKeypad3;
        private System.Windows.Forms.Button btnKeypad8;
        private System.Windows.Forms.Button btnKeypad7;
        private System.Windows.Forms.Button btnKeypad6;
        private System.Windows.Forms.Button btnKeypad4;
        private System.Windows.Forms.Button btnKeypad5;
        private System.Windows.Forms.Button btnKeypadAsterisk;
        private System.Windows.Forms.Button btnKeypad9;
        private System.Windows.Forms.Button btnKeypadSharp;
        private System.Windows.Forms.Button btnKeypad1;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.GroupBox grSoundDevice;
        private System.Windows.Forms.ComboBox cbMicrophone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox grpSetupAndInCall;
        private System.Windows.Forms.Label lbTimeCall;
        private System.Windows.Forms.Button btnHangup;
        private System.Windows.Forms.Button btnPickup;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Label lblNetworkStatus;
        private System.Windows.Forms.Button btnTranfer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Label lblCallStatus;
        private System.Windows.Forms.Label lblDialNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}