namespace UnichanHRMS.Screens
{
    partial class EditApplicant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditApplicant));
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpApplicationDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpInitialInterviewDate = new System.Windows.Forms.Label();
            this.dtpFinalInterviewDate = new System.Windows.Forms.Label();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.roundedButton1 = new UnichanHRMS.CustomControls.RoundedButton();
            this.btnHire = new UnichanHRMS.CustomControls.RoundedButton();
            this.btnScheduleInitiralInterview = new UnichanHRMS.CustomControls.RoundedButton();
            this.btnScheduleFinalinterview = new UnichanHRMS.CustomControls.RoundedButton();
            this.btnClear = new UnichanHRMS.CustomControls.RoundedButton();
            this.btnSave = new UnichanHRMS.CustomControls.RoundedButton();
            this.btnRequirementBriefing = new UnichanHRMS.CustomControls.RoundedButton();
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
            this.label5.Location = new System.Drawing.Point(332, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "EDIT APPLICANT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 42);
            this.panel1.TabIndex = 25;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(803, 0);
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
            this.label1.Location = new System.Drawing.Point(44, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label2.Location = new System.Drawing.Point(44, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Middle name";
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(48, 142);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(353, 27);
            this.tbFirstname.TabIndex = 0;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(48, 205);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(353, 27);
            this.tbMiddleName.TabIndex = 1;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(48, 331);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(353, 27);
            this.tbAge.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(48, 268);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(353, 27);
            this.tbLastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label3.Location = new System.Drawing.Point(44, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4.Location = new System.Drawing.Point(44, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Last name";
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(432, 142);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(353, 27);
            this.tbContact.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label8.Location = new System.Drawing.Point(428, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Contact";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label11.Location = new System.Drawing.Point(428, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 22);
            this.label11.TabIndex = 48;
            this.label11.Text = "Application Date";
            // 
            // dtpApplicationDate
            // 
            this.dtpApplicationDate.Location = new System.Drawing.Point(432, 271);
            this.dtpApplicationDate.Name = "dtpApplicationDate";
            this.dtpApplicationDate.Size = new System.Drawing.Size(353, 27);
            this.dtpApplicationDate.TabIndex = 6;
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Location = new System.Drawing.Point(432, 334);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Size = new System.Drawing.Size(353, 27);
            this.dtpExamDate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label6.Location = new System.Drawing.Point(428, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 54;
            this.label6.Text = "Exam Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label7.Location = new System.Drawing.Point(428, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Initial Interview Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label10.Location = new System.Drawing.Point(428, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 22);
            this.label10.TabIndex = 58;
            this.label10.Text = "Final Interview Date";
            // 
            // dtpInitialInterviewDate
            // 
            this.dtpInitialInterviewDate.AutoSize = true;
            this.dtpInitialInterviewDate.Font = new System.Drawing.Font("Montserrat", 12F);
            this.dtpInitialInterviewDate.Location = new System.Drawing.Point(428, 399);
            this.dtpInitialInterviewDate.Name = "dtpInitialInterviewDate";
            this.dtpInitialInterviewDate.Size = new System.Drawing.Size(174, 22);
            this.dtpInitialInterviewDate.TabIndex = 56;
            this.dtpInitialInterviewDate.Text = "Initial Interview Date";
            // 
            // dtpFinalInterviewDate
            // 
            this.dtpFinalInterviewDate.AutoSize = true;
            this.dtpFinalInterviewDate.Font = new System.Drawing.Font("Montserrat", 12F);
            this.dtpFinalInterviewDate.Location = new System.Drawing.Point(428, 460);
            this.dtpFinalInterviewDate.Name = "dtpFinalInterviewDate";
            this.dtpFinalInterviewDate.Size = new System.Drawing.Size(174, 22);
            this.dtpFinalInterviewDate.TabIndex = 56;
            this.dtpFinalInterviewDate.Text = "Initial Interview Date";
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdate.Location = new System.Drawing.Point(432, 208);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(353, 27);
            this.dtpBirthdate.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label12.Location = new System.Drawing.Point(428, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 22);
            this.label12.TabIndex = 63;
            this.label12.Text = "Birth Date";
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(48, 398);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(353, 30);
            this.cbGender.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label13.Location = new System.Drawing.Point(44, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 22);
            this.label13.TabIndex = 65;
            this.label13.Text = "Gender";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblRemarks.Location = new System.Drawing.Point(44, 436);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(85, 22);
            this.lblRemarks.TabIndex = 68;
            this.lblRemarks.Text = "Remarks:";
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(48, 461);
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(353, 96);
            this.tbRemarks.TabIndex = 69;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundedButton1.BorderColor = System.Drawing.Color.Red;
            this.roundedButton1.BorderRadius = 40;
            this.roundedButton1.BorderSize = 2;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.Red;
            this.roundedButton1.Image = ((System.Drawing.Image)(resources.GetObject("roundedButton1.Image")));
            this.roundedButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.roundedButton1.Location = new System.Drawing.Point(34, 57);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(244, 38);
            this.roundedButton1.TabIndex = 64;
            this.roundedButton1.Text = "REJECT APPLICANT";
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // btnHire
            // 
            this.btnHire.BackColor = System.Drawing.Color.Transparent;
            this.btnHire.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHire.BorderRadius = 40;
            this.btnHire.BorderSize = 2;
            this.btnHire.FlatAppearance.BorderSize = 0;
            this.btnHire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHire.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHire.Image = ((System.Drawing.Image)(resources.GetObject("btnHire.Image")));
            this.btnHire.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHire.Location = new System.Drawing.Point(561, 57);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(224, 38);
            this.btnHire.TabIndex = 61;
            this.btnHire.Text = "HIRE APPLICANT";
            this.btnHire.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHire.UseVisualStyleBackColor = false;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // btnScheduleInitiralInterview
            // 
            this.btnScheduleInitiralInterview.BackColor = System.Drawing.Color.Transparent;
            this.btnScheduleInitiralInterview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnScheduleInitiralInterview.BorderRadius = 40;
            this.btnScheduleInitiralInterview.BorderSize = 2;
            this.btnScheduleInitiralInterview.FlatAppearance.BorderSize = 0;
            this.btnScheduleInitiralInterview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleInitiralInterview.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleInitiralInterview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnScheduleInitiralInterview.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduleInitiralInterview.Image")));
            this.btnScheduleInitiralInterview.ImageSize = new System.Drawing.Size(30, 30);
            this.btnScheduleInitiralInterview.Location = new System.Drawing.Point(48, 579);
            this.btnScheduleInitiralInterview.Name = "btnScheduleInitiralInterview";
            this.btnScheduleInitiralInterview.Size = new System.Drawing.Size(314, 38);
            this.btnScheduleInitiralInterview.TabIndex = 60;
            this.btnScheduleInitiralInterview.Text = "SCHEDULE INITIAL INTERVIEW";
            this.btnScheduleInitiralInterview.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnScheduleInitiralInterview.UseVisualStyleBackColor = false;
            this.btnScheduleInitiralInterview.Click += new System.EventHandler(this.btnScheduleInitiralInterview_Click);
            // 
            // btnScheduleFinalinterview
            // 
            this.btnScheduleFinalinterview.BackColor = System.Drawing.Color.Transparent;
            this.btnScheduleFinalinterview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnScheduleFinalinterview.BorderRadius = 40;
            this.btnScheduleFinalinterview.BorderSize = 2;
            this.btnScheduleFinalinterview.FlatAppearance.BorderSize = 0;
            this.btnScheduleFinalinterview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleFinalinterview.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleFinalinterview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnScheduleFinalinterview.Image = ((System.Drawing.Image)(resources.GetObject("btnScheduleFinalinterview.Image")));
            this.btnScheduleFinalinterview.ImageSize = new System.Drawing.Size(30, 30);
            this.btnScheduleFinalinterview.Location = new System.Drawing.Point(48, 623);
            this.btnScheduleFinalinterview.Name = "btnScheduleFinalinterview";
            this.btnScheduleFinalinterview.Size = new System.Drawing.Size(314, 38);
            this.btnScheduleFinalinterview.TabIndex = 59;
            this.btnScheduleFinalinterview.Text = "SCHEDULE FINAL INTERVIEW";
            this.btnScheduleFinalinterview.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnScheduleFinalinterview.UseVisualStyleBackColor = false;
            this.btnScheduleFinalinterview.Click += new System.EventHandler(this.btnScheduleFinalinterview_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnClear.BorderRadius = 40;
            this.btnClear.BorderSize = 2;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClear.Location = new System.Drawing.Point(459, 621);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "DELETE";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btnSave.BorderRadius = 40;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(625, 621);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "UPDATE";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRequirementBriefing
            // 
            this.btnRequirementBriefing.BackColor = System.Drawing.Color.Transparent;
            this.btnRequirementBriefing.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnRequirementBriefing.BorderRadius = 40;
            this.btnRequirementBriefing.BorderSize = 2;
            this.btnRequirementBriefing.FlatAppearance.BorderSize = 0;
            this.btnRequirementBriefing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequirementBriefing.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequirementBriefing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRequirementBriefing.Image = ((System.Drawing.Image)(resources.GetObject("btnRequirementBriefing.Image")));
            this.btnRequirementBriefing.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRequirementBriefing.Location = new System.Drawing.Point(48, 666);
            this.btnRequirementBriefing.Name = "btnRequirementBriefing";
            this.btnRequirementBriefing.Size = new System.Drawing.Size(314, 38);
            this.btnRequirementBriefing.TabIndex = 59;
            this.btnRequirementBriefing.Text = "SCHEDULE REQUIREMENTS BRIEFING";
            this.btnRequirementBriefing.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRequirementBriefing.UseVisualStyleBackColor = false;
            this.btnRequirementBriefing.Click += new System.EventHandler(this.btnRequirementBriefing_Click);
            // 
            // EditApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 716);
            this.Controls.Add(this.tbRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.dtpBirthdate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.btnScheduleInitiralInterview);
            this.Controls.Add(this.btnRequirementBriefing);
            this.Controls.Add(this.btnScheduleFinalinterview);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpFinalInterviewDate);
            this.Controls.Add(this.dtpInitialInterviewDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpExamDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpApplicationDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditApplicant";
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
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpApplicationDate;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private CustomControls.RoundedButton btnSave;
        private CustomControls.RoundedButton btnClear;
        private CustomControls.RoundedButton btnScheduleFinalinterview;
        private System.Windows.Forms.Label dtpInitialInterviewDate;
        private System.Windows.Forms.Label dtpFinalInterviewDate;
        private CustomControls.RoundedButton btnScheduleInitiralInterview;
        private CustomControls.RoundedButton btnHire;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.Label label12;
        private CustomControls.RoundedButton roundedButton1;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox tbRemarks;
        private CustomControls.RoundedButton btnRequirementBriefing;
    }
}