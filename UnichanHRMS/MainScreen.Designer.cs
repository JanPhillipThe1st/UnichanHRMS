namespace UnichanHRMS
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuBottom = new System.Windows.Forms.Panel();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVisitorsLog = new UnichanHRMS.CustomControls.RoundedButton();
            this.btnManageApplicants = new UnichanHRMS.CustomControls.RoundedButton();
            this.btnLogout = new UnichanHRMS.CustomControls.RoundedButton();
            this.btnEmployees = new UnichanHRMS.CustomControls.RoundedButton();
            this.panelMenu.SuspendLayout();
            this.panelMenuBottom.SuspendLayout();
            this.panelBanner.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnVisitorsLog);
            this.panelMenu.Controls.Add(this.btnManageApplicants);
            this.panelMenu.Controls.Add(this.panelMenuBottom);
            this.panelMenu.Controls.Add(this.btnEmployees);
            this.panelMenu.Controls.Add(this.panelBanner);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(233, 744);
            this.panelMenu.TabIndex = 0;
            // 
            // panelMenuBottom
            // 
            this.panelMenuBottom.Controls.Add(this.btnLogout);
            this.panelMenuBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuBottom.Location = new System.Drawing.Point(0, 160);
            this.panelMenuBottom.Name = "panelMenuBottom";
            this.panelMenuBottom.Size = new System.Drawing.Size(233, 584);
            this.panelMenuBottom.TabIndex = 5;
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panelBanner.Controls.Add(this.btnExit);
            this.panelBanner.Controls.Add(this.label5);
            this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(233, 100);
            this.panelBanner.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(704, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(20, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 58);
            this.label5.TabIndex = 0;
            this.label5.Text = "UNICHAN \r\nINCORPORATED";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(233, 39);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1427, 705);
            this.panelMain.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.lblDateTime);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.lblWelcome);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(233, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1427, 39);
            this.panelTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1070, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(1127, 8);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(24, 22);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "**";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(102, 8);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(24, 22);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "**";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnVisitorsLog
            // 
            this.btnVisitorsLog.BackColor = System.Drawing.Color.Gold;
            this.btnVisitorsLog.BorderColor = System.Drawing.Color.Orange;
            this.btnVisitorsLog.BorderRadius = 15;
            this.btnVisitorsLog.BorderSize = 1;
            this.btnVisitorsLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisitorsLog.FlatAppearance.BorderSize = 0;
            this.btnVisitorsLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitorsLog.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitorsLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnVisitorsLog.Image = ((System.Drawing.Image)(resources.GetObject("btnVisitorsLog.Image")));
            this.btnVisitorsLog.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVisitorsLog.Location = new System.Drawing.Point(0, 220);
            this.btnVisitorsLog.Name = "btnVisitorsLog";
            this.btnVisitorsLog.Size = new System.Drawing.Size(233, 60);
            this.btnVisitorsLog.TabIndex = 1;
            this.btnVisitorsLog.Text = "Visitor\'s Log";
            this.btnVisitorsLog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVisitorsLog.UseVisualStyleBackColor = false;
            this.btnVisitorsLog.Click += new System.EventHandler(this.btnVisitorsLog_Click);
            // 
            // btnManageApplicants
            // 
            this.btnManageApplicants.BackColor = System.Drawing.Color.Gold;
            this.btnManageApplicants.BorderColor = System.Drawing.Color.Orange;
            this.btnManageApplicants.BorderRadius = 15;
            this.btnManageApplicants.BorderSize = 1;
            this.btnManageApplicants.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageApplicants.FlatAppearance.BorderSize = 0;
            this.btnManageApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageApplicants.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageApplicants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnManageApplicants.Image = ((System.Drawing.Image)(resources.GetObject("btnManageApplicants.Image")));
            this.btnManageApplicants.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageApplicants.Location = new System.Drawing.Point(0, 160);
            this.btnManageApplicants.Name = "btnManageApplicants";
            this.btnManageApplicants.Size = new System.Drawing.Size(233, 60);
            this.btnManageApplicants.TabIndex = 7;
            this.btnManageApplicants.Text = "Applicants";
            this.btnManageApplicants.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnManageApplicants.UseVisualStyleBackColor = false;
            this.btnManageApplicants.Click += new System.EventHandler(this.btnManageApplicants_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnLogout.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(0, 527);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(233, 57);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Gold;
            this.btnEmployees.BorderColor = System.Drawing.Color.Orange;
            this.btnEmployees.BorderRadius = 15;
            this.btnEmployees.BorderSize = 1;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmployees.Location = new System.Drawing.Point(0, 100);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(233, 60);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1660, 744);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuBottom.ResumeLayout(false);
            this.panelBanner.ResumeLayout(false);
            this.panelBanner.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private CustomControls.RoundedButton btnEmployees;
        private CustomControls.RoundedButton btnVisitorsLog;
        private System.Windows.Forms.Panel panelMenuBottom;
        private CustomControls.RoundedButton btnLogout;
        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelMain;
        private CustomControls.RoundedButton btnManageApplicants;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}