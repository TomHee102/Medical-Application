namespace Medical_Application
{
    partial class addDiagForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.appointmentLabel = new System.Windows.Forms.Label();
            this.diagDetailLabel = new System.Windows.Forms.Label();
            this.diagDetailTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionLabel = new System.Windows.Forms.Label();
            this.entrySubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // appointmentLabel
            // 
            this.appointmentLabel.AutoSize = true;
            this.appointmentLabel.Location = new System.Drawing.Point(12, 9);
            this.appointmentLabel.Name = "appointmentLabel";
            this.appointmentLabel.Size = new System.Drawing.Size(66, 13);
            this.appointmentLabel.TabIndex = 1;
            this.appointmentLabel.Text = "Appointment";
            // 
            // diagDetailLabel
            // 
            this.diagDetailLabel.AutoSize = true;
            this.diagDetailLabel.Location = new System.Drawing.Point(12, 49);
            this.diagDetailLabel.Name = "diagDetailLabel";
            this.diagDetailLabel.Size = new System.Drawing.Size(80, 13);
            this.diagDetailLabel.TabIndex = 2;
            this.diagDetailLabel.Text = "DiagnosisDetail";
            // 
            // diagDetailTextBox
            // 
            this.diagDetailTextBox.Location = new System.Drawing.Point(12, 65);
            this.diagDetailTextBox.Multiline = true;
            this.diagDetailTextBox.Name = "diagDetailTextBox";
            this.diagDetailTextBox.Size = new System.Drawing.Size(247, 112);
            this.diagDetailTextBox.TabIndex = 3;
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.Location = new System.Drawing.Point(12, 196);
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.Size = new System.Drawing.Size(247, 20);
            this.prescriptionTextBox.TabIndex = 4;
            // 
            // prescriptionLabel
            // 
            this.prescriptionLabel.AutoSize = true;
            this.prescriptionLabel.Location = new System.Drawing.Point(12, 180);
            this.prescriptionLabel.Name = "prescriptionLabel";
            this.prescriptionLabel.Size = new System.Drawing.Size(62, 13);
            this.prescriptionLabel.TabIndex = 5;
            this.prescriptionLabel.Text = "Prescription";
            // 
            // entrySubmitButton
            // 
            this.entrySubmitButton.Location = new System.Drawing.Point(348, 194);
            this.entrySubmitButton.Name = "entrySubmitButton";
            this.entrySubmitButton.Size = new System.Drawing.Size(75, 23);
            this.entrySubmitButton.TabIndex = 6;
            this.entrySubmitButton.Text = "submit";
            this.entrySubmitButton.UseVisualStyleBackColor = true;
            this.entrySubmitButton.Click += new System.EventHandler(this.entrySubmitButton_Click);
            // 
            // addDiagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 230);
            this.Controls.Add(this.entrySubmitButton);
            this.Controls.Add(this.prescriptionLabel);
            this.Controls.Add(this.prescriptionTextBox);
            this.Controls.Add(this.diagDetailTextBox);
            this.Controls.Add(this.diagDetailLabel);
            this.Controls.Add(this.appointmentLabel);
            this.Controls.Add(this.comboBox1);
            this.Name = "addDiagForm";
            this.Text = "Add Entry for <patient id>";
            this.Load += new System.EventHandler(this.addDiagnosis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label appointmentLabel;
        private System.Windows.Forms.Label diagDetailLabel;
        private System.Windows.Forms.TextBox diagDetailTextBox;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.Label prescriptionLabel;
        private System.Windows.Forms.Button entrySubmitButton;
    }
}