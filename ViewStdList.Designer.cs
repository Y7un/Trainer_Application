namespace ioop_assignment3
{
    partial class frmViewStdList
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
            this.grpStdList = new System.Windows.Forms.GroupBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.dgvStdList = new System.Windows.Forms.DataGridView();
            this.clmStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpStdList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 487);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 37);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpStdList
            // 
            this.grpStdList.Controls.Add(this.btnRetrieve);
            this.grpStdList.Controls.Add(this.dgvStdList);
            this.grpStdList.Location = new System.Drawing.Point(58, 38);
            this.grpStdList.Name = "grpStdList";
            this.grpStdList.Size = new System.Drawing.Size(807, 432);
            this.grpStdList.TabIndex = 10;
            this.grpStdList.TabStop = false;
            this.grpStdList.Text = "Student List";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(338, 371);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(132, 37);
            this.btnRetrieve.TabIndex = 12;
            this.btnRetrieve.Text = "Retrieve Students";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // dgvStdList
            // 
            this.dgvStdList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStudentName,
            this.clmModule,
            this.clmLevel,
            this.clmMonth});
            this.dgvStdList.Location = new System.Drawing.Point(74, 77);
            this.dgvStdList.Name = "dgvStdList";
            this.dgvStdList.RowHeadersWidth = 51;
            this.dgvStdList.Size = new System.Drawing.Size(657, 285);
            this.dgvStdList.TabIndex = 0;
            this.dgvStdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStdList_CellContentClick);
            // 
            // clmStudentName
            // 
            this.clmStudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmStudentName.HeaderText = "Student Name";
            this.clmStudentName.MinimumWidth = 6;
            this.clmStudentName.Name = "clmStudentName";
            // 
            // clmModule
            // 
            this.clmModule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmModule.HeaderText = "Module Name";
            this.clmModule.MinimumWidth = 6;
            this.clmModule.Name = "clmModule";
            // 
            // clmLevel
            // 
            this.clmLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmLevel.HeaderText = "Module Level";
            this.clmLevel.MinimumWidth = 6;
            this.clmLevel.Name = "clmLevel";
            // 
            // clmMonth
            // 
            this.clmMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMonth.HeaderText = "Month of Enrollment ";
            this.clmMonth.MinimumWidth = 6;
            this.clmMonth.Name = "clmMonth";
            // 
            // frmViewStdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(919, 536);
            this.Controls.Add(this.grpStdList);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmViewStdList";
            this.Text = "ViewStdList";
            this.grpStdList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpStdList;
        private System.Windows.Forms.DataGridView dgvStdList;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
    }
}