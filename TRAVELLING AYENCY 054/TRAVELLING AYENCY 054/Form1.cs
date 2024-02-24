using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAVELLING_AYENCY_054
{
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm= new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
        }

        private void buttonHotel_Click(object sender, EventArgs e)
        {
            FormHotel formHotel = new FormHotel();
            formHotel.Show();
            this.Hide();
        }

        private void buttonTour_Click(object sender, EventArgs e)
        {
            TourForm tourForm = new TourForm();
            tourForm.Show();
            this.Hide();
        }

    }
}
