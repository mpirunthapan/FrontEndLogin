using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using FrontendWin;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

namespace FrontendWin
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private string ComputeMD5Hash(string input)
        {
            using System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            {
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                //Convert the byte array to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=PIRUNTHAPAN-P14;Initial Catalog=Login;User ID=sa;Password=sa@123";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //Create SQL command with parameters
                    string querry = "INSERT INTO Login (Firstname, Lastname, Address, Gender, Email, PhoneNo, Username, Password)" +
                                    "VALUES (@Firstname, @Lastname, @Address, @Gender, @Email, @PhoneNo, @Username, @Password)";

                    using (SqlCommand cmd = new SqlCommand(querry, conn))
                    {

                        //Set parameter values
                        cmd.Parameters.AddWithValue("@Firstname", tbFirstname.Text);
                        cmd.Parameters.AddWithValue("@Lastname", tbLastname.Text);
                        cmd.Parameters.AddWithValue("@Address", tbAddress.Text);

                        //Validate email
                        if (!IsEmailValid(tbEmail.Text))
                        {
                            MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        cmd.Parameters.AddWithValue("@Gender", value: cmbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                        cmd.Parameters.AddWithValue("@PhoneNo", tbPhoneNo.Text);
                        cmd.Parameters.AddWithValue("@Username", tbUsername.Text);

                        //Validate password
                        if (!IsPasswordValid(tbPassword.Text))
                        {
                            MessageBox.Show("Password does not meet the requirements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        //Hash the password using MD5
                        string hashedpassword = ComputeMD5Hash(tbPassword.Text);
                        cmd.Parameters.AddWithValue("@Password", hashedpassword);

                        //Execute query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login form4 = new Login();
                            form4.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connectionString.Clone();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstname.Clear();
            tbLastname.Clear();
            tbAddress.Clear();
            cmbGender.Text = "";
            tbEmail.Clear();
            tbPhoneNo.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
        }

        private bool IsPasswordValid(string password)
        {
            //Check minimum length
            if (password.Length < 8)
                return false;

            //Check for upper case letter
            if (!password.Any(char.IsUpper))
                return false;

            //Check for lower case letter
            if (!password.Any(char.IsLower))
                return false;

            //Check for number
            if (!password.Any(char.IsDigit))
                return false;

            //Check for special character
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            return true;
        }

        private bool IsEmailValid(string email)
        {
            // Use a regular expression for basic email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }

}

