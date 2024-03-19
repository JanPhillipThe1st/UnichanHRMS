namespace UnichanHRMS.Screens
{
    partial class HireDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HireDialog));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbBatchNumber = new System.Windows.Forms.ComboBox();
            this.lblHiringMessage = new System.Windows.Forms.Label();
            this.dtpOrientationDate = new System.Windows.Forms.DateTimePicker();
            this.mtbSSS = new System.Windows.Forms.MaskedTextBox();
            this.mtbPhilHealth = new System.Windows.Forms.MaskedTextBox();
            this.mtbPagIbig = new System.Windows.Forms.MaskedTextBox();
            this.mtbTIN = new System.Windows.Forms.MaskedTextBox();
            this.btnClear = new UnichanHRMS.CustomControls.RoundedButton();
            this.btnSave = new UnichanHRMS.CustomControls.RoundedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(324, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "HIRING APPLICANT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 77);
            this.panel1.TabIndex = 25;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(829, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(58, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "SSS Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label2.Location = new System.Drawing.Point(58, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "PhilHealth Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label3.Location = new System.Drawing.Point(439, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "TIN Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4.Location = new System.Drawing.Point(439, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Pag-ibig Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label9.Location = new System.Drawing.Point(439, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Orientation Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label12.Location = new System.Drawing.Point(58, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 22);
            this.label12.TabIndex = 59;
            this.label12.Text = "Batch Number";
            // 
            // cbBatchNumber
            // 
            this.cbBatchNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBatchNumber.FormattingEnabled = true;
            this.cbBatchNumber.Location = new System.Drawing.Point(62, 192);
            this.cbBatchNumber.Name = "cbBatchNumber";
            this.cbBatchNumber.Size = new System.Drawing.Size(353, 30);
            this.cbBatchNumber.TabIndex = 60;
            // 
            // lblHiringMessage
            // 
            this.lblHiringMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHiringMessage.AutoSize = true;
            this.lblHiringMessage.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiringMessage.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHiringMessage.Location = new System.Drawing.Point(12, 80);
            this.lblHiringMessage.Name = "lblHiringMessage";
            this.lblHiringMessage.Size = new System.Drawing.Size(108, 22);
            this.lblHiringMessage.TabIndex = 3;
            this.lblHiringMessage.Text = "**message**";
            this.lblHiringMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpOrientationDate
            // 
            this.dtpOrientationDate.Location = new System.Drawing.Point(443, 318);
            this.dtpOrientationDate.Name = "dtpOrientationDate";
            this.dtpOrientationDate.Size = new System.Drawing.Size(353, 27);
            this.dtpOrientationDate.TabIndex = 61;
            // 
            // mtbSSS
            // 
            this.mtbSSS.Location = new System.Drawing.Point(62, 255);
            this.mtbSSS.Mask = "000-00-00000";
            this.mtbSSS.Name = "mtbSSS";
            this.mtbSSS.Size = new System.Drawing.Size(353, 27);
            this.mtbSSS.TabIndex = 62;
            // 
            // mtbPhilHealth
            // 
            this.mtbPhilHealth.Location = new System.Drawing.Point(62, 318);
            this.mtbPhilHealth.Mask = "00-000000000-A";
            this.mtbPhilHealth.Name = "mtbPhilHealth";
            this.mtbPhilHealth.Size = new System.Drawing.Size(353, 27);
            this.mtbPhilHealth.TabIndex = 63;
            // 
            // mtbPagIbig
            // 
            this.mtbPagIbig.Location = new System.Drawing.Point(443, 192);
            this.mtbPagIbig.Mask = "0000-0000-0000";
            this.mtbPagIbig.Name = "mtbPagIbig";
            this.mtbPagIbig.Size = new System.Drawing.Size(353, 27);
            this.mtbPagIbig.TabIndex = 64;
            // 
            // mtbTIN
            // 
            this.mtbTIN.Location = new System.Drawing.Point(443, 255);
            this.mtbTIN.Mask = "000-000-000-000";
            this.mtbTIN.Name = "mtbTIN";
            this.mtbTIN.Size = new System.Drawing.Size(353, 27);
            this.mtbTIN.TabIndex = 65;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnClear.BorderRadius = 40;
            this.btnClear.BorderSize = 2;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClear.Location = new System.Drawing.Point(490, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSave.BorderRadius = 40;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(646, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // HireDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 434);
            this.Controls.Add(this.mtbTIN);
            this.Controls.Add(this.mtbPagIbig);
            this.Controls.Add(this.mtbPhilHealth);
            this.Controls.Add(this.mtbSSS);
            this.Controls.Add(this.dtpOrientationDate);
            this.Controls.Add(this.lblHiringMessage);
            this.Controls.Add(this.cbBatchNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HireDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddApplicant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private CustomControls.RoundedButton btnSave;
        private CustomControls.RoundedButton btnClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbBatchNumber;
        private System.Windows.Forms.Label lblHiringMessage;
        private System.Windows.Forms.DateTimePicker dtpOrientationDate;
        private System.Windows.Forms.MaskedTextBox mtbSSS;
        private System.Windows.Forms.MaskedTextBox mtbPhilHealth;
        private System.Windows.Forms.MaskedTextBox mtbPagIbig;
        private System.Windows.Forms.MaskedTextBox mtbTIN;
    }
}