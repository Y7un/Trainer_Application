namespace ioop_assignment3
{
    partial class frmModuleList
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
            this.grpModuleList = new System.Windows.Forms.GroupBox();
            this.lblChosenDelete = new System.Windows.Forms.Label();
            this.lblDeleteModule = new System.Windows.Forms.Label();
            this.lblChosenEdit = new System.Windows.Forms.Label();
            this.lblEditModule = new System.Windows.Forms.Label();
            this.dgvModuleList = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUpdate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteStdLst = new System.Windows.Forms.Button();
            this.btnEditStdList = new System.Windows.Forms.Button();
            this.grpModuleList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpModuleList
            // 
            this.grpModuleList.Controls.Add(this.lblChosenDelete);
            this.grpModuleList.Controls.Add(this.lblDeleteModule);
            this.grpModuleList.Controls.Add(this.lblChosenEdit);
            this.grpModuleList.Controls.Add(this.lblEditModule);
            this.grpModuleList.Controls.Add(this.dgvModuleList);
            this.grpModuleList.Controls.Add(this.btnRetrieve);
            this.grpModuleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModuleList.Location = new System.Drawing.Point(47, 37);
            this.grpModuleList.Name = "grpModuleList";
            this.grpModuleList.Size = new System.Drawing.Size(911, 485);
            this.grpModuleList.TabIndex = 0;
            this.grpModuleList.TabStop = false;
            this.grpModuleList.Text = "Module List";
            this.grpModuleList.Enter += new System.EventHandler(this.grpModuleList_Enter);
            // 
            // lblChosenDelete
            // 
            this.lblChosenDelete.AutoSize = true;
            this.lblChosenDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChosenDelete.Location = new System.Drawing.Point(532, 65);
            this.lblChosenDelete.Name = "lblChosenDelete";
            this.lblChosenDelete.Size = new System.Drawing.Size(2, 22);
            this.lblChosenDelete.TabIndex = 16;
            // 
            // lblDeleteModule
            // 
            this.lblDeleteModule.AutoSize = true;
            this.lblDeleteModule.Location = new System.Drawing.Point(345, 65);
            this.lblDeleteModule.Name = "lblDeleteModule";
            this.lblDeleteModule.Size = new System.Drawing.Size(216, 20);
            this.lblDeleteModule.TabIndex = 15;
            this.lblDeleteModule.Text = "Selected Module to Delete :";
            // 
            // lblChosenEdit
            // 
            this.lblChosenEdit.AutoSize = true;
            this.lblChosenEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChosenEdit.Location = new System.Drawing.Point(182, 63);
            this.lblChosenEdit.Name = "lblChosenEdit";
            this.lblChosenEdit.Size = new System.Drawing.Size(2, 22);
            this.lblChosenEdit.TabIndex = 14;
            // 
            // lblEditModule
            // 
            this.lblEditModule.AutoSize = true;
            this.lblEditModule.Location = new System.Drawing.Point(22, 63);
            this.lblEditModule.Name = "lblEditModule";
            this.lblEditModule.Size = new System.Drawing.Size(196, 20);
            this.lblEditModule.TabIndex = 13;
            this.lblEditModule.Text = "Selected Module to Edit :";
            // 
            // dgvModuleList
            // 
            this.dgvModuleList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvModuleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.clmUpdate,
            this.clmDelete});
            this.dgvModuleList.Location = new System.Drawing.Point(25, 127);
            this.dgvModuleList.Name = "dgvModuleList";
            this.dgvModuleList.RowHeadersWidth = 51;
            this.dgvModuleList.Size = new System.Drawing.Size(864, 282);
            this.dgvModuleList.TabIndex = 12;
            this.dgvModuleList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModuleList_CellContentClick);
            // 
            // clmID
            // 
            this.clmID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmID.DataPropertyName = "Id";
            this.clmID.HeaderText = "ID ";
            this.clmID.MinimumWidth = 6;
            this.clmID.Name = "clmID";
            this.clmID.Width = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Module Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "level";
            this.dataGridViewTextBoxColumn2.HeaderText = "Module Level";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 126;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Charge";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 92;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "schedule";
            this.dataGridViewTextBoxColumn4.HeaderText = "Schedule";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // clmUpdate
            // 
            this.clmUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmUpdate.HeaderText = "Click to Update";
            this.clmUpdate.MinimumWidth = 6;
            this.clmUpdate.Name = "clmUpdate";
            this.clmUpdate.Text = "Update module";
            this.clmUpdate.UseColumnTextForLinkValue = true;
            this.clmUpdate.Width = 116;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "Click to Delete";
            this.clmDelete.MinimumWidth = 6;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Text = "Delete module";
            this.clmDelete.UseColumnTextForLinkValue = true;
            this.clmDelete.Width = 125;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(395, 428);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(132, 37);
            this.btnRetrieve.TabIndex = 11;
            this.btnRetrieve.Text = "Retrieve Modules";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 538);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 37);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteStdLst
            // 
            this.btnDeleteStdLst.Location = new System.Drawing.Point(913, 538);
            this.btnDeleteStdLst.Name = "btnDeleteStdLst";
            this.btnDeleteStdLst.Size = new System.Drawing.Size(71, 37);
            this.btnDeleteStdLst.TabIndex = 10;
            this.btnDeleteStdLst.Text = "Delete";
            this.btnDeleteStdLst.UseVisualStyleBackColor = true;
            this.btnDeleteStdLst.Click += new System.EventHandler(this.btnDeleteStdLst_Click);
            // 
            // btnEditStdList
            // 
            this.btnEditStdList.Location = new System.Drawing.Point(836, 538);
            this.btnEditStdList.Name = "btnEditStdList";
            this.btnEditStdList.Size = new System.Drawing.Size(71, 37);
            this.btnEditStdList.TabIndex = 9;
            this.btnEditStdList.Text = "Edit";
            this.btnEditStdList.UseVisualStyleBackColor = true;
            this.btnEditStdList.Click += new System.EventHandler(this.btnEditStdList_Click);
            // 
            // frmModuleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1006, 587);
            this.Controls.Add(this.btnEditStdList);
            this.Controls.Add(this.btnDeleteStdLst);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpModuleList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmModuleList";
            this.Text = "Edit Module";
            this.grpModuleList.ResumeLayout(false);
            this.grpModuleList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModuleList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteStdLst;
        private System.Windows.Forms.Button btnEditStdList;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.DataGridView dgvModuleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewLinkColumn clmUpdate;
        private System.Windows.Forms.DataGridViewLinkColumn clmDelete;
        private System.Windows.Forms.Label lblEditModule;
        private System.Windows.Forms.Label lblChosenDelete;
        private System.Windows.Forms.Label lblDeleteModule;
        private System.Windows.Forms.Label lblChosenEdit;
    }
}