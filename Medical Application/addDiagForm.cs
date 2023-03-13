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
using MySql.Data.MySqlClient;

namespace Medical_Application
{
    public partial class addDiagForm : Form
    {
        myDBConnection con = new myDBConnection();
        MySqlCommand cmd;
        public addDiagForm()
        {
            InitializeComponent();
            con.Connect();
        }

        private void addDiagnosis_Load(object sender, EventArgs e)
        {
            this.Text = "Add Entry for "+indexForm.ID;
        }

        private void entrySubmitButton_Click(object sender, EventArgs e)
        {
            int[] arrayID = new int[4];
            Random rnd = new Random();
            for (int i = 0; i <= 4; i++)
            {
                int num = rnd.Next(0, 10);
                arrayID[i] += num;
            }

            var builder = new StringBuilder();
            Array.ForEach(arrayID, x => builder.Append(x));
            string iddiagnosis = builder.ToString();

            string diagnosisdetail = diagDetailTextBox.Text;
            string medication = prescriptionTextBox.Text;

        }
    }
}
