namespace ioop_assignment3
{
    partial class frmTrainerProfile
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTrainerName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTrainerID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtTrainerName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTrainerID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 481);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 46);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTrainerName
            // 
            this.lblTrainerName.AutoSize = true;
            this.lblTrainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerName.Location = new System.Drawing.Point(157, 91);
            this.lblTrainerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrainerName.Name = "lblTrainerName";
            this.lblTrainerName.Size = new System.Drawing.Size(56, 18);
            this.lblTrainerName.TabIndex = 8;
            this.lblTrainerName.Text = "Name: ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(148, 143);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 18);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(161, 190);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(88, 236);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(125, 18);
            this.lblContactNo.TabIndex = 12;
            this.lblContactNo.Text = "Contact Number: ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(148, 284);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 18);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address: ";
            // 
            // lblTrainerID
            // 
            this.lblTrainerID.AutoSize = true;
            this.lblTrainerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainerID.Location = new System.Drawing.Point(521, 94);
            this.lblTrainerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrainerID.Name = "lblTrainerID";
            this.lblTrainerID.Size = new System.Drawing.Size(80, 18);
            this.lblTrainerID.TabIndex = 15;
            this.lblTrainerID.Text = "Trainer ID: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(523, 143);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 18);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password: ";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(752, 335);
            this.btnEditProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(95, 46);
            this.btnEditProfile.TabIndex = 11;
            this.btnEditProfile.Text = "Edit";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // grpProfile
            // 
            this.grpProfile.Controls.Add(this.txtGender);
            this.grpProfile.Controls.Add(this.txtTrainerName);
            this.grpProfile.Controls.Add(this.txtPassword);
            this.grpProfile.Controls.Add(this.txtTrainerID);
            this.grpProfile.Controls.Add(this.txtAddress);
            this.grpProfile.Controls.Add(this.txtContactNo);
            this.grpProfile.Controls.Add(this.txtEmail);
            this.grpProfile.Controls.Add(this.btnEditProfile);
            this.grpProfile.Controls.Add(this.lblPassword);
            this.grpProfile.Controls.Add(this.lblTrainerID);
            this.grpProfile.Controls.Add(this.lblAddress);
            this.grpProfile.Controls.Add(this.lblContactNo);
            this.grpProfile.Controls.Add(this.lblEmail);
            this.grpProfile.Controls.Add(this.lblGender);
            this.grpProfile.Controls.Add(this.lblTrainerName);
            this.grpProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProfile.Location = new System.Drawing.Point(143, 60);
            this.grpProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpProfile.Size = new System.Drawing.Size(883, 402);
            this.grpProfile.TabIndex = 10;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "Trainer\'s Profile Details";
            this.grpProfile.Enter += new System.EventHandler(this.grpProfile_Enter);
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(225, 140);
            this.txtGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(223, 24);
            this.txtGender.TabIndex = 25;
            // 
            // txtTrainerName
            // 
            this.txtTrainerName.Enabled = false;
            this.txtTrainerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerName.Location = new System.Drawing.Point(225, 92);
            this.txtTrainerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrainerName.Name = "txtTrainerName";
            this.txtTrainerName.Size = new System.Drawing.Size(223, 24);
            this.txtTrainerName.TabIndex = 24;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(623, 143);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(188, 24);
            this.txtPassword.TabIndex = 23;
            // 
            // txtTrainerID
            // 
            this.txtTrainerID.Enabled = false;
            this.txtTrainerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerID.Location = new System.Drawing.Point(623, 91);
            this.txtTrainerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrainerID.Name = "txtTrainerID";
            this.txtTrainerID.Size = new System.Drawing.Size(188, 24);
            this.txtTrainerID.TabIndex = 22;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(225, 282);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(223, 24);
            this.txtAddress.TabIndex = 21;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(225, 236);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(223, 24);
            this.txtContactNo.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(225, 190);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 24);
            this.txtEmail.TabIndex = 19;
            // 
            // frmTrainerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1164, 554);
            this.Controls.Add(this.grpProfile);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTrainerProfile";
            this.Text = "Trainer Profile";
            this.Load += new System.EventHandler(this.frmTrainerProfile_Load);
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTrainerName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTrainerID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTrainerID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtTrainerName;
    }
}