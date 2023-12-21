namespace FrontendWin
{
    partial class UpdateForm
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
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbFirstname = new TextBox();
            tbAddress = new TextBox();
            btnExit = new Button();
            btnUpdate = new Button();
            tbLastname = new TextBox();
            tbPhoneNo = new TextBox();
            btnClear = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 150);
            label6.Name = "label6";
            label6.Size = new Size(132, 25);
            label6.TabIndex = 31;
            label6.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 150);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 28;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 42);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 27;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 42);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 26;
            label1.Text = "First Name";
            // 
            // tbFirstname
            // 
            tbFirstname.Location = new Point(164, 39);
            tbFirstname.Name = "tbFirstname";
            tbFirstname.Size = new Size(191, 31);
            tbFirstname.TabIndex = 32;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(164, 147);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(191, 31);
            tbAddress.TabIndex = 32;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(56, 308);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 33;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(619, 308);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // tbLastname
            // 
            tbLastname.Location = new Point(540, 42);
            tbLastname.Name = "tbLastname";
            tbLastname.Size = new Size(191, 31);
            tbLastname.TabIndex = 35;
            // 
            // tbPhoneNo
            // 
            tbPhoneNo.Location = new Point(540, 147);
            tbPhoneNo.Name = "tbPhoneNo";
            tbPhoneNo.Size = new Size(191, 31);
            tbPhoneNo.TabIndex = 36;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(480, 308);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 37;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(195, 308);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 34);
            btnReturn.TabIndex = 38;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 396);
            Controls.Add(btnReturn);
            Controls.Add(btnClear);
            Controls.Add(tbPhoneNo);
            Controls.Add(tbLastname);
            Controls.Add(btnUpdate);
            Controls.Add(btnExit);
            Controls.Add(tbAddress);
            Controls.Add(tbFirstname);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateForm";
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbFirstname;
        private TextBox tbAddress;
        private Button btnExit;
        private Button btnUpdate;
        private TextBox tbLastname;
        private TextBox tbPhoneNo;
        private Button btnClear;
        private Button btnReturn;
    }
}