using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ConnectDatabase;
using MySql.Data.MySqlClient;

namespace Medical_Application
{
    public partial class addDiagForm : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand cmd;

        //Variables
        public string idDiag;
        public string selectedAppoint;
        public string diagDetail;
        public string idPrescription;
        public string medication;
        public addDiagForm()
        {
            InitializeComponent();
            con.Connect();

            con.cn.Open();
            cmd = new MySqlCommand("SELECT idappointment, datetime FROM appointment LEFT JOIN diagnosis ON idappointment = diagnosis_idappointment WHERE iddiagnosis IS NULL AND appointment_idpatient ="+indexForm.ID, con.cn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    ListItem appointment = new ListItem();
                    appointment.Text = reader["datetime"].ToString();
                    appointment.Value = reader["idappointment"].ToString();
                    appointComboBox.Items.Add(new ListItem { Text = appointment.Text, Value = appointment.Value});
                }
            }

            con.cn.Close();
        }

        private void appointComboBox_SelectIndexChanged(object sender, EventArgs e)
        {
            selectedAppoint = ((ListItem)appointComboBox.SelectedItem).Value;
            Console.WriteLine(selectedAppoint);
        }

        private void addDiagnosis_Load(object sender, EventArgs e)
        {
            this.Text = "Add Entry for "+indexForm.ID;
        }

        private void entrySubmitButton_Click(object sender, EventArgs e)
        {
            idDiag = RandInt(4);
            diagDetail = diagDetailTextBox.Text;
            idPrescription = RandInt(4);
            medication = prescriptionTextBox.Text;

            if (diagDetail != "" && medication != "" && selectedAppoint != "")
            {
                con.cn.Open();
                cmd = new MySqlCommand("" +
                    "INSERT INTO diagnosis (iddiagnosis,diagnosisdetail,diagnosis_idappointment)" +
                    "VALUES (" + Int32.Parse(idDiag) + ",'" + diagDetail + "'," + Int32.Parse(selectedAppoint) + ");" +
                    "INSERT INTO prescription (idprescription,medication,prescription_iddiagnosis)" +
                    "VALUES (" + Int32.Parse(idPrescription) + ",'" + medication + "'," + Int32.Parse(idDiag) + ");", con.cn);
                cmd.ExecuteNonQuery();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.");
            } 
        }

        static string RandInt(int n)
        {
            int[] arrayID = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int num = rnd.Next(1, 10);
                arrayID[i] += num;
            }

            var builder = new StringBuilder();
            Array.ForEach(arrayID, x => builder.Append(x));
            string ID = builder.ToString();
            return ID;
        }
    }
}
