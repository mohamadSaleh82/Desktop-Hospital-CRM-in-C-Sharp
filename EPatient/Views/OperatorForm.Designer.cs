﻿namespace EPatient.Views
{
    partial class OperatorForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.timetablesMenuButton = new System.Windows.Forms.Button();
            this.patientsMenuButton = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.reservationsMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.timetablesMenuButton);
            this.panel2.Controls.Add(this.patientsMenuButton);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.reservationsMenuButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(27, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 678);
            this.panel2.TabIndex = 2;
            // 
            // timetablesMenuButton
            // 
            this.timetablesMenuButton.FlatAppearance.BorderSize = 0;
            this.timetablesMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timetablesMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetablesMenuButton.ForeColor = System.Drawing.Color.White;
            this.timetablesMenuButton.Image = global::EPatient.Properties.Resources.calendar_icon;
            this.timetablesMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timetablesMenuButton.Location = new System.Drawing.Point(4, 305);
            this.timetablesMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.timetablesMenuButton.Name = "timetablesMenuButton";
            this.timetablesMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timetablesMenuButton.Size = new System.Drawing.Size(300, 66);
            this.timetablesMenuButton.TabIndex = 9;
            this.timetablesMenuButton.Text = "برنامه";
            this.timetablesMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timetablesMenuButton.UseVisualStyleBackColor = true;
            this.timetablesMenuButton.Click += new System.EventHandler(this.timetablesMenuButton_Click);
            // 
            // patientsMenuButton
            // 
            this.patientsMenuButton.FlatAppearance.BorderSize = 0;
            this.patientsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientsMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsMenuButton.ForeColor = System.Drawing.Color.White;
            this.patientsMenuButton.Image = global::EPatient.Properties.Resources.users_icon;
            this.patientsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsMenuButton.Location = new System.Drawing.Point(8, 130);
            this.patientsMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.patientsMenuButton.Name = "patientsMenuButton";
            this.patientsMenuButton.Size = new System.Drawing.Size(300, 66);
            this.patientsMenuButton.TabIndex = 7;
            this.patientsMenuButton.Text = "بیمار";
            this.patientsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientsMenuButton.UseVisualStyleBackColor = true;
            this.patientsMenuButton.Click += new System.EventHandler(this.patientsMenuButton_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 640);
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
            this.labelName.Location = new System.Drawing.Point(112, 711);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 33);
            this.labelName.TabIndex = 8;
            // 
            // reservationsMenuButton
            // 
            this.reservationsMenuButton.FlatAppearance.BorderSize = 0;
            this.reservationsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationsMenuButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsMenuButton.ForeColor = System.Drawing.Color.White;
            this.reservationsMenuButton.Image = global::EPatient.Properties.Resources.addressbook_icon;
            this.reservationsMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationsMenuButton.Location = new System.Drawing.Point(8, 215);
            this.reservationsMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.reservationsMenuButton.Name = "reservationsMenuButton";
            this.reservationsMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reservationsMenuButton.Size = new System.Drawing.Size(300, 66);
            this.reservationsMenuButton.TabIndex = 6;
            this.reservationsMenuButton.Text = "رزرو";
            this.reservationsMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reservationsMenuButton.UseVisualStyleBackColor = true;
            this.reservationsMenuButton.Click += new System.EventHandler(this.reservationsMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "پنل کارکنان";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 12;
            this.mainPanel.Location = new System.Drawing.Point(335, 74);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1238, 678);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 13;
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 777);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OperatorForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "پنل کارکنان";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OperatorForm_FormClosing);
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button patientsMenuButton;
        private System.Windows.Forms.Button reservationsMenuButton;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button timetablesMenuButton;
    }
}