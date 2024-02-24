using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAVELLING_AYENCY_054
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonCancels_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = @"Data Source = DESKTOP-IE4CHR0; Initial Catalog = Travelling_Agency; Integrated Security= True;";
                SqlConnection connectionOBJ = new SqlConnection(connstring);
                connectionOBJ.Open();

                // Check if the user already exists
                string checkUserQuery = "SELECT COUNT(*) FROM Register WHERE Username=@Username";
                SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, connectionOBJ);
                checkUserCmd.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                int userCount = (int)checkUserCmd.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("User already exists. Please choose a different username.");
                    return;
                }

                // User does not exist, proceed with registration
                string sql = "INSERT INTO Register(Email,CustomerType,FullName,Username,Passwords,PhoneNumber,Addresses,Age,PassportNum,Nationality,VisaDetails,NIC) " +
                             "VALUES (@Email,@CustomerType,@FullName,@Username,@Passwords,@PhoneNumber,@Addresses,@Age,@PassportNum,@Nationality,@VisaDetails,@NIC)";

                using (SqlCommand CommandOBJ = new SqlCommand(sql, connectionOBJ))
                {
                    CommandOBJ.Parameters.AddWithValue("@Email", textBoxeMAIL.Text);
                    CommandOBJ.Parameters.AddWithValue("@CustomerType", comboBoxCusType.SelectedItem.ToString());
                    CommandOBJ.Parameters.AddWithValue("@FullName", textBoxNameFull.Text);
                    CommandOBJ.Parameters.AddWithValue("@Username", textBoxUsername.Text); ;
                    CommandOBJ.Parameters.AddWithValue("@PhoneNumber", textBoxPasswod.Text);
                    CommandOBJ.Parameters.AddWithValue("@Addresses", textBoxAddress.Text);
                    CommandOBJ.Parameters.AddWithValue("@Age", textBoxAge.Text);
                    CommandOBJ.Parameters.AddWithValue("@PassportNum", textBoxPassportNum.Text);
                    CommandOBJ.Parameters.AddWithValue("@VisaDetails", textBoxNationality.Text);
                    CommandOBJ.Parameters.AddWithValue("@NIC", textBoxSNIC.Text);
                    CommandOBJ.Parameters.AddWithValue("@Passwords", textBoxPasswod.Text);
                    CommandOBJ.Parameters.AddWithValue("@Nationality", textBoxNationality.Text);

                    CommandOBJ.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful");

                    // After successful registration, you may choose to redirect the user to the login form

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        

    

    private void buttonNext_Click(object sender, EventArgs e)
    { 
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        
    }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxAddress.Text = "";
            textBoxAge.Text = "";
            textBoxeMAIL.Text = "";
            textBoxNameFull.Text = "";
            textBoxNationality.Text = "";
            textBoxPassportNum.Text = "";
            textBoxPasswod.Text = "";
            textBoxPno.Text = "";
            textBoxSNIC.Text = "";
            textBoxUsername.Text = "";
            textBoxVisaDetails.Text = "";
            comboBoxCusType.SelectedIndex = 0;



        }
    }
}