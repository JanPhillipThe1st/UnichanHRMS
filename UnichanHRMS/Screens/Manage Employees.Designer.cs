namespace UnichanHRMS.Screens
{
    partial class Manage_Employees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnAddNewEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbSearchEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvActiveEmployees = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.gbEmployees = new System.Windows.Forms.GroupBox();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCriteria = new System.Windows.Forms.ComboBox();
            this.dgvResignedEmployees = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResignedEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(167, 140);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(203, 20);
            this.lblCount.TabIndex = 22;
            this.lblCount.Text = "Current Active Employees:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnDelete.Location = new System.Drawing.Point(1379, 111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 31);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete Employee";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnPrintReport.Location = new System.Drawing.Point(171, 163);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(347, 31);
            this.btnPrintReport.TabIndex = 19;
            this.btnPrintReport.Text = "Print Employee Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnAddNewEmployee
            // 
            this.btnAddNewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewEmployee.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnAddNewEmployee.Location = new System.Drawing.Point(1379, 39);
            this.btnAddNewEmployee.Name = "btnAddNewEmployee";
            this.btnAddNewEmployee.Size = new System.Drawing.Size(182, 31);
            this.btnAddNewEmployee.TabIndex = 21;
            this.btnAddNewEmployee.Text = "Add New Applicant";
            this.btnAddNewEmployee.UseVisualStyleBackColor = true;
            this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F);
            this.label3.Location = new System.Drawing.Point(96, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Filter by:";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Poppins", 10F);
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(171, 32);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(347, 31);
            this.cbFilter.TabIndex = 17;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbBatchNumber_SelectedIndexChanged);
            // 
            // tbSearchEmployee
            // 
            this.tbSearchEmployee.Font = new System.Drawing.Font("Poppins", 10F);
            this.tbSearchEmployee.Location = new System.Drawing.Point(171, 109);
            this.tbSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchEmployee.Name = "tbSearchEmployee";
            this.tbSearchEmployee.Size = new System.Drawing.Size(347, 27);
            this.tbSearchEmployee.TabIndex = 14;
            this.tbSearchEmployee.TextChanged += new System.EventHandler(this.tbSearchEmployee_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.Location = new System.Drawing.Point(27, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search Employee ";
            // 
            // dgvActiveEmployees
            // 
            this.dgvActiveEmployees.AllowUserToAddRows = false;
            this.dgvActiveEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvActiveEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActiveEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvActiveEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActiveEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActiveEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveEmployees.EnableHeadersVisualStyles = false;
            this.dgvActiveEmployees.Location = new System.Drawing.Point(9, 332);
            this.dgvActiveEmployees.MultiSelect = false;
            this.dgvActiveEmployees.Name = "dgvActiveEmployees";
            this.dgvActiveEmployees.ReadOnly = true;
            this.dgvActiveEmployees.RowHeadersVisible = false;
            this.dgvActiveEmployees.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvActiveEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveEmployees.Size = new System.Drawing.Size(753, 309);
            this.dgvActiveEmployees.TabIndex = 23;
            this.dgvActiveEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActiveEmployees_CellClick);
            this.dgvActiveEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            this.dgvActiveEmployees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvActiveEmployees_KeyDown);
            this.dgvActiveEmployees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvActiveEmployees_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1606, 50);
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(652, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "EMPLOYEE MANAGEMENT";
            // 
            // gbEmployees
            // 
            this.gbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEmployees.Controls.Add(this.btnLeave);
            this.gbEmployees.Controls.Add(this.btnEditEmployee);
            this.gbEmployees.Controls.Add(this.btnClearFilters);
            this.gbEmployees.Controls.Add(this.label6);
            this.gbEmployees.Controls.Add(this.cbCriteria);
            this.gbEmployees.Controls.Add(this.label3);
            this.gbEmployees.Controls.Add(this.label1);
            this.gbEmployees.Controls.Add(this.tbSearchEmployee);
            this.gbEmployees.Controls.Add(this.lblCount);
            this.gbEmployees.Controls.Add(this.cbFilter);
            this.gbEmployees.Controls.Add(this.btnDelete);
            this.gbEmployees.Controls.Add(this.btnAddNewEmployee);
            this.gbEmployees.Controls.Add(this.btnPrintReport);
            this.gbEmployees.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold);
            this.gbEmployees.Location = new System.Drawing.Point(9, 70);
            this.gbEmployees.Name = "gbEmployees";
            this.gbEmployees.Size = new System.Drawing.Size(1588, 216);
            this.gbEmployees.TabIndex = 25;
            this.gbEmployees.TabStop = false;
            this.gbEmployees.Text = "Employees";
            this.gbEmployees.Enter += new System.EventHandler(this.gbEmployees_Enter);
            // 
            // btnLeave
            // 
            this.btnLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeave.Enabled = false;
            this.btnLeave.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnLeave.Location = new System.Drawing.Point(1379, 148);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(182, 31);
            this.btnLeave.TabIndex = 27;
            this.btnLeave.Text = "Apply for Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEmployee.Enabled = false;
            this.btnEditEmployee.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnEditEmployee.Location = new System.Drawing.Point(1379, 76);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(182, 31);
            this.btnEditEmployee.TabIndex = 26;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnClearFilters.Location = new System.Drawing.Point(524, 32);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(110, 31);
            this.btnClearFilters.TabIndex = 25;
            this.btnClearFilters.Text = "Clear filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10F);
            this.label6.Location = new System.Drawing.Point(43, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Where equal to:";
            // 
            // cbCriteria
            // 
            this.cbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriteria.Font = new System.Drawing.Font("Poppins", 10F);
            this.cbCriteria.FormattingEnabled = true;
            this.cbCriteria.Location = new System.Drawing.Point(171, 69);
            this.cbCriteria.Name = "cbCriteria";
            this.cbCriteria.Size = new System.Drawing.Size(347, 31);
            this.cbCriteria.TabIndex = 23;
            this.cbCriteria.SelectedIndexChanged += new System.EventHandler(this.cbCriteria_SelectedIndexChanged);
            // 
            // dgvResignedEmployees
            // 
            this.dgvResignedEmployees.AllowUserToAddRows = false;
            this.dgvResignedEmployees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvResignedEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResignedEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResignedEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResignedEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResignedEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResignedEmployees.EnableHeadersVisualStyles = false;
            this.dgvResignedEmployees.Location = new System.Drawing.Point(784, 332);
            this.dgvResignedEmployees.MultiSelect = false;
            this.dgvResignedEmployees.Name = "dgvResignedEmployees";
            this.dgvResignedEmployees.ReadOnly = true;
            this.dgvResignedEmployees.RowHeadersVisible = false;
            this.dgvResignedEmployees.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvResignedEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResignedEmployees.Size = new System.Drawing.Size(810, 309);
            this.dgvResignedEmployees.TabIndex = 26;
            this.dgvResignedEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResignedEmployees_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Active Employees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Resigned Employees";
            // 
            // Manage_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1606, 653);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvResignedEmployees);
            this.Controls.Add(this.gbEmployees);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvActiveEmployees);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Manage_Employees";
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.Manage_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbEmployees.ResumeLayout(false);
            this.gbEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResignedEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbSearchEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvActiveEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbEmployees;
        private System.Windows.Forms.DataGridView dgvResignedEmployees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCriteria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnLeave;
    }
}