namespace EPatient.Views.Operator
{
    partial class AddReservationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSearchPatient = new MetroFramework.Controls.MetroTextBox();
            this.listBoxPatient = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPavilion = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridDoctorBusy = new MetroFramework.Controls.MetroGrid();
            this.comboBoxDoctors = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelDate = new MetroFramework.Controls.MetroLabel();
            this.labelService = new MetroFramework.Controls.MetroLabel();
            this.labelDoctor = new MetroFramework.Controls.MetroLabel();
            this.labelPatient = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctorBusy)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSearchPatient);
            this.groupBox1.Controls.Add(this.listBoxPatient);
            this.groupBox1.Location = new System.Drawing.Point(31, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(323, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بیمار";
            // 
            // textSearchPatient
            // 
            // 
            // 
            // 
            this.textSearchPatient.CustomButton.Image = null;
            this.textSearchPatient.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.textSearchPatient.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.textSearchPatient.CustomButton.Name = "";
            this.textSearchPatient.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textSearchPatient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textSearchPatient.CustomButton.TabIndex = 1;
            this.textSearchPatient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textSearchPatient.CustomButton.UseSelectable = true;
            this.textSearchPatient.CustomButton.Visible = false;
            this.textSearchPatient.Lines = new string[0];
            this.textSearchPatient.Location = new System.Drawing.Point(9, 25);
            this.textSearchPatient.Margin = new System.Windows.Forms.Padding(4);
            this.textSearchPatient.MaxLength = 32767;
            this.textSearchPatient.Name = "textSearchPatient";
            this.textSearchPatient.PasswordChar = '\0';
            this.textSearchPatient.PromptText = "جستجوی بیمار";
            this.textSearchPatient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textSearchPatient.SelectedText = "";
            this.textSearchPatient.SelectionLength = 0;
            this.textSearchPatient.SelectionStart = 0;
            this.textSearchPatient.ShortcutsEnabled = true;
            this.textSearchPatient.Size = new System.Drawing.Size(304, 28);
            this.textSearchPatient.TabIndex = 1;
            this.textSearchPatient.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textSearchPatient.UseSelectable = true;
            this.textSearchPatient.WaterMark = "جستجوی بیمار";
            this.textSearchPatient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textSearchPatient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textSearchPatient.TextChanged += new System.EventHandler(this.textSearchPatient_TextChanged);
            // 
            // listBoxPatient
            // 
            this.listBoxPatient.FormattingEnabled = true;
            this.listBoxPatient.ItemHeight = 16;
            this.listBoxPatient.Location = new System.Drawing.Point(8, 73);
            this.listBoxPatient.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPatient.Name = "listBoxPatient";
            this.listBoxPatient.Size = new System.Drawing.Size(304, 260);
            this.listBoxPatient.TabIndex = 0;
            this.listBoxPatient.SelectedIndexChanged += new System.EventHandler(this.listBoxPatient_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxPavilion);
            this.groupBox2.Controls.Add(this.datePicker);
            this.groupBox2.Controls.Add(this.listBoxService);
            this.groupBox2.Location = new System.Drawing.Point(385, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(323, 351);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تاریخ و خدمات";
            // 
            // comboBoxPavilion
            // 
            this.comboBoxPavilion.FormattingEnabled = true;
            this.comboBoxPavilion.Location = new System.Drawing.Point(8, 71);
            this.comboBoxPavilion.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPavilion.Name = "comboBoxPavilion";
            this.comboBoxPavilion.Size = new System.Drawing.Size(304, 24);
            this.comboBoxPavilion.TabIndex = 2;
            this.comboBoxPavilion.SelectedIndexChanged += new System.EventHandler(this.comboBoxPavilion_SelectedIndexChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(9, 25);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(304, 22);
            this.datePicker.TabIndex = 3;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // listBoxService
            // 
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.ItemHeight = 16;
            this.listBoxService.Location = new System.Drawing.Point(9, 105);
            this.listBoxService.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(304, 228);
            this.listBoxService.TabIndex = 2;
            this.listBoxService.SelectedIndexChanged += new System.EventHandler(this.listBoxService_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelHours);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.gridDoctorBusy);
            this.groupBox3.Controls.Add(this.comboBoxDoctors);
            this.groupBox3.Location = new System.Drawing.Point(733, 78);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(323, 351);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "دکتر";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(49, 318);
            this.labelHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(0, 16);
            this.labelHours.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ساعت ها:";
            // 
            // gridDoctorBusy
            // 
            this.gridDoctorBusy.AllowUserToResizeRows = false;
            this.gridDoctorBusy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDoctorBusy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDoctorBusy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDoctorBusy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDoctorBusy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.gridDoctorBusy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDoctorBusy.DefaultCellStyle = dataGridViewCellStyle26;
            this.gridDoctorBusy.EnableHeadersVisualStyles = false;
            this.gridDoctorBusy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDoctorBusy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDoctorBusy.Location = new System.Drawing.Point(9, 73);
            this.gridDoctorBusy.Margin = new System.Windows.Forms.Padding(4);
            this.gridDoctorBusy.Name = "gridDoctorBusy";
            this.gridDoctorBusy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDoctorBusy.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.gridDoctorBusy.RowHeadersWidth = 51;
            this.gridDoctorBusy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDoctorBusy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDoctorBusy.Size = new System.Drawing.Size(305, 220);
            this.gridDoctorBusy.TabIndex = 1;
            // 
            // comboBoxDoctors
            // 
            this.comboBoxDoctors.FormattingEnabled = true;
            this.comboBoxDoctors.Location = new System.Drawing.Point(9, 26);
            this.comboBoxDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDoctors.Name = "comboBoxDoctors";
            this.comboBoxDoctors.Size = new System.Drawing.Size(304, 24);
            this.comboBoxDoctors.TabIndex = 0;
            this.comboBoxDoctors.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoctors_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelDate);
            this.groupBox4.Controls.Add(this.labelService);
            this.groupBox4.Controls.Add(this.labelDoctor);
            this.groupBox4.Controls.Add(this.labelPatient);
            this.groupBox4.Controls.Add(this.metroLabel5);
            this.groupBox4.Controls.Add(this.metroLabel4);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.timePicker);
            this.groupBox4.Controls.Add(this.metroLabel3);
            this.groupBox4.Controls.Add(this.metroLabel2);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Location = new System.Drawing.Point(31, 436);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1025, 132);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "بررسی اجمالی";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(312, 109);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 0);
            this.labelDate.TabIndex = 10;
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(310, 51);
            this.labelService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(0, 0);
            this.labelService.TabIndex = 9;
            this.labelService.Click += new System.EventHandler(this.labelService_Click);
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(310, 78);
            this.labelDoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(0, 0);
            this.labelDoctor.TabIndex = 8;
            this.labelDoctor.Click += new System.EventHandler(this.labelDoctor_Click);
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Location = new System.Drawing.Point(311, 19);
            this.labelPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(0, 0);
            this.labelPatient.TabIndex = 7;
            this.labelPatient.Click += new System.EventHandler(this.labelPatient_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(120, 27);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 20);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = ": زمان";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(498, 108);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 20);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = ": اطلاعات";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnSave.Location = new System.Drawing.Point(852, 58);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "تایید";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(28, 69);
            this.timePicker.Margin = new System.Windows.Forms.Padding(4);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(133, 22);
            this.timePicker.TabIndex = 3;
            this.timePicker.Value = new System.DateTime(2018, 2, 4, 0, 0, 0, 0);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(499, 51);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = ": سرویس";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(518, 77);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = ": دکتر";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(518, 19);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = ": بیمار";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // AddReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 578);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddReservationForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "رزرو";
            this.Load += new System.EventHandler(this.AddEditReservationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctorBusy)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker timePicker;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox textSearchPatient;
        private System.Windows.Forms.ListBox listBoxPatient;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ListBox listBoxService;
        private MetroFramework.Controls.MetroGrid gridDoctorBusy;
        private System.Windows.Forms.ComboBox comboBoxDoctors;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel labelDate;
        private MetroFramework.Controls.MetroLabel labelService;
        private MetroFramework.Controls.MetroLabel labelDoctor;
        private MetroFramework.Controls.MetroLabel labelPatient;
        private System.Windows.Forms.ComboBox comboBoxPavilion;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label label1;
    }
}