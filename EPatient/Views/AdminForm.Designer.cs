namespace EPatient.Views
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.pavilionsMenuButton = new System.Windows.Forms.Button();
            this.advancedReportsMenuButton = new System.Windows.Forms.Button();
            this.basicReportsMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.servicesMenuButton = new System.Windows.Forms.Button();
            this.emergencyDoctorMenuButton = new System.Windows.Forms.Button();
            this.workingHoursMenuButton = new System.Windows.Forms.Button();
            this.usersMenuButton = new System.Windows.Forms.Button();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.pavilionsMenuButton);
            this.panel2.Controls.Add(this.advancedReportsMenuButton);
            this.panel2.Controls.Add(this.basicReportsMenuButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.servicesMenuButton);
            this.panel2.Controls.Add(this.emergencyDoctorMenuButton);
            this.panel2.Controls.Add(this.workingHoursMenuButton);
            this.panel2.Controls.Add(this.usersMenuButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1123, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 763);
            this.panel2.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 725);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(308, 38);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "خروج";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Location = new System.Drawing.Point(53, 711);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 33);
            this.labelName.TabIndex = 8;
            // 
            // pavilionsMenuButton
            // 
            this.pavilionsMenuButton.FlatAppearance.BorderSize = 0;
            this.pavilionsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pavilionsMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pavilionsMenuButton.ForeColor = System.Drawing.Color.White;
            this.pavilionsMenuButton.Image = global::EPatient.Properties.Resources.hospital_icon;
            this.pavilionsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pavilionsMenuButton.Location = new System.Drawing.Point(4, 421);
            this.pavilionsMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.pavilionsMenuButton.Name = "pavilionsMenuButton";
            this.pavilionsMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pavilionsMenuButton.Size = new System.Drawing.Size(300, 66);
            this.pavilionsMenuButton.TabIndex = 7;
            this.pavilionsMenuButton.Text = "بخش ها";
            this.pavilionsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pavilionsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pavilionsMenuButton.UseVisualStyleBackColor = true;
            this.pavilionsMenuButton.Click += new System.EventHandler(this.pavilionsMenuButton_Click);
            // 
            // advancedReportsMenuButton
            // 
            this.advancedReportsMenuButton.FlatAppearance.BorderSize = 0;
            this.advancedReportsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advancedReportsMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedReportsMenuButton.ForeColor = System.Drawing.Color.White;
            this.advancedReportsMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("advancedReportsMenuButton.Image")));
            this.advancedReportsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.advancedReportsMenuButton.Location = new System.Drawing.Point(4, 554);
            this.advancedReportsMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.advancedReportsMenuButton.Name = "advancedReportsMenuButton";
            this.advancedReportsMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.advancedReportsMenuButton.Size = new System.Drawing.Size(300, 66);
            this.advancedReportsMenuButton.TabIndex = 6;
            this.advancedReportsMenuButton.Text = "گزارش های پیشرفته";
            this.advancedReportsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.advancedReportsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.advancedReportsMenuButton.UseVisualStyleBackColor = true;
            this.advancedReportsMenuButton.Click += new System.EventHandler(this.advancedReportsMenuButton_Click);
            // 
            // basicReportsMenuButton
            // 
            this.basicReportsMenuButton.FlatAppearance.BorderSize = 0;
            this.basicReportsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicReportsMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicReportsMenuButton.ForeColor = System.Drawing.Color.White;
            this.basicReportsMenuButton.Image = global::EPatient.Properties.Resources.chart_icon;
            this.basicReportsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.basicReportsMenuButton.Location = new System.Drawing.Point(0, 487);
            this.basicReportsMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.basicReportsMenuButton.Name = "basicReportsMenuButton";
            this.basicReportsMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.basicReportsMenuButton.Size = new System.Drawing.Size(304, 66);
            this.basicReportsMenuButton.TabIndex = 5;
            this.basicReportsMenuButton.Text = "گزارش ها";
            this.basicReportsMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.basicReportsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.basicReportsMenuButton.UseVisualStyleBackColor = true;
            this.basicReportsMenuButton.Click += new System.EventHandler(this.basicReportsMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "پنل مدیریت";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // servicesMenuButton
            // 
            this.servicesMenuButton.FlatAppearance.BorderSize = 0;
            this.servicesMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesMenuButton.ForeColor = System.Drawing.Color.White;
            this.servicesMenuButton.Image = global::EPatient.Properties.Resources.list_icon;
            this.servicesMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.servicesMenuButton.Location = new System.Drawing.Point(0, 354);
            this.servicesMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.servicesMenuButton.Name = "servicesMenuButton";
            this.servicesMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.servicesMenuButton.Size = new System.Drawing.Size(304, 66);
            this.servicesMenuButton.TabIndex = 3;
            this.servicesMenuButton.Text = "خدمات";
            this.servicesMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.servicesMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.servicesMenuButton.UseVisualStyleBackColor = true;
            this.servicesMenuButton.Click += new System.EventHandler(this.ServicesMenuButton_Click);
            // 
            // emergencyDoctorMenuButton
            // 
            this.emergencyDoctorMenuButton.FlatAppearance.BorderSize = 0;
            this.emergencyDoctorMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emergencyDoctorMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyDoctorMenuButton.ForeColor = System.Drawing.Color.White;
            this.emergencyDoctorMenuButton.Image = global::EPatient.Properties.Resources.emergency_icon;
            this.emergencyDoctorMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emergencyDoctorMenuButton.Location = new System.Drawing.Point(0, 288);
            this.emergencyDoctorMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.emergencyDoctorMenuButton.Name = "emergencyDoctorMenuButton";
            this.emergencyDoctorMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.emergencyDoctorMenuButton.Size = new System.Drawing.Size(304, 66);
            this.emergencyDoctorMenuButton.TabIndex = 2;
            this.emergencyDoctorMenuButton.Text = "شیفت ها";
            this.emergencyDoctorMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emergencyDoctorMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emergencyDoctorMenuButton.UseVisualStyleBackColor = true;
            this.emergencyDoctorMenuButton.Click += new System.EventHandler(this.EmergencyDoctorMenuButton_Click);
            // 
            // workingHoursMenuButton
            // 
            this.workingHoursMenuButton.FlatAppearance.BorderSize = 0;
            this.workingHoursMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workingHoursMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingHoursMenuButton.ForeColor = System.Drawing.Color.White;
            this.workingHoursMenuButton.Image = global::EPatient.Properties.Resources.calendar_icon;
            this.workingHoursMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.workingHoursMenuButton.Location = new System.Drawing.Point(0, 214);
            this.workingHoursMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.workingHoursMenuButton.Name = "workingHoursMenuButton";
            this.workingHoursMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.workingHoursMenuButton.Size = new System.Drawing.Size(308, 66);
            this.workingHoursMenuButton.TabIndex = 1;
            this.workingHoursMenuButton.Text = "جدول زمانی";
            this.workingHoursMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.workingHoursMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.workingHoursMenuButton.UseVisualStyleBackColor = true;
            this.workingHoursMenuButton.Click += new System.EventHandler(this.WorkingHoursMenuButton_Click);
            // 
            // usersMenuButton
            // 
            this.usersMenuButton.FlatAppearance.BorderSize = 0;
            this.usersMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersMenuButton.ForeColor = System.Drawing.Color.White;
            this.usersMenuButton.Image = global::EPatient.Properties.Resources.user_icon;
            this.usersMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usersMenuButton.Location = new System.Drawing.Point(0, 140);
            this.usersMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.usersMenuButton.Name = "usersMenuButton";
            this.usersMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usersMenuButton.Size = new System.Drawing.Size(308, 66);
            this.usersMenuButton.TabIndex = 0;
            this.usersMenuButton.Text = "کاربران";
            this.usersMenuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersMenuButton.UseVisualStyleBackColor = true;
            this.usersMenuButton.Click += new System.EventHandler(this.usersMenuButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSize = true;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 12;
            this.mainPanel.Location = new System.Drawing.Point(27, 74);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainPanel.Size = new System.Drawing.Size(1092, 763);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 13;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 862);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1458, 862);
            this.Name = "AdminForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "پنل مدیریت";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button usersMenuButton;
        private System.Windows.Forms.Button servicesMenuButton;
        private System.Windows.Forms.Button emergencyDoctorMenuButton;
        private System.Windows.Forms.Button workingHoursMenuButton;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private System.Windows.Forms.Button advancedReportsMenuButton;
        private System.Windows.Forms.Button basicReportsMenuButton;
        private System.Windows.Forms.Button pavilionsMenuButton;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelName;
    }
}