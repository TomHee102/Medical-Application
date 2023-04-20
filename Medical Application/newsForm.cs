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
    public partial class newsForm : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand cmd;
        public newsForm()
        {
            InitializeComponent();
            con.Connect();
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            int[] arrayID = new int[8];
            arrayID[0] = 1;
            Random rnd = new Random();
            for (int i = 1; i <= 7; i++)
            {
                int num = rnd.Next(0, 10);
                arrayID[i] += num;
            }

            var builder = new StringBuilder();
            Array.ForEach(arrayID, x => builder.Append(x));
            string idstaff = builder.ToString();

            string fname = fnameField.Text;
            string lname = lnameField.Text;
            string pass = passField.Text;
            string role = roleComboBox.Text;

            if (fname != "" && lname != "" && pass != "" && role != "")
            {
                con.cn.Open();
                cmd = new MySqlCommand("INSERT INTO staff (idstaff, fname, lname, role) " +
                    "VALUES (" + Int32.Parse(idstaff) + ",'" + fname + "', '" + lname + "', '" + role + "');" +
                    "INSERT INTO auth (auth_idstaff, password) " +
                    "VALUES ("+ Int32.Parse(idstaff) +",'"+ pass +"');", con.cn);
                cmd.ExecuteNonQuery();
                con.cn.Close();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.");
            }
        }
    }
}
