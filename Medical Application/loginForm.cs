using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectDatabase;
using MySql.Data.MySqlClient;

namespace Medical_Application
{
    public partial class loginForm : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;

        // Relevant variables
        public static string user;
        public static string userRole;
        public loginForm()
        {
            InitializeComponent();
            con.Connect();
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
 
        // Login Logic
        private void loginButton_Click(object sender, EventArgs e)
        {
            user = userField.Text;

            con.cn.Open();
            cmd = new MySqlCommand("SELECT COUNT(*), role from staff INNER JOIN auth ON idstaff = auth_idstaff WHERE idstaff ='"+ userField.Text +"' AND password ='"+ passField.Text +"'", con.cn);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    userRole = reader["role"].ToString();
                }
            }

            Console.WriteLine(userRole);

            if (dt.Rows[0][0].ToString() == "1")
            {
                NewTab(new indexForm());
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                Console.WriteLine("Login Failed");
            }
            
            con.cn.Close();
        }

        public void ShowTab(Form input)
        {
            input.Show();
        }

        public void NewTab(Form input)
        {

            this.Hide();
            input.Closed += (s, args) => this.Close();
            input.Show();
        }
    }
}
