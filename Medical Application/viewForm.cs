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
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;
using Mysqlx.Crud;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

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

                    string idDiagnosis = reader["iddiagnosis"].ToString();

                    ListItem diagnosis = new ListItem();
                    diagnosis.Text = patientDiagnosis;
                    diagnosis.Value = idDiagnosis;
                    diagnosisListBox.Items.Add(new ListItem { Text = diagnosis.Text, Value = diagnosis.Value });
                }
            }
            con.cn.Close();

            // Add SQL query here for filling out 'presciptionListBox' with diagnosis ID from the 'diagnosisListBox'

            con.cn.Open();
            cmd = new MySqlCommand("SELECT `role`,`lname`,`datetime`,`idappointment` FROM `appointment` LEFT JOIN `staff` ON `appointment_idstaff` = `idstaff` LEFT JOIN `diagnosis` ON `idappointment` = `diagnosis_idappointment` WHERE `iddiagnosis` IS NULL AND `appointment_idpatient` = "+indexForm.ID+" ORDER BY datetime DESC; ", con.cn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListItem patientAppointment = new ListItem();
                    patientAppointment.Text = string.Format("Appointment @ {0} with {1} {2}", reader["datetime"], reader["role"], reader["lname"]);
                    patientAppointment.Value = reader["idappointment"].ToString();

                    appointmentListBox.Items.Add(new ListItem { Text = patientAppointment.Text, Value = patientAppointment.Value });
                }
            }
            con.cn.Close();

            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "yyyy-MM-dd";

            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.CustomFormat = "hh:mm:ss";

        }

        private void diagnosisListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIdDiag = ((ListItem)diagnosisListBox.SelectedItem).Value;
            Console.WriteLine(selectedIdDiag);
            prescriptionListBox.Items.Clear();

            con.cn.Open();
            cmd = new MySqlCommand("SELECT `medication` from `prescription` RIGHT JOIN `diagnosis` ON `prescription_iddiagnosis` = `iddiagnosis` RIGHT JOIN `appointment` ON `diagnosis_idappointment` = `idappointment` RIGHT JOIN `patient` ON `appointment_idpatient` = `idpatient` WHERE `idpatient` = " + indexForm.ID + " AND `iddiagnosis` = " + selectedIdDiag, con.cn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string diagMedication = reader["medication"].ToString();

                    prescriptionListBox.Items.Add(diagMedication);
                }
            }

            con.cn.Close();
        }

        private void viewForm_Load(object sender, EventArgs e)
        {
            this.Text = indexForm.ID;
            patientidLabel.Text = indexForm.ID;

            con.cn.Open();
            cmd = new MySqlCommand("SELECT fname, lname FROM patient WHERE idpatient = "+ indexForm.ID, con.cn);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    patientnameLabel.Text = string.Format("{0} {1}", reader["fname"], reader["lname"]);
                }
            }

            con.cn.Close();
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
            for (int i = 0; i < 4; i++)
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

            this.appointmentListBox.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Close();
            new viewForm().Show();
        }

        public string selectedAppoint;

        private void appointmentListBox_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var index = this.appointmentListBox.IndexFromPoint(e.Location);
                if (index >= 0)
                {
                    appointmentListBox.SelectedIndex = index;
                    selectedAppoint = ((ListItem)appointmentListBox.Items[index]).Value;
                    Console.WriteLine(selectedAppoint);
                }
            }

        }
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.cn.Open();
            cmd = new MySqlCommand("DELETE FROM `appointment` WHERE `appointment`.`idappointment` = "+selectedAppoint, con.cn);
            cmd.ExecuteNonQuery();
            con.cn.Close();

            this.appointmentListBox.Refresh();
        }
    }
}
