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
    public partial class TourForm : Form
    {
        public TourForm()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxeMAIL.Text) && comboBox1TName.SelectedItem != null && comboBoxDestination.SelectedItem != null && !string.IsNullOrEmpty(textBoxMmbers.Text) && !string.IsNullOrEmpty(textBoxDays.Text) && dateTimePicker1.Value != null)
                {
                    string connstring = @"Data Source=DESKTOP-IE4CHR0;Initial Catalog=Travelling_Agency;Integrated Security=True;";
                    using (SqlConnection connectionOBJ = new SqlConnection(connstring))
                    {
                        connectionOBJ.Open();

                        string checkTourQuery = "SELECT COUNT(*) FROM Tours WHERE tour_name = @tour_name";
                        SqlCommand checkTourCmd = new SqlCommand(checkTourQuery, connectionOBJ);
                        checkTourCmd.Parameters.AddWithValue("@tour_name", comboBox1TName.SelectedItem);
                        int tourCount = (int)checkTourCmd.ExecuteScalar();

                        if (tourCount > 0)
                        {
                            MessageBox.Show("Tour already exists. Please choose a different tour name.");
                            return;
                        }

                        string sql = @"INSERT INTO Tours (tour_name, tour_destination, HowMantDays, StartDate, agent_name, agent_gender, Members, Email) 
                           VALUES (@tour_name, @Destination, @HowManyDays, GETDATE(), @AgentName, @AgentGender, @Members, @Email)";

                        using (SqlCommand command = new SqlCommand(sql, connectionOBJ))
                        {
                            command.Parameters.AddWithValue("@tour_name", comboBox1TName.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Destination", comboBoxDestination.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@HowManyDays", Convert.ToInt32(textBoxDays.Text));
                            command.Parameters.AddWithValue("@AgentName", comboBoxAgentName.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@AgentGender", comboBoxGender.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Members", Convert.ToInt32(textBoxMmbers.Text));
                            command.Parameters.AddWithValue("@Email", textBoxeMAIL.Text);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Tour registration successful.");

                            FormHomePage formHomePage = new FormHomePage();
                            formHomePage.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all values.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private void buttonCancels_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHomePage formHomePage = new FormHomePage();
            formHomePage.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
