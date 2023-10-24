namespace ioop_assignment3
{
    partial class frmAddModule
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
            this.grpAddModule = new System.Windows.Forms.GroupBox();
            this.cmbboxDay = new System.Windows.Forms.ComboBox();
            this.cmbboxTime = new System.Windows.Forms.ComboBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.lblModuleCharge = new System.Windows.Forms.Label();
            this.radbtnAdv = new System.Windows.Forms.RadioButton();
            this.radbtnInt = new System.Windows.Forms.RadioButton();
            this.radbtnBgn = new System.Windows.Forms.RadioButton();
            this.lblModuleLvl = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnAddClear = new System.Windows.Forms.Button();
            this.grpAddModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddModule
            // 
            this.grpAddModule.Controls.Add(this.cmbboxDay);
            this.grpAddModule.Controls.Add(this.cmbboxTime);
            this.grpAddModule.Controls.Add(this.txtCharge);
            this.grpAddModule.Controls.Add(this.lblModuleCharge);
            this.grpAddModule.Controls.Add(this.radbtnAdv);
            this.grpAddModule.Controls.Add(this.radbtnInt);
            this.grpAddModule.Controls.Add(this.radbtnBgn);
            this.grpAddModule.Controls.Add(this.lblModuleLvl);
            this.grpAddModule.Controls.Add(this.lblTime);
            this.grpAddModule.Controls.Add(this.lblDay);
            this.grpAddModule.Controls.Add(this.txtModuleName);
            this.grpAddModule.Controls.Add(this.lblModuleName);
            this.grpAddModule.Location = new System.Drawing.Point(19, 15);
            this.grpAddModule.Name = "grpAddModule";
            this.grpAddModule.Size = new System.Drawing.Size(642, 321);
            this.grpAddModule.TabIndex = 0;
            this.grpAddModule.TabStop = false;
            this.grpAddModule.Text = "New Module Details ";
            this.grpAddModule.Enter += new System.EventHandler(this.grpAddModule_Enter);
            // 
            // cmbboxDay
            // 
            this.cmbboxDay.FormattingEnabled = true;
            this.cmbboxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cmbboxDay.Location = new System.Drawing.Point(137, 191);
            this.cmbboxDay.Name = "cmbboxDay";
            this.cmbboxDay.Size = new System.Drawing.Size(167, 28);
            this.cmbboxDay.TabIndex = 19;
            this.cmbboxDay.SelectedIndexChanged += new System.EventHandler(this.cmbboxDay_SelectedIndexChanged);
            // 
            // cmbboxTime
            // 
            this.cmbboxTime.FormattingEnabled = true;
            this.cmbboxTime.Items.AddRange(new object[] {
            "9:00AM to 11:30AM ",
            "1:00PM to 3:30PM",
            "4:30PM to 7:00PM",
            "7:30PM to 10:00PM "});
            this.cmbboxTime.Location = new System.Drawing.Point(427, 190);
            this.cmbboxTime.Name = "cmbboxTime";
            this.cmbboxTime.Size = new System.Drawing.Size(171, 28);
            this.cmbboxTime.TabIndex = 18;
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(167, 141);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(105, 24);
            this.txtCharge.TabIndex = 17;
            // 
            // lblModuleCharge
            // 
            this.lblModuleCharge.AutoSize = true;
            this.lblModuleCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleCharge.Location = new System.Drawing.Point(35, 143);
            this.lblModuleCharge.Name = "lblModuleCharge";
            this.lblModuleCharge.Size = new System.Drawing.Size(151, 18);
            this.lblModuleCharge.TabIndex = 16;
            this.lblModuleCharge.Text = "Module Charge (RM):";
            // 
            // radbtnAdv
            // 
            this.radbtnAdv.AutoSize = true;
            this.radbtnAdv.Location = new System.Drawing.Point(427, 93);
            this.radbtnAdv.Name = "radbtnAdv";
            this.radbtnAdv.Size = new System.Drawing.Size(94, 24);
            this.radbtnAdv.TabIndex = 15;
            this.radbtnAdv.TabStop = true;
            this.radbtnAdv.Text = "Advance";
            this.radbtnAdv.UseVisualStyleBackColor = true;
            // 
            // radbtnInt
            // 
            this.radbtnInt.AutoSize = true;
            this.radbtnInt.Location = new System.Drawing.Point(275, 93);
            this.radbtnInt.Name = "radbtnInt";
            this.radbtnInt.Size = new System.Drawing.Size(132, 24);
            this.radbtnInt.TabIndex = 14;
            this.radbtnInt.TabStop = true;
            this.radbtnInt.Text = "Intermediate  ";
            this.radbtnInt.UseVisualStyleBackColor = true;
            // 
            // radbtnBgn
            // 
            this.radbtnBgn.AutoSize = true;
            this.radbtnBgn.Location = new System.Drawing.Point(140, 93);
            this.radbtnBgn.Name = "radbtnBgn";
            this.radbtnBgn.Size = new System.Drawing.Size(97, 24);
            this.radbtnBgn.TabIndex = 13;
            this.radbtnBgn.TabStop = true;
            this.radbtnBgn.Text = "Beginner";
            this.radbtnBgn.UseVisualStyleBackColor = true;
            // 
            // lblModuleLvl
            // 
            this.lblModuleLvl.AutoSize = true;
            this.lblModuleLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleLvl.Location = new System.Drawing.Point(36, 93);
            this.lblModuleLvl.Name = "lblModuleLvl";
            this.lblModuleLvl.Size = new System.Drawing.Size(99, 18);
            this.lblModuleLvl.TabIndex = 12;
            this.lblModuleLvl.Text = "Module Level:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(330, 193);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(109, 18);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Assigned Time:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(36, 193);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(120, 18);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "Assigned Day(s):";
            // 
            // txtModuleName
            // 
            this.txtModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuleName.Location = new System.Drawing.Point(137, 41);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(461, 24);
            this.txtModuleName.TabIndex = 1;
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.Location = new System.Drawing.Point(36, 43);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(105, 18);
            this.lblModuleName.TabIndex = 0;
            this.lblModuleName.Text = "Module Name:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 349);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 37);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(498, 349);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(71, 37);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnAddClear
            // 
            this.btnAddClear.Location = new System.Drawing.Point(578, 349);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(76, 37);
            this.btnAddClear.TabIndex = 12;
            this.btnAddClear.Text = "Clear All ";
            this.btnAddClear.UseVisualStyleBackColor = true;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // frmAddModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(682, 401);
            this.Controls.Add(this.btnAddClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grpAddModule);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddModule";
            this.Text = "Add Module";
            this.grpAddModule.ResumeLayout(false);
            this.grpAddModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddModule;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnAddClear;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label lblModuleCharge;
        private System.Windows.Forms.RadioButton radbtnAdv;
        private System.Windows.Forms.RadioButton radbtnInt;
        private System.Windows.Forms.RadioButton radbtnBgn;
        private System.Windows.Forms.Label lblModuleLvl;
        private System.Windows.Forms.ComboBox cmbboxTime;
        private System.Windows.Forms.ComboBox cmbboxDay;
    }
}