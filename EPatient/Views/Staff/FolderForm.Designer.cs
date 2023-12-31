﻿using System.Drawing;
using System.Windows.Forms;

namespace EPatient.Views.Staff
{
    partial class FolderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAllergies = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.Label();
            this.textGender = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.Label();
            this.textBirthday = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridViewFolder = new MetroFramework.Controls.MetroGrid();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDiagnose = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAllergies);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textPhone);
            this.groupBox1.Controls.Add(this.textGender);
            this.groupBox1.Controls.Add(this.textSurname);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBirthday);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(143, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1152, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات بیمار";
            // 
            // textBoxAllergies
            // 
            this.textBoxAllergies.Location = new System.Drawing.Point(81, 23);
            this.textBoxAllergies.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAllergies.Multiline = true;
            this.textBoxAllergies.Name = "textBoxAllergies";
            this.textBoxAllergies.ReadOnly = true;
            this.textBoxAllergies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAllergies.Size = new System.Drawing.Size(167, 85);
            this.textBoxAllergies.TabIndex = 13;
            // 
            // textEmail
            // 
            this.textEmail.AutoSize = true;
            this.textEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(334, 75);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(0, 18);
            this.textEmail.TabIndex = 12;
            // 
            // textPhone
            // 
            this.textPhone.AutoSize = true;
            this.textPhone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(396, 34);
            this.textPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(0, 18);
            this.textPhone.TabIndex = 11;
            // 
            // textGender
            // 
            this.textGender.AutoSize = true;
            this.textGender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGender.Location = new System.Drawing.Point(743, 75);
            this.textGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(0, 18);
            this.textGender.TabIndex = 10;
            // 
            // textSurname
            // 
            this.textSurname.AutoSize = true;
            this.textSurname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSurname.Location = new System.Drawing.Point(956, 75);
            this.textSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(0, 18);
            this.textSurname.TabIndex = 8;
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(1070, 34);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(0, 18);
            this.textName.TabIndex = 7;
            // 
            // textBirthday
            // 
            this.textBirthday.AutoSize = true;
            this.textBirthday.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBirthday.Location = new System.Drawing.Point(743, 34);
            this.textBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textBirthday.Name = "textBirthday";
            this.textBirthday.Size = new System.Drawing.Size(0, 18);
            this.textBirthday.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "آلرژی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "ایمیل :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "تلفن اضطراری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1051, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام خانوادگی :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "جنسیت :";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(774, 34);
            this.text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(68, 18);
            this.text.TabIndex = 2;
            this.text.Text = "روز تولد :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1110, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridViewFolder);
            this.panel1.Location = new System.Drawing.Point(143, 327);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 506);
            this.panel1.TabIndex = 1;
            // 
            // gridViewFolder
            // 
            this.gridViewFolder.AllowUserToAddRows = false;
            this.gridViewFolder.AllowUserToDeleteRows = false;
            this.gridViewFolder.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.gridViewFolder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gridViewFolder.BackgroundColor = System.Drawing.Color.White;
            this.gridViewFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewFolder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewFolder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewFolder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridViewFolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewFolder.DefaultCellStyle = dataGridViewCellStyle13;
            this.gridViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewFolder.EnableHeadersVisualStyles = false;
            this.gridViewFolder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewFolder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewFolder.Location = new System.Drawing.Point(0, 0);
            this.gridViewFolder.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewFolder.Name = "gridViewFolder";
            this.gridViewFolder.ReadOnly = true;
            this.gridViewFolder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewFolder.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gridViewFolder.RowHeadersWidth = 51;
            this.gridViewFolder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewFolder.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gridViewFolder.RowTemplate.Height = 30;
            this.gridViewFolder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewFolder.Size = new System.Drawing.Size(1152, 506);
            this.gridViewFolder.TabIndex = 0;
            this.gridViewFolder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewFolder_CellClick);
            this.gridViewFolder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewFolder_CellContentClick);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnShow.Location = new System.Drawing.Point(143, 256);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 37);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "ویزیت";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDiagnose
            // 
            this.btnDiagnose.BackColor = System.Drawing.Color.White;
            this.btnDiagnose.Enabled = false;
            this.btnDiagnose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnDiagnose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnDiagnose.Location = new System.Drawing.Point(271, 256);
            this.btnDiagnose.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiagnose.Name = "btnDiagnose";
            this.btnDiagnose.Size = new System.Drawing.Size(120, 37);
            this.btnDiagnose.TabIndex = 3;
            this.btnDiagnose.Text = "تشخیص";
            this.btnDiagnose.UseVisualStyleBackColor = false;
            this.btnDiagnose.Click += new System.EventHandler(this.btnDiagnose_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Enabled = false;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.Green;
            this.btnDone.Location = new System.Drawing.Point(403, 256);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(120, 37);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "ترخیص";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnPrint.Location = new System.Drawing.Point(531, 256);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(137, 37);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "چاپ کارت";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 862);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDiagnose);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FolderForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "کارت";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.Label textBirthday;
        private System.Windows.Forms.Label textSurname;
        private System.Windows.Forms.Label textEmail;
        private System.Windows.Forms.Label textPhone;
        private System.Windows.Forms.Label textGender;
        private System.Windows.Forms.TextBox textBoxAllergies;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid gridViewFolder;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDiagnose;
        private System.Windows.Forms.Button btnDone;
        private Button btnPrint;
    }
}