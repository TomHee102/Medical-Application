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
using ConnectDatabase;

namespace Medical_Application
{
    public partial class viewForm : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand cmd;
        public viewForm()
        {
            InitializeComponent();
            con.Connect();

            con.cn.Open();
            cmd = new MySqlCommand("SELECT iddiagnosis,role,staff.lname,datetime,diagnosisdetail FROM diagnosis INNER JOIN appointment ON diagnosis_idappointment = idappointment INNER JOIN staff ON appointment_idstaff = idstaff INNER JOIN patient ON appointment_idpatient = idpatient WHERE idpatient = "+indexForm.ID, con.cn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string patientDiagnosis = string.Format("{0} {1} - {2}: {3}", reader["role"], reader["lname"], reader["datetime"], reader["diagnosisdetail"]);

                    var iddiagnosis = reader["iddiagnosis"];

                    diagnosisListBox.Items.Add(patientDiagnosis);
                }
            }
            con.cn.Close();

            con.cn.Open();
            cmd = new MySqlCommand("SELECT role,staff.lname,datetime FROM appointment INNER JOIN staff ON appointment_idstaff = idstaff WHERE appointment_idpatient = "+indexForm.ID+" ORDER BY datetime DESC", con.cn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string patientAppointment = string.Format("Appointment @ {0} with {1} {2}", reader["datetime"], reader["role"], reader["lname"]);


                    appointmentListBox.Items.Add(patientAppointment);
                }
            }
            con.cn.Close();

            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "yyyy-MM-dd";

            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.CustomFormat = "hh:mm:ss";

        }

        private void viewForm_Load(object sender, EventArgs e)
        {
            patientidLabel.Text = indexForm.ID;
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            ShowTab(new addDiagForm());
        }
        public void ShowTab(Form input)
        {
            input.Show();
        }

        private void appointmentSubmit_Click(object sender, EventArgs e)
        {
            int[] arrayID = new int[4];
            Random rnd = new Random();
            for (int i = 0; i <= 3; i++)
            {
                int num = rnd.Next(0, 10);
                arrayID[i] += num;
            }

            var builder = new StringBuilder();
            Array.ForEach(arrayID, x => builder.Append(x));
            string idappointment = builder.ToString();

            string datetime = datePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");

            Console.WriteLine(datetime);

            con.cn.Open();
            cmd = new MySqlCommand("INSERT INTO appointment (idappointment, datetime, appointment_idpatient, appointment_idstaff) " +
                "VALUES ('"+idappointment+"','"+datetime+"','"+indexForm.ID+"','"+loginForm.user+"')", con.cn);
            cmd.ExecuteNonQuery();
            con.cn.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new viewForm().Show();
        }
    }
}
