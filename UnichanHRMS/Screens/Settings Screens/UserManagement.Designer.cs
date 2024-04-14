namespace UnichanHRMS.Screens.Settings_Screens
{
    partial class UserManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteHiringManager = new UnichanHRMS.CustomControls.RoundedButton();
            this.dgvHiringManagers = new System.Windows.Forms.DataGridView();
            this.btnAddNewHiringManager = new UnichanHRMS.CustomControls.RoundedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new UnichanHRMS.CustomControls.RoundedButton();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new UnichanHRMS.CustomControls.RoundedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHiringManagers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteHiringManager);
            this.tabPage1.Controls.Add(this.dgvHiringManagers);
            this.tabPage1.Controls.Add(this.btnAddNewHiringManager);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HIRING MANAGER";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnDeleteHiringManager
            // 
            this.btnDeleteHiringManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteHiringManager.BackColor = System.Drawing.Color.White;
            this.btnDeleteHiringManager.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeleteHiringManager.BorderRadius = 40;
            this.btnDeleteHiringManager.BorderSize = 1;
            this.btnDeleteHiringManager.FlatAppearance.BorderSize = 0;
            this.btnDeleteHiringManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteHiringManager.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnDeleteHiringManager.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteHiringManager.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteHiringManager.Image")));
            this.btnDeleteHiringManager.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteHiringManager.Location = new System.Drawing.Point(664, 19);
            this.btnDeleteHiringManager.Name = "btnDeleteHiringManager";
            this.btnDeleteHiringManager.Size = new System.Drawing.Size(160, 37);
            this.btnDeleteHiringManager.TabIndex = 32;
            this.btnDeleteHiringManager.Text = "DELETE USER";
            this.btnDeleteHiringManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteHiringManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteHiringManager.UseVisualStyleBackColor = false;
            this.btnDeleteHiringManager.Click += new System.EventHandler(this.btnDeleteHiringManager_Click);
            // 
            // dgvHiringManagers
            // 
            this.dgvHiringManagers.AllowUserToAddRows = false;
            this.dgvHiringManagers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvHiringManagers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHiringManagers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHiringManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHiringManagers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHiringManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHiringManagers.EnableHeadersVisualStyles = false;
            this.dgvHiringManagers.Location = new System.Drawing.Point(17, 63);
            this.dgvHiringManagers.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dgvHiringManagers.MultiSelect = false;
            this.dgvHiringManagers.Name = "dgvHiringManagers";
            this.dgvHiringManagers.ReadOnly = true;
            this.dgvHiringManagers.RowHeadersVisible = false;
            this.dgvHiringManagers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHiringManagers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHiringManagers.Size = new System.Drawing.Size(807, 264);
            this.dgvHiringManagers.TabIndex = 31;
            // 
            // btnAddNewHiringManager
            // 
            this.btnAddNewHiringManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewHiringManager.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNewHiringManager.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddNewHiringManager.BorderRadius = 40;
            this.btnAddNewHiringManager.BorderSize = 0;
            this.btnAddNewHiringManager.FlatAppearance.BorderSize = 0;
            this.btnAddNewHiringManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewHiringManager.ForeColor = System.Drawing.Color.White;
            this.btnAddNewHiringManager.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewHiringManager.Image")));
            this.btnAddNewHiringManager.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewHiringManager.Location = new System.Drawing.Point(690, 334);
            this.btnAddNewHiringManager.Name = "btnAddNewHiringManager";
            this.btnAddNewHiringManager.Size = new System.Drawing.Size(134, 37);
            this.btnAddNewHiringManager.TabIndex = 30;
            this.btnAddNewHiringManager.Text = "Add New";
            this.btnAddNewHiringManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewHiringManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewHiringManager.UseVisualStyleBackColor = false;
            this.btnAddNewHiringManager.Click += new System.EventHandler(this.btnAddNewHiringManager_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.dgvUsers);
            this.tabPage2.Controls.Add(this.btnAddNew);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HIRING ASSISTANT";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDelete.BorderRadius = 40;
            this.btnDelete.BorderSize = 1;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(656, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 37);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "DELETE USER";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(9, 51);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(807, 264);
            this.dgvUsers.TabIndex = 28;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            this.dgvUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentDoubleClick);
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddNew.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddNew.BorderRadius = 40;
            this.btnAddNew.BorderSize = 0;
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNew.Location = new System.Drawing.Point(682, 322);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(134, 37);
            this.btnAddNew.TabIndex = 27;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "UserManagement";
            this.Text = "Batch Numbers";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHiringManagers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CustomControls.RoundedButton btnAddNew;
        private System.Windows.Forms.DataGridView dgvUsers;
        private CustomControls.RoundedButton btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CustomControls.RoundedButton btnDeleteHiringManager;
        private System.Windows.Forms.DataGridView dgvHiringManagers;
        private CustomControls.RoundedButton btnAddNewHiringManager;
    }
}