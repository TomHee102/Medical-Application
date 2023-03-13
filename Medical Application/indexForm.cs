using ConnectDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.Versioning;
using Google.Protobuf.WellKnownTypes;

namespace Medical_Application
{
    public partial class indexForm : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;

        //Relevant Variables
        public static string ID;
        public indexForm()
        {
            InitializeComponent();
            con.Connect();

            // Data Initialisation + Label Assignment
            userIdLabel.Text = loginForm.user;
            this.Text = loginForm.user;

            con.cn.Open();
            cmd = new MySqlCommand("SELECT role, lname FROM staff WHERE idstaff = "+ loginForm.user, con.cn);
            MySqlDataReader full = cmd.ExecuteReader();

            while (full.Read())
            {
                nameLabel.Text = full.GetValue(0).ToString();
                nameLabel.Text += " ";
                nameLabel.Text += full.GetValue(1).ToString();
            }
            con.cn.Close();           

            con.cn.Open();
            cmd = new MySqlCommand("Select * from patient", con.cn);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            indexGridView.DataSource = dt.DefaultView;
            con.cn.Close();
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            userIdLabel.Text = loginForm.user;
            con.cn.Open();
            cmd = new MySqlCommand("Select * from patient", con.cn);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            indexGridView.DataSource = dt.DefaultView;
            con.cn.Close();
        }
        private void tempviewButton_Click(object sender, EventArgs e)
        {
            if (indexGridView.SelectedRows.Count > 0)
            {
                ID = StoreSelectedRow();
                ShowTab(new viewForm());
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }

        }
        private void newpButton_Click(object sender, EventArgs e)
        {
            ShowTab(new newpForm());
        }
        public void ShowTab(Form input)
        {
            input.Show();
        }
        private string StoreSelectedRow()
        {
            if(indexGridView.SelectedRows.Count > 0)
            {
                int rowIndex = indexGridView.SelectedRows[0].Index;
                
                string idColumn = indexGridView.Rows[rowIndex].Cells[0].Value.ToString();

                var rowData = (idColumn);

                return rowData;
            }
            else
            {
                return "null";
            }
        }
    }
}
