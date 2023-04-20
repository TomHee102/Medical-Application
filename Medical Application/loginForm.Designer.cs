namespace Medical_Application
{
    partial class loginForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passField = new System.Windows.Forms.TextBox();
            this.userField = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.solPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.solPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(370, 179);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(53, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(371, 218);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(52, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "password";
            // 
            // passField
            // 
            this.passField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passField.Location = new System.Drawing.Point(345, 234);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(100, 20);
            this.passField.TabIndex = 2;
            this.passField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passField.UseSystemPasswordChar = true;
            // 
            // userField
            // 
            this.userField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userField.Location = new System.Drawing.Point(345, 195);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(100, 20);
            this.userField.TabIndex = 3;
            this.userField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userField.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(345, 260);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 77);
            this.label1.TabIndex = 6;
            this.label1.Text = "Medical Database";
            // 
            // solPictureBox
            // 
            this.solPictureBox.Image = global::Medical_Application.Properties.Resources.medical_star;
            this.solPictureBox.Location = new System.Drawing.Point(12, 12);
            this.solPictureBox.Name = "solPictureBox";
            this.solPictureBox.Size = new System.Drawing.Size(100, 114);
            this.solPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.solPictureBox.TabIndex = 4;
            this.solPictureBox.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.solPictureBox);
            this.Controls.Add(this.userField);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "loginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.solPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.PictureBox solPictureBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
    }
}

