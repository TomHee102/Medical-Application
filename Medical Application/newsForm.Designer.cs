namespace Medical_Application
{
    partial class newsForm
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
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.passLabel = new System.Windows.Forms.Label();
            this.passField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fnameField
            // 
            this.fnameField.Location = new System.Drawing.Point(12, 25);
            this.fnameField.Name = "fnameField";
            this.fnameField.Size = new System.Drawing.Size(144, 20);
            this.fnameField.TabIndex = 1;
            // 
            // lnameField
            // 
            this.lnameField.Location = new System.Drawing.Point(12, 64);
            this.lnameField.Name = "lnameField";
            this.lnameField.Size = new System.Drawing.Size(144, 20);
            this.lnameField.TabIndex = 2;
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(9, 9);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(57, 13);
            this.fnameLabel.TabIndex = 4;
            this.fnameLabel.Text = "First Name";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(9, 48);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(58, 13);
            this.lnameLabel.TabIndex = 5;
            this.lnameLabel.Text = "Last Name";
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Doctor",
            "Admin"});
            this.roleComboBox.Location = new System.Drawing.Point(12, 142);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(144, 21);
            this.roleComboBox.TabIndex = 6;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(9, 126);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(29, 13);
            this.roleLabel.TabIndex = 7;
            this.roleLabel.Text = "Role";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(292, 142);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(9, 87);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(53, 13);
            this.passLabel.TabIndex = 13;
            this.passLabel.Text = "Password";
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(12, 103);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(144, 20);
            this.passField.TabIndex = 14;
            // 
            // newsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 174);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.lnameField);
            this.Controls.Add(this.fnameField);
            this.Name = "newsForm";
            this.Text = "New Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnameField;
        private System.Windows.Forms.TextBox lnameField;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passField;
    }
}