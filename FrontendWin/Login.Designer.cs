namespace FrontendWin
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            label1 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnClear = new Button();
            btnRegister = new Button();
            cbShowPassword = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("ABeeZee", 9F);
            btnLogin.Location = new Point(613, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("ABeeZee", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 27);
            label1.Name = "label1";
            label1.Size = new Size(103, 37);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbUsername.Location = new Point(450, 119);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(284, 31);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(450, 187);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(284, 31);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("ABeeZee", 9F);
            btnClear.Location = new Point(450, 271);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("ABeeZee", 9F);
            btnRegister.Location = new Point(568, 329);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(450, 224);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(162, 29);
            cbShowPassword.TabIndex = 9;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("ABeeZee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(462, 335);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 11;
            label4.Text = "Not A User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("ABeeZee", 10F);
            label5.Location = new Point(333, 123);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 12;
            label5.Text = "UserName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("ABeeZee", 10F);
            label6.Location = new Point(333, 189);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 13;
            label6.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("ABeeZee", 9F);
            btnExit.Location = new Point(40, 404);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(92, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbShowPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnClear);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnClear;
        private Button btnRegister;
        private CheckBox cbShowPassword;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Button btnExit;
    }
}
