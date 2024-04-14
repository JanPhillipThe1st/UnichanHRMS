namespace UnichanHRMS.Screens
{
    partial class Manage_Applicants
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Applicants));
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchApplicant = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbShowRejected = new System.Windows.Forms.CheckBox();
            this.btnSMSNotification = new System.Windows.Forms.Button();
            this.btnSettings = new UnichanHRMS.CustomControls.TabButton();
            this.btnAddApplicant = new UnichanHRMS.CustomControls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.AllowUserToAddRows = false;
            this.dgvApplicants.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvApplicants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicants.EnableHeadersVisualStyles = false;
            this.dgvApplicants.Location = new System.Drawing.Point(17, 154);
            this.dgvApplicants.MultiSelect = false;
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.ReadOnly = true;
            this.dgvApplicants.RowHeadersVisible = false;
            this.dgvApplicants.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicants.Size = new System.Drawing.Size(932, 443);
            this.dgvApplicants.TabIndex = 23;
            this.dgvApplicants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplicants_CellClick);
            this.dgvApplicants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            this.dgvApplicants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplicants_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "APPLICANTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Search Applicant";
            // 
            // tbSearchApplicant
            // 
            this.tbSearchApplicant.Font = new System.Drawing.Font("Poppins", 10F);
            this.tbSearchApplicant.Location = new System.Drawing.Point(149, 124);
            this.tbSearchApplicant.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchApplicant.Name = "tbSearchApplicant";
            this.tbSearchApplicant.Size = new System.Drawing.Size(324, 27);
            this.tbSearchApplicant.TabIndex = 27;
            this.tbSearchApplicant.TextChanged += new System.EventHandler(this.tbSearchApplicant_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnDelete.Location = new System.Drawing.Point(767, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 31);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete Applicant";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbShowRejected
            // 
            this.cbShowRejected.AutoSize = true;
            this.cbShowRejected.Location = new System.Drawing.Point(17, 91);
            this.cbShowRejected.Name = "cbShowRejected";
            this.cbShowRejected.Size = new System.Drawing.Size(150, 26);
            this.cbShowRejected.TabIndex = 30;
            this.cbShowRejected.Text = "Show Rejected";
            this.cbShowRejected.UseVisualStyleBackColor = true;
            this.cbShowRejected.CheckedChanged += new System.EventHandler(this.cbShowRejected_CheckedChanged);
            // 
            // btnSMSNotification
            // 
            this.btnSMSNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSMSNotification.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnSMSNotification.Location = new System.Drawing.Point(17, 603);
            this.btnSMSNotification.Name = "btnSMSNotification";
            this.btnSMSNotification.Size = new System.Drawing.Size(182, 31);
            this.btnSMSNotification.TabIndex = 31;
            this.btnSMSNotification.Text = "SMS Notification";
            this.btnSMSNotification.UseVisualStyleBackColor = true;
            this.btnSMSNotification.Click += new System.EventHandler(this.btnSMSNotification_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Crimson;
            this.btnSettings.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSettings.BorderRadius = 40;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSettings.Location = new System.Drawing.Point(827, 12);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(141, 40);
            this.btnSettings.TabIndex = 26;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAddApplicant
            // 
            this.btnAddApplicant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddApplicant.BackColor = System.Drawing.Color.Transparent;
            this.btnAddApplicant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnAddApplicant.BorderRadius = 40;
            this.btnAddApplicant.BorderSize = 2;
            this.btnAddApplicant.FlatAppearance.BorderSize = 0;
            this.btnAddApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApplicant.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddApplicant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnAddApplicant.Image = ((System.Drawing.Image)(resources.GetObject("btnAddApplicant.Image")));
            this.btnAddApplicant.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddApplicant.Location = new System.Drawing.Point(685, 603);
            this.btnAddApplicant.Name = "btnAddApplicant";
            this.btnAddApplicant.Size = new System.Drawing.Size(264, 40);
            this.btnAddApplicant.TabIndex = 25;
            this.btnAddApplicant.Text = "ADD NEW APPLICANT";
            this.btnAddApplicant.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddApplicant.UseVisualStyleBackColor = false;
            this.btnAddApplicant.Click += new System.EventHandler(this.btnAddApplicant_Click);
            // 
            // Manage_Applicants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(967, 655);
            this.Controls.Add(this.btnSMSNotification);
            this.Controls.Add(this.cbShowRejected);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchApplicant);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddApplicant);
            this.Controls.Add(this.dgvApplicants);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Manage_Applicants";
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.Manage_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.Label label5;
        private CustomControls.RoundedButton btnAddApplicant;
        private CustomControls.TabButton btnSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchApplicant;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox cbShowRejected;
        private System.Windows.Forms.Button btnSMSNotification;
    }
}