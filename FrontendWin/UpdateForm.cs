using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrontendWin
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any of the required textboxes are empty
            if (string.IsNullOrWhiteSpace(tbFirstname.Text) ||
                string.IsNullOrWhiteSpace(tbLastname.Text) ||
                string.IsNullOrWhiteSpace(tbAddress.Text) ||
                string.IsNullOrWhiteSpace(tbPhoneNo.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=PIRUNTHAPAN-P14;Initial Catalog=Login;User ID=sa;Password=sa@123";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Update SQL command with parameters
                    string query = "UPDATE Login SET Firstname = @Firstname, Lastname = @Lastname, Address = @Address, PhoneNo = @PhoneNo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@Firstname", tbFirstname.Text);
                        cmd.Parameters.AddWithValue("@Lastname", tbLastname.Text);
                        cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
                        cmd.Parameters.AddWithValue("@PhoneNo", tbPhoneNo.Text);

                        // Execute query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please check the provided username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstname.Clear();
            tbLastname.Clear();
            tbAddress.Clear();
            tbPhoneNo.Clear();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
