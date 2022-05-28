using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateVehicleRent cvr = new CalculateVehicleRent();
            cvr.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateDayTourHire cdth = new CalculateDayTourHire();
            cdth.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculateLongTourHire clth = new CalculateLongTourHire();
            clth.Visible = true;
            this.Hide();
        }
    }
}
