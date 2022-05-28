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
using System.Text.RegularExpressions;

namespace AyuboDrive
{
    public partial class CalculateLongTourHire : Form
    {
        public CalculateLongTourHire()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection("Data Source=DUMINDA-PC;Initial Catalog=AyuboDrive;Integrated Security=True");
            con.Open();

            SqlCommand cmd1 = new SqlCommand("select VehicleNo from VehicleDetails", con);
            cmd1.ExecuteNonQuery();

            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            sda1.Fill(dt1);

            vehicleNoCombo.Items.Add("-Select-");

            foreach (DataRow dr in dt1.Rows)
            {
                vehicleNoCombo.Items.Add(dr["VehicleNo"].ToString());
            }

            vehicleNoCombo.SelectedIndex = 0;

            SqlCommand cmd2 = new SqlCommand("select PackageType from LongTourPackageTypes", con);
            cmd2.ExecuteNonQuery();

            DataTable dt2 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            sda2.Fill(dt2);

            pkgTypeCombo.Items.Add("-Select-");

            foreach (DataRow dr in dt2.Rows)
            {
                pkgTypeCombo.Items.Add(dr["PackageType"].ToString());
            }

            pkgTypeCombo.SelectedIndex = 0;
            con.Close();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {

            if (vehicleNoCombo.SelectedIndex != 0 && pkgTypeCombo.SelectedIndex != 0 && startKMtxt.Text.Trim() != "" && endKMtxt.Text.Trim() != "") {

                if (Regex.IsMatch(startKMtxt.Text, "^[0-9]+$") == true && Regex.IsMatch(endKMtxt.Text, "^[0-9]+$") == true) {

                    bool errors = false;

                    if (endDateDTPicker.Value <= startDateDTPicker.Value) {
                        errors = true;
                        MessageBox.Show("Please enter correct date range!");
                    }

                    if (Convert.ToInt32(endKMtxt.Text) <= Convert.ToInt32(startKMtxt.Text)) {
                        errors = true;
                        MessageBox.Show("Please enter correct kilometer range!");
                    }

                    if (errors == false) {

                        string vehicleNo = vehicleNoCombo.SelectedItem.ToString();
                        string pkgType = pkgTypeCombo.SelectedItem.ToString();
                        DateTime startDate = startDateDTPicker.Value;
                        DateTime endDate = endDateDTPicker.Value;
                        int startKMreading = Convert.ToInt32(startKMtxt.Text);
                        int endKMreading = Convert.ToInt32(endKMtxt.Text);

                        Operations op = new Operations();
                        baseHireChargeLbl.Text = "Base Hire Charge = " + Convert.ToString(op.calculateLongTourHire(vehicleNo, pkgType, startDate, endDate, startKMreading, endKMreading)[0]);
                        overnightStayChargeLbl.Text = "Overnight Stay Charge = " + Convert.ToString(op.calculateLongTourHire(vehicleNo, pkgType, startDate, endDate, startKMreading, endKMreading)[1]);
                        extraKMchargeLbl.Text = "Extra KM Charge = " + Convert.ToString(op.calculateLongTourHire(vehicleNo, pkgType, startDate, endDate, startKMreading, endKMreading)[2]);
                        totalHireValueLbl.Text = "Total Hire Value = " + Convert.ToString(op.calculateLongTourHire(vehicleNo, pkgType, startDate, endDate, startKMreading, endKMreading)[3]);
                    }
                }

                else
                {
                    MessageBox.Show("Please enter valid KM Reading values!");
                }
            }

            else
            {
                MessageBox.Show("Please enter all values!");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            vehicleNoCombo.SelectedIndex = 0;
            pkgTypeCombo.SelectedIndex = 0;
            startDateDTPicker.Value = DateTime.Now;
            endDateDTPicker.Value = DateTime.Now;
            startKMtxt.ResetText();
            endKMtxt.ResetText();
            baseHireChargeLbl.Text = "Base Hire Charge";
            overnightStayChargeLbl.Text = "Overnight Stay Charge";
            extraKMchargeLbl.Text = "Extra KM Charge";
            totalHireValueLbl.Text = "Total Hire Value";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Visible = true;
            this.Close();
        }
    }
}
