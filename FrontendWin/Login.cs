using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace FrontendWin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string ComputeMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=PIRUNTHAPAN-P14;Initial Catalog=Login;User ID=sa;Password=sa@123";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string enteredUsername = tbUsername.Text;
                string enteredPassword = tbPassword.Text;

                try
                {
                    connection.Open();

                    string query = "SELECT Password FROM Login WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", enteredUsername);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string storedHashedPassword = result.ToString();
                            string enteredHashedPassword = ComputeMD5Hash(enteredPassword);

                            if (enteredHashedPassword == storedHashedPassword)
                            {
                                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Menuform form2 = new Menuform(enteredUsername);
                                form2.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tbPassword.Clear();
                                tbPassword.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbUsername.Clear();
                            tbPassword.Clear();
                            tbUsername.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();

            tbUsername.Focus();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register form3 = new Register();
            form3.Show();
            this.Hide();
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
    }
}
