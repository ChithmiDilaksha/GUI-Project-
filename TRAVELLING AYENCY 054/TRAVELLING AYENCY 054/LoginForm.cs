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

namespace TRAVELLING_AYENCY_054
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-IE4CHR0;Initial Catalog=Travelling_Agency;Integrated Security=True");


        private void Login_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP - IE4CHR0; Initial Catalog = Travelling_Agency; Integrated Security = True"));
                {
                    string query = "SELECT COUNT(*) FROM Register WHERE Username=@Username AND Passwords=@Password";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        try
                        {
                            sqlConnection.Open();
                            int count = (int)cmd.ExecuteScalar();

                            if (count == 1)
                            {
                                MessageBox.Show("Login Successful");

                                // Redirect to the home page or another form
                                FormHomePage homePageForm = new FormHomePage();
                                homePageForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Error: Invalid username or password", "Error!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
            }


            else
            {
                MessageBox.Show("Please fill in the blanks");
            }
        }

        private void buttonCancels_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
        }
    }
}
