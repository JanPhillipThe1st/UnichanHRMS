﻿namespace UnichanHRMS.Screens
{
    partial class VisitorsLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorsLog));
            this.dgvVisitorsLog = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.gbAddVisitor = new System.Windows.Forms.GroupBox();
            this.btnSave = new UnichanHRMS.CustomControls.RoundedButton();
            this.dtpDateOfVisit = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeOut = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTimeIn = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPurpose = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteLog = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitorsLog)).BeginInit();
            this.gbAddVisitor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisitorsLog
            // 
            this.dgvVisitorsLog.AllowUserToAddRows = false;
            this.dgvVisitorsLog.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvVisitorsLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisitorsLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvVisitorsLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitorsLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVisitorsLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitorsLog.EnableHeadersVisualStyles = false;
            this.dgvVisitorsLog.Location = new System.Drawing.Point(17, 117);
            this.dgvVisitorsLog.MultiSelect = false;
            this.dgvVisitorsLog.Name = "dgvVisitorsLog";
            this.dgvVisitorsLog.ReadOnly = true;
            this.dgvVisitorsLog.RowHeadersVisible = false;
            this.dgvVisitorsLog.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvVisitorsLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisitorsLog.Size = new System.Drawing.Size(712, 501);
            this.dgvVisitorsLog.TabIndex = 23;
            this.dgvVisitorsLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            this.dgvVisitorsLog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplicants_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "VISITOR HISTORY";
            // 
            // gbAddVisitor
            // 
            this.gbAddVisitor.Controls.Add(this.btnSave);
            this.gbAddVisitor.Controls.Add(this.dtpDateOfVisit);
            this.gbAddVisitor.Controls.Add(this.dtpTimeOut);
            this.gbAddVisitor.Controls.Add(this.label4);
            this.gbAddVisitor.Controls.Add(this.label3);
            this.gbAddVisitor.Controls.Add(this.dtpTimeIn);
            this.gbAddVisitor.Controls.Add(this.label11);
            this.gbAddVisitor.Controls.Add(this.tbPurpose);
            this.gbAddVisitor.Controls.Add(this.tbCompany);
            this.gbAddVisitor.Controls.Add(this.tbName);
            this.gbAddVisitor.Controls.Add(this.label6);
            this.gbAddVisitor.Controls.Add(this.label2);
            this.gbAddVisitor.Controls.Add(this.label1);
            this.gbAddVisitor.Location = new System.Drawing.Point(747, 41);
            this.gbAddVisitor.Name = "gbAddVisitor";
            this.gbAddVisitor.Size = new System.Drawing.Size(378, 577);
            this.gbAddVisitor.TabIndex = 24;
            this.gbAddVisitor.TabStop = false;
            this.gbAddVisitor.Text = "NEW VISITOR";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSave.BorderRadius = 40;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(189, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDateOfVisit
            // 
            this.dtpDateOfVisit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfVisit.Location = new System.Drawing.Point(27, 338);
            this.dtpDateOfVisit.Name = "dtpDateOfVisit";
            this.dtpDateOfVisit.Size = new System.Drawing.Size(332, 27);
            this.dtpDateOfVisit.TabIndex = 4;
            // 
            // dtpTimeOut
            // 
            this.dtpTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeOut.Location = new System.Drawing.Point(27, 271);
            this.dtpTimeOut.Name = "dtpTimeOut";
            this.dtpTimeOut.Size = new System.Drawing.Size(332, 27);
            this.dtpTimeOut.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4.Location = new System.Drawing.Point(23, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 54;
            this.label4.Text = "DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label3.Location = new System.Drawing.Point(23, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "TIME OUT";
            // 
            // dtpTimeIn
            // 
            this.dtpTimeIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeIn.Location = new System.Drawing.Point(27, 204);
            this.dtpTimeIn.Name = "dtpTimeIn";
            this.dtpTimeIn.Size = new System.Drawing.Size(332, 27);
            this.dtpTimeIn.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label11.Location = new System.Drawing.Point(23, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 52;
            this.label11.Text = "TIME IN";
            // 
            // tbPurpose
            // 
            this.tbPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPurpose.Location = new System.Drawing.Point(27, 405);
            this.tbPurpose.Multiline = true;
            this.tbPurpose.Name = "tbPurpose";
            this.tbPurpose.Size = new System.Drawing.Size(332, 108);
            this.tbPurpose.TabIndex = 5;
            // 
            // tbCompany
            // 
            this.tbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCompany.Location = new System.Drawing.Point(27, 137);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(332, 27);
            this.tbCompany.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbName.Location = new System.Drawing.Point(27, 70);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(332, 27);
            this.tbName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label6.Location = new System.Drawing.Point(23, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "PURPOSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label2.Location = new System.Drawing.Point(23, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "COMPANY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = "NAME";
            // 
            // btnDeleteLog
            // 
            this.btnDeleteLog.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnDeleteLog.Location = new System.Drawing.Point(600, 77);
            this.btnDeleteLog.Name = "btnDeleteLog";
            this.btnDeleteLog.Size = new System.Drawing.Size(129, 31);
            this.btnDeleteLog.TabIndex = 25;
            this.btnDeleteLog.Text = "Delete item";
            this.btnDeleteLog.UseVisualStyleBackColor = true;
            this.btnDeleteLog.Click += new System.EventHandler(this.btnDeleteLog_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnPrint.Location = new System.Drawing.Point(17, 77);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(129, 31);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "Print report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // VisitorsLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1535, 655);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDeleteLog);
            this.Controls.Add(this.gbAddVisitor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvVisitorsLog);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "VisitorsLog";
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.Manage_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitorsLog)).EndInit();
            this.gbAddVisitor.ResumeLayout(false);
            this.gbAddVisitor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVisitorsLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbAddVisitor;
        private System.Windows.Forms.DateTimePicker dtpTimeIn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTimeOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateOfVisit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPurpose;
        private System.Windows.Forms.Label label6;
        private CustomControls.RoundedButton btnSave;
        private System.Windows.Forms.Button btnDeleteLog;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}