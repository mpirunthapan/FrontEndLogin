using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontendWin
{
    public partial class Menuform : Form
    {
        private readonly string enteredUsername;
        public Menuform(string Username)
        {
            InitializeComponent();
            enteredUsername = Username;
        }

        private void Menuform_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=PIRUNTHAPAN-P14;Initial Catalog=Login;User ID=sa;Password=sa@123";

            string query = "SELECT Firstname, Lastname, Address, Gender, Email, PhoneNo FROM Login WHERE Username = @Username";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();

                        command.Parameters.AddWithValue("@Username", enteredUsername);

                        DataTable dataTable = new DataTable();

                        using (SqlDataAdapter adapter = new(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
