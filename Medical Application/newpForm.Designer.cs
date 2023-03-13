namespace Medical_Application
{
    partial class newpForm
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
            this.fnameField = new System.Windows.Forms.TextBox();
            this.lnameField = new System.Windows.Forms.TextBox();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.inpatientField = new System.Windows.Forms.CheckBox();
            this.wardLabel = new System.Windows.Forms.Label();
            this.wardField = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fnameField
            // 
            this.fnameField.Location = new System.Drawing.Point(12, 25);
            this.fnameField.Name = "fnameField";
            this.fnameField.Size = new System.Drawing.Size(144, 20);
            this.fnameField.TabIndex = 0;
            // 
            // lnameField
            // 
            this.lnameField.Location = new System.Drawing.Point(12, 64);
            this.lnameField.Name = "lnameField";
            this.lnameField.Size = new System.Drawing.Size(144, 20);
            this.lnameField.TabIndex = 1;
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(9, 9);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(57, 13);
            this.fnameLabel.TabIndex = 3;
            this.fnameLabel.Text = "First Name";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(9, 48);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(58, 13);
            this.lnameLabel.TabIndex = 4;
            this.lnameLabel.Text = "Last Name";
            // 
            // inpatientField
            // 
            this.inpatientField.AutoSize = true;
            this.inpatientField.Location = new System.Drawing.Point(12, 129);
            this.inpatientField.Name = "inpatientField";
            this.inpatientField.Size = new System.Drawing.Size(73, 17);
            this.inpatientField.TabIndex = 6;
            this.inpatientField.Text = "Inpatient?";
            this.inpatientField.UseVisualStyleBackColor = true;
            this.inpatientField.CheckedChanged += new System.EventHandler(this.inpatientField_CheckedChanged);
            // 
            // wardLabel
            // 
            this.wardLabel.AutoSize = true;
            this.wardLabel.Location = new System.Drawing.Point(9, 149);
            this.wardLabel.Name = "wardLabel";
            this.wardLabel.Size = new System.Drawing.Size(33, 13);
            this.wardLabel.TabIndex = 7;
            this.wardLabel.Text = "Ward";
            this.wardLabel.Visible = false;
            // 
            // wardField
            // 
            this.wardField.Location = new System.Drawing.Point(12, 165);
            this.wardField.Name = "wardField";
            this.wardField.Size = new System.Drawing.Size(144, 20);
            this.wardField.TabIndex = 8;
            this.wardField.Visible = false;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(9, 87);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "Address";
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(12, 103);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(144, 20);
            this.addressField.TabIndex = 10;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(292, 162);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // newpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 200);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.wardField);
            this.Controls.Add(this.wardLabel);
            this.Controls.Add(this.inpatientField);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.lnameField);
            this.Controls.Add(this.fnameField);
            this.Name = "newpForm";
            this.Text = "New Patient";
            this.Load += new System.EventHandler(this.newpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnameField;
        private System.Windows.Forms.TextBox lnameField;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.CheckBox inpatientField;
        private System.Windows.Forms.Label wardLabel;
        private System.Windows.Forms.TextBox wardField;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Button submitButton;
    }
}