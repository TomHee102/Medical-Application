using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectDatabase;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Medical_Application
{
    public partial class newpForm : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand cmd;
        public newpForm()
        {
            InitializeComponent();
            con.Connect();
        }

        private void inpatientField_CheckedChanged(object sender, EventArgs e)
        {
            if (inpatientField.Checked)
            {
                wardLabel.Visible = true;
                wardField.Visible = true;
            }
            else
            {
                wardLabel.Visible = false;
                wardField.Visible = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Talk about lack of security in LSEPI by using Random() and the fact that it is seeded.
            // While unlikely, need to check that ID is unique on generation.
            int[] arrayID = new int[8];
            arrayID[0] = 2;
            Random rnd = new Random();
            for (int i = 1; i <= 7; i++)
            {
                int num = rnd.Next(0, 10);
                arrayID[i] += num;
            }

            var builder = new StringBuilder();
            Array.ForEach(arrayID, x => builder.Append(x));
            string idpatient = builder.ToString();

            string fname = fnameField.Text;
            string lname = lnameField.Text;
            string address = addressField.Text;
            int inpatient = 0;
            string ward = wardField.Text;
            if (inpatientField.Checked == true)
            {
                inpatient = 1;
            }
            else if (inpatientField.Checked == false)
            {
                ward = "0";
            }

            if(fname != "" && lname != "" && address != "")
            {
                con.cn.Open();
                cmd = new MySqlCommand("INSERT INTO patient (idpatient, fname, lname, address, inpatient, ward) " +
                    "VALUES ('" + idpatient + "','" + fname + "', '" + lname + "', '" + address + "', " + inpatient + ", " + ward + ")", con.cn);
                cmd.ExecuteNonQuery();
                con.cn.Close();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.");
            }
            
        }

        private void newpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
