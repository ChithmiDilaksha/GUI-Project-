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
    public partial class FormHotel : Form
    {
        public FormHotel()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormHotel_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxEmail.Text) && comboBoxPriceRange.SelectedItem != null && comboBox1Hotel.SelectedItem != null && !string.IsNullOrEmpty(textBoxDays.Text) )
                {
                    string connstring = @"Data Source=DESKTOP-IE4CHR0;Initial Catalog=Travelling_Agency;Integrated Security=True;";
                    using (SqlConnection connectionOBJ = new SqlConnection(connstring))
                    {
                        connectionOBJ.Open();

                        string checkHotelQuery = "SELECT COUNT(*) FROM Hotels WHERE HotelName = @HotelName";
                        SqlCommand checkHotelCmd = new SqlCommand(checkHotelQuery, connectionOBJ);
                        checkHotelCmd.Parameters.AddWithValue("@HotelName", comboBox1Hotel.SelectedItem.ToString());
                        int hotelCount = (int)checkHotelCmd.ExecuteScalar();

                        if (hotelCount > 0)
                        {
                            MessageBox.Show("Hotel already exists. Please choose a different hotel name.");
                            return;
                        }

                        string sql = @"INSERT INTO Hotels (HotelName, Locations, HowMantDays, PriceRange, HowManyRooms, RoomType, HowManyBeds, BedsType, Email) 
               VALUES (@HotelName, @Locations, @HowManyDays, @PriceRange, @HowManyRooms, @RoomType, @HowManyBeds, @BedsType, @Email)";

                        using (SqlCommand command = new SqlCommand(sql, connectionOBJ))
                        {
                            command.Parameters.AddWithValue("@HotelName", comboBox1Hotel.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Locations", comboBoxLocation.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@HowManyDays", Convert.ToInt32(textBoxDays.Text));
                            command.Parameters.AddWithValue("@PriceRange", comboBoxPriceRange.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@HowManyRooms", textBoxHMRooms.Text); // Add number of rooms
                            command.Parameters.AddWithValue("@RoomType",comboBoxRoomType.SelectedIndex.ToString()); // Add room type
                            command.Parameters.AddWithValue("@HowManyBeds", textBoxHMBeds.Text); // Add number of beds
                            command.Parameters.AddWithValue("@BedsType", comboBoxBedType.SelectedIndex.ToString()); // Add bed type
                            command.Parameters.AddWithValue("@Email", textBoxEmail.Text);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Hotel registration successful.");

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
    }
}
