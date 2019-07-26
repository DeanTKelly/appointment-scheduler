namespace DeanKellyAppointmentApp
{
    partial class AppointmentForm
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
            this.radioButtonWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.apptDataGridView = new System.Windows.Forms.DataGridView();
            this.apptAddButton = new System.Windows.Forms.Button();
            this.apptUpdateButton = new System.Windows.Forms.Button();
            this.apptDeleteButton = new System.Windows.Forms.Button();
            this.apptExitButton = new System.Windows.Forms.Button();
            this.apptCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apptDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonWeek
            // 
            this.radioButtonWeek.AutoSize = true;
            this.radioButtonWeek.Checked = true;
            this.radioButtonWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonWeek.Location = new System.Drawing.Point(304, 42);
            this.radioButtonWeek.Name = "radioButtonWeek";
            this.radioButtonWeek.Size = new System.Drawing.Size(72, 24);
            this.radioButtonWeek.TabIndex = 1;
            this.radioButtonWeek.TabStop = true;
            this.radioButtonWeek.Text = "Week";
            this.radioButtonWeek.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonMonth.Location = new System.Drawing.Point(395, 42);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(76, 24);
            this.radioButtonMonth.TabIndex = 2;
            this.radioButtonMonth.Text = "Month";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // apptDataGridView
            // 
            this.apptDataGridView.AllowUserToAddRows = false;
            this.apptDataGridView.AllowUserToDeleteRows = false;
            this.apptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptDataGridView.Location = new System.Drawing.Point(18, 69);
            this.apptDataGridView.Name = "apptDataGridView";
            this.apptDataGridView.ReadOnly = true;
            this.apptDataGridView.RowTemplate.Height = 24;
            this.apptDataGridView.Size = new System.Drawing.Size(754, 332);
            this.apptDataGridView.TabIndex = 3;
            // 
            // apptAddButton
            // 
            this.apptAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.apptAddButton.Location = new System.Drawing.Point(18, 418);
            this.apptAddButton.Name = "apptAddButton";
            this.apptAddButton.Size = new System.Drawing.Size(100, 31);
            this.apptAddButton.TabIndex = 4;
            this.apptAddButton.Text = "Add";
            this.apptAddButton.UseVisualStyleBackColor = true;
            this.apptAddButton.Click += new System.EventHandler(this.apptAddButton_Click);
            // 
            // apptUpdateButton
            // 
            this.apptUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.apptUpdateButton.Location = new System.Drawing.Point(180, 418);
            this.apptUpdateButton.Name = "apptUpdateButton";
            this.apptUpdateButton.Size = new System.Drawing.Size(100, 31);
            this.apptUpdateButton.TabIndex = 5;
            this.apptUpdateButton.Text = "Update";
            this.apptUpdateButton.UseVisualStyleBackColor = true;
            this.apptUpdateButton.Click += new System.EventHandler(this.apptUpdateButton_Click_1);
            // 
            // apptDeleteButton
            // 
            this.apptDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.apptDeleteButton.Location = new System.Drawing.Point(342, 418);
            this.apptDeleteButton.Name = "apptDeleteButton";
            this.apptDeleteButton.Size = new System.Drawing.Size(100, 31);
            this.apptDeleteButton.TabIndex = 6;
            this.apptDeleteButton.Text = "Delete";
            this.apptDeleteButton.UseVisualStyleBackColor = true;
            this.apptDeleteButton.Click += new System.EventHandler(this.apptDeleteButton_Click);
            // 
            // apptExitButton
            // 
            this.apptExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.apptExitButton.Location = new System.Drawing.Point(946, 418);
            this.apptExitButton.Name = "apptExitButton";
            this.apptExitButton.Size = new System.Drawing.Size(100, 31);
            this.apptExitButton.TabIndex = 7;
            this.apptExitButton.Text = "Exit";
            this.apptExitButton.UseVisualStyleBackColor = true;
            this.apptExitButton.Click += new System.EventHandler(this.apptExitButton_Click);
            // 
            // apptCalendar
            // 
            this.apptCalendar.Location = new System.Drawing.Point(784, 69);
            this.apptCalendar.Name = "apptCalendar";
            this.apptCalendar.TabIndex = 0;
            this.apptCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.apptCalendar_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Displaying Appointments By:";
            // 
            // CustomersButton
            // 
            this.CustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CustomersButton.Location = new System.Drawing.Point(505, 418);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(100, 31);
            this.CustomersButton.TabIndex = 9;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ReportsButton.Location = new System.Drawing.Point(672, 418);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(100, 31);
            this.ReportsButton.TabIndex = 10;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 484);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apptExitButton);
            this.Controls.Add(this.apptDeleteButton);
            this.Controls.Add(this.apptUpdateButton);
            this.Controls.Add(this.apptAddButton);
            this.Controls.Add(this.apptDataGridView);
            this.Controls.Add(this.radioButtonMonth);
            this.Controls.Add(this.radioButtonWeek);
            this.Controls.Add(this.apptCalendar);
            this.Name = "AppointmentForm";
            this.Text = "Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.apptDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonWeek;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.DataGridView apptDataGridView;
        private System.Windows.Forms.Button apptAddButton;
        private System.Windows.Forms.Button apptUpdateButton;
        private System.Windows.Forms.Button apptDeleteButton;
        private System.Windows.Forms.Button apptExitButton;
        private System.Windows.Forms.MonthCalendar apptCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button ReportsButton;
    }
}