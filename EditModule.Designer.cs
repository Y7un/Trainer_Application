namespace ioop_assignment3
{
    partial class frmEditModule
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
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.cmbboxDay = new System.Windows.Forms.ComboBox();
            this.cmbboxTime = new System.Windows.Forms.ComboBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.lblModuleCharge = new System.Windows.Forms.Label();
            this.lblModuleLvl = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpAddModule.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddModule
            // 
            this.grpAddModule.Controls.Add(this.lblLevel);
            this.grpAddModule.Controls.Add(this.lblModuleName);
            this.grpAddModule.Controls.Add(this.cmbboxDay);
            this.grpAddModule.Controls.Add(this.cmbboxTime);
            this.grpAddModule.Controls.Add(this.txtCharge);
            this.grpAddModule.Controls.Add(this.lblModuleCharge);
            this.grpAddModule.Controls.Add(this.lblModuleLvl);
            this.grpAddModule.Controls.Add(this.lblTime);
            this.grpAddModule.Controls.Add(this.lblDay);
            this.grpAddModule.Controls.Add(this.lblModule);
            this.grpAddModule.Location = new System.Drawing.Point(105, 69);
            this.grpAddModule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddModule.Name = "grpAddModule";
            this.grpAddModule.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddModule.Size = new System.Drawing.Size(856, 395);
            this.grpAddModule.TabIndex = 1;
            this.grpAddModule.TabStop = false;
            this.grpAddModule.Text = "New Module Details ";
            this.grpAddModule.Enter += new System.EventHandler(this.grpAddModule_Enter);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(176, 148);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(2, 20);
            this.lblLevel.TabIndex = 21;
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleName.Location = new System.Drawing.Point(175, 89);
            this.lblModuleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(2, 20);
            this.lblModuleName.TabIndex = 20;
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
            this.cmbboxDay.Location = new System.Drawing.Point(183, 271);
            this.cmbboxDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbboxDay.Name = "cmbboxDay";
            this.cmbboxDay.Size = new System.Drawing.Size(221, 24);
            this.cmbboxDay.TabIndex = 19;
            // 
            // cmbboxTime
            // 
            this.cmbboxTime.FormattingEnabled = true;
            this.cmbboxTime.Items.AddRange(new object[] {
            "9:00AM to 11:30AM ",
            "1:00PM to 3:30PM",
            "4:30PM to 7:00PM",
            "7:30PM to 10:00PM "});
            this.cmbboxTime.Location = new System.Drawing.Point(569, 270);
            this.cmbboxTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbboxTime.Name = "cmbboxTime";
            this.cmbboxTime.Size = new System.Drawing.Size(227, 24);
            this.cmbboxTime.TabIndex = 18;
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharge.Location = new System.Drawing.Point(223, 209);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(139, 24);
            this.txtCharge.TabIndex = 17;
            // 
            // lblModuleCharge
            // 
            this.lblModuleCharge.AutoSize = true;
            this.lblModuleCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleCharge.Location = new System.Drawing.Point(47, 212);
            this.lblModuleCharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuleCharge.Name = "lblModuleCharge";
            this.lblModuleCharge.Size = new System.Drawing.Size(151, 18);
            this.lblModuleCharge.TabIndex = 16;
            this.lblModuleCharge.Text = "Module Charge (RM):";
            // 
            // lblModuleLvl
            // 
            this.lblModuleLvl.AutoSize = true;
            this.lblModuleLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleLvl.Location = new System.Drawing.Point(48, 150);
            this.lblModuleLvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuleLvl.Name = "lblModuleLvl";
            this.lblModuleLvl.Size = new System.Drawing.Size(99, 18);
            this.lblModuleLvl.TabIndex = 12;
            this.lblModuleLvl.Text = "Module Level:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(440, 273);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(109, 18);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Assigned Time:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(48, 273);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(120, 18);
            this.lblDay.TabIndex = 8;
            this.lblDay.Text = "Assigned Day(s):";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModule.Location = new System.Drawing.Point(48, 89);
            this.lblModule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(105, 18);
            this.lblModule.TabIndex = 0;
            this.lblModule.Text = "Module Name:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(961, 500);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(95, 46);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 500);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 46);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmEditModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1072, 560);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpAddModule);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditModule";
            this.Text = "EditModule";
            this.Load += new System.EventHandler(this.frmEditModule_Load);
            this.grpAddModule.ResumeLayout(false);
            this.grpAddModule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddModule;
        private System.Windows.Forms.ComboBox cmbboxDay;
        private System.Windows.Forms.ComboBox cmbboxTime;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label lblModuleCharge;
        private System.Windows.Forms.Label lblModuleLvl;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
    }
}