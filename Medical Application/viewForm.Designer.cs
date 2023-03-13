namespace Medical_Application
{
    partial class viewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.patientidLabel = new System.Windows.Forms.Label();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.patientnameLabel = new System.Windows.Forms.Label();
            this.diagnosisListBox = new System.Windows.Forms.ListBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.appointmentListBox = new System.Windows.Forms.ListBox();
            this.appointmentSubmit = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.prescriptionListBox = new System.Windows.Forms.ListBox();
            this.appointmentLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientidLabel
            // 
            this.patientidLabel.AutoSize = true;
            this.patientidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.patientidLabel.Location = new System.Drawing.Point(12, 13);
            this.patientidLabel.Name = "patientidLabel";
            this.patientidLabel.Size = new System.Drawing.Size(126, 26);
            this.patientidLabel.TabIndex = 1;
            this.patientidLabel.Text = "<patient id>";
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(275, 53);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(75, 23);
            this.addEntryButton.TabIndex = 2;
            this.addEntryButton.Text = "Add Entry";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // patientnameLabel
            // 
            this.patientnameLabel.AutoSize = true;
            this.patientnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.patientnameLabel.Location = new System.Drawing.Point(12, 39);
            this.patientnameLabel.Name = "patientnameLabel";
            this.patientnameLabel.Size = new System.Drawing.Size(164, 26);
            this.patientnameLabel.TabIndex = 3;
            this.patientnameLabel.Text = "<patient name>";
            // 
            // diagnosisListBox
            // 
            this.diagnosisListBox.FormattingEnabled = true;
            this.diagnosisListBox.HorizontalScrollbar = true;
            this.diagnosisListBox.Location = new System.Drawing.Point(12, 82);
            this.diagnosisListBox.Name = "diagnosisListBox";
            this.diagnosisListBox.Size = new System.Drawing.Size(338, 355);
            this.diagnosisListBox.TabIndex = 4;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(357, 235);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(113, 20);
            this.datePicker.TabIndex = 5;
            this.datePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // appointmentListBox
            // 
            this.appointmentListBox.FormattingEnabled = true;
            this.appointmentListBox.HorizontalScrollbar = true;
            this.appointmentListBox.Location = new System.Drawing.Point(357, 290);
            this.appointmentListBox.Name = "appointmentListBox";
            this.appointmentListBox.Size = new System.Drawing.Size(200, 147);
            this.appointmentListBox.TabIndex = 6;
            // 
            // appointmentSubmit
            // 
            this.appointmentSubmit.Location = new System.Drawing.Point(357, 261);
            this.appointmentSubmit.Name = "appointmentSubmit";
            this.appointmentSubmit.Size = new System.Drawing.Size(75, 23);
            this.appointmentSubmit.TabIndex = 7;
            this.appointmentSubmit.Text = "submit";
            this.appointmentSubmit.UseVisualStyleBackColor = true;
            this.appointmentSubmit.Click += new System.EventHandler(this.appointmentSubmit_Click);
            // 
            // timePicker
            // 
            this.timePicker.Location = new System.Drawing.Point(476, 235);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(77, 20);
            this.timePicker.TabIndex = 8;
            this.timePicker.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // prescriptionListBox
            // 
            this.prescriptionListBox.FormattingEnabled = true;
            this.prescriptionListBox.Location = new System.Drawing.Point(357, 82);
            this.prescriptionListBox.Name = "prescriptionListBox";
            this.prescriptionListBox.Size = new System.Drawing.Size(200, 147);
            this.prescriptionListBox.TabIndex = 9;
            // 
            // appointmentLabel
            // 
            this.appointmentLabel.AutoSize = true;
            this.appointmentLabel.Location = new System.Drawing.Point(482, 266);
            this.appointmentLabel.Name = "appointmentLabel";
            this.appointmentLabel.Size = new System.Drawing.Size(71, 13);
            this.appointmentLabel.TabIndex = 10;
            this.appointmentLabel.Text = "Appointments";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(482, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // viewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.appointmentLabel);
            this.Controls.Add(this.prescriptionListBox);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.appointmentSubmit);
            this.Controls.Add(this.appointmentListBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.diagnosisListBox);
            this.Controls.Add(this.patientnameLabel);
            this.Controls.Add(this.addEntryButton);
            this.Controls.Add(this.patientidLabel);
            this.Name = "viewForm";
            this.Text = "<patient id>";
            this.Load += new System.EventHandler(this.viewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label patientidLabel;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Label patientnameLabel;
        private System.Windows.Forms.ListBox diagnosisListBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListBox appointmentListBox;
        private System.Windows.Forms.Button appointmentSubmit;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.ListBox prescriptionListBox;
        private System.Windows.Forms.Label appointmentLabel;
        private System.Windows.Forms.Button refreshButton;
    }
}