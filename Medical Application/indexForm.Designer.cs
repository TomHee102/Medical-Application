namespace Medical_Application
{
    partial class indexForm
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
            this.userIdLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.solPictureBox = new System.Windows.Forms.PictureBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.indexGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.solPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.userIdLabel.Location = new System.Drawing.Point(118, 12);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(670, 36);
            this.userIdLabel.TabIndex = 8;
            this.userIdLabel.Text = "<staff id>";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(600, 184);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 9;
            this.newButton.Text = "new";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newpButton_Click);
            // 
            // solPictureBox
            // 
            this.solPictureBox.Image = global::Medical_Application.Properties.Resources.medical_star;
            this.solPictureBox.Location = new System.Drawing.Point(12, 12);
            this.solPictureBox.Name = "solPictureBox";
            this.solPictureBox.Size = new System.Drawing.Size(100, 114);
            this.solPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.solPictureBox.TabIndex = 7;
            this.solPictureBox.TabStop = false;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(681, 415);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 10;
            this.viewButton.Text = "view";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.tempviewButton_Click);
            // 
            // indexGridView
            // 
            this.indexGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indexGridView.Location = new System.Drawing.Point(12, 213);
            this.indexGridView.Name = "indexGridView";
            this.indexGridView.ReadOnly = true;
            this.indexGridView.Size = new System.Drawing.Size(663, 225);
            this.indexGridView.TabIndex = 11;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 184);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.nameLabel.Location = new System.Drawing.Point(118, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(670, 78);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "<staff name>";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(713, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // indexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.indexGridView);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.solPictureBox);
            this.Name = "indexForm";
            this.Text = "<staff id>";
            ((System.ComponentModel.ISupportInitialize)(this.solPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.PictureBox solPictureBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.DataGridView indexGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button logoutButton;
    }
}