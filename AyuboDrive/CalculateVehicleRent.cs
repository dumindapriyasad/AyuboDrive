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

namespace AyuboDrive
{
    public partial class CalculateVehicleRent : Form
    {
        public CalculateVehicleRent()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DUMINDA-PC;Initial Catalog=AyuboDrive;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select VehicleNo from VehicleDetails";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            vehicleNoCombo.Items.Add("-Select-");

            foreach (DataRow dr in dt.Rows) {
                vehicleNoCombo.Items.Add(dr["VehicleNo"].ToString());
            }

            con.Close();
            vehicleNoCombo.SelectedIndex = 0;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {

            if (vehicleNoCombo.SelectedIndex != 0) {

                if (!(returnDateDTpicker.Value <= rentedDateDTpicker.Value)) {

                    string vehicleNo = vehicleNoCombo.SelectedItem.ToString();
                    DateTime rentedDate = rentedDateDTpicker.Value;
                    DateTime returnDate = returnDateDTpicker.Value;
                    bool withDriver = false;

                    if (withDriverCheck.Checked == true) {
                        withDriver = true;
                    }

                    Operations op = new Operations();
                    totalRentLbl.Text = "Total Rent = " + Convert.ToString(op.calculateVehicleRent(vehicleNo, rentedDate, returnDate, withDriver));
                }

                else {
                    MessageBox.Show("Please enter correct date range!");
                }
            }

            else {
                MessageBox.Show("Please enter all values!");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            vehicleNoCombo.SelectedIndex = 0;
            rentedDateDTpicker.Value = DateTime.Now;
            returnDateDTpicker.Value = DateTime.Now;
            withDriverCheck.Checked = false;
            totalRentLbl.Text = "Total Rent";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Visible = true;
            this.Close();
        }
    }
}
