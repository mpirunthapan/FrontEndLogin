namespace FrontendWin
{
    partial class Register
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
            btnExit = new MetroSet_UI.Controls.MetroSetButton();
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            tbAddress = new TextBox();
            tbFirstname = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnRegister = new Button();
            btnClear = new Button();
            cbShowPassword = new CheckBox();
            cmbGender = new ComboBox();
            tbPassword = new TextBox();
            tbPhoneNo = new TextBox();
            tbLastname = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnExit.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnExit.DisabledForeColor = Color.Gray;
            btnExit.Font = new Font("ABeeZee", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnExit.HoverColor = Color.FromArgb(95, 207, 255);
            btnExit.HoverTextColor = Color.White;
            btnExit.IsDerivedStyle = true;
            btnExit.Location = new Point(46, 337);
            btnExit.Name = "btnExit";
            btnExit.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnExit.NormalColor = Color.FromArgb(65, 177, 225);
            btnExit.NormalTextColor = Color.White;
            btnExit.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnExit.PressColor = Color.FromArgb(35, 147, 195);
            btnExit.PressTextColor = Color.White;
            btnExit.Size = new Size(112, 34);
            btnExit.Style = MetroSet_UI.Enums.Style.Light;
            btnExit.StyleManager = null;
            btnExit.TabIndex = 39;
            btnExit.Text = "Exit";
            btnExit.ThemeAuthor = "Narwin";
            btnExit.ThemeName = "MetroLite";
            btnExit.Click += btnExit_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(164, 256);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(191, 29);
            tbUsername.TabIndex = 31;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(164, 179);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(191, 29);
            tbEmail.TabIndex = 30;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(164, 107);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(191, 29);
            tbAddress.TabIndex = 29;
            // 
            // tbFirstname
            // 
            tbFirstname.Location = new Point(164, 39);
            tbFirstname.Name = "tbFirstname";
            tbFirstname.Size = new Size(191, 29);
            tbFirstname.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(398, 259);
            label8.Name = "label8";
            label8.Size = new Size(90, 22);
            label8.TabIndex = 27;
            label8.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 259);
            label7.Name = "label7";
            label7.Size = new Size(102, 22);
            label7.TabIndex = 26;
            label7.Text = "User Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 184);
            label6.Name = "label6";
            label6.Size = new Size(136, 22);
            label6.TabIndex = 25;
            label6.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 113);
            label5.Name = "label5";
            label5.Size = new Size(71, 22);
            label5.TabIndex = 24;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 184);
            label4.Name = "label4";
            label4.Size = new Size(58, 22);
            label4.TabIndex = 23;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 113);
            label3.Name = "label3";
            label3.Size = new Size(76, 22);
            label3.TabIndex = 22;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 42);
            label2.Name = "label2";
            label2.Size = new Size(100, 22);
            label2.TabIndex = 21;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 42);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 20;
            label1.Text = "First Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(btnRegister);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(540, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 396);
            panel1.TabIndex = 40;
            // 
            // btnRegister
            // 
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(86, 337);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 30);
            btnRegister.TabIndex = 45;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(470, 337);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 30);
            btnClear.TabIndex = 47;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.BackColor = Color.CornflowerBlue;
            cbShowPassword.Location = new Point(542, 284);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(168, 26);
            cbShowPassword.TabIndex = 46;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = false;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(542, 108);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(196, 30);
            cmbGender.TabIndex = 44;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(542, 251);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(196, 29);
            tbPassword.TabIndex = 43;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbPhoneNo
            // 
            tbPhoneNo.Location = new Point(542, 176);
            tbPhoneNo.Name = "tbPhoneNo";
            tbPhoneNo.Size = new Size(196, 29);
            tbPhoneNo.TabIndex = 42;
            // 
            // tbLastname
            // 
            tbLastname.Location = new Point(542, 37);
            tbLastname.Name = "tbLastname";
            tbLastname.Size = new Size(196, 29);
            tbLastname.TabIndex = 41;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 396);
            Controls.Add(btnClear);
            Controls.Add(cbShowPassword);
            Controls.Add(cmbGender);
            Controls.Add(tbPassword);
            Controls.Add(tbPhoneNo);
            Controls.Add(tbLastname);
            Controls.Add(btnExit);
            Controls.Add(tbUsername);
            Controls.Add(tbEmail);
            Controls.Add(tbAddress);
            Controls.Add(tbFirstname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("ABeeZee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MetroSet_UI.Controls.MetroSetButton btnExit;
        private TextBox tbUsername;
        private TextBox tbEmail;
        private TextBox tbAddress;
        private TextBox tbFirstname;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btnClear;
        private Button btnRegister;
        private CheckBox cbShowPassword;
        private ComboBox cmbGender;
        private TextBox tbPassword;
        private TextBox tbPhoneNo;
        private TextBox tbLastname;
    }
}