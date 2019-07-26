namespace DeanKellyAppointmentApp
{
    partial class ReportsForm
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
            this.reportsBackButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scheduleReport = new System.Windows.Forms.Button();
            this.apptTypeReport = new System.Windows.Forms.Button();
            this.customerApptReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportsBackButton
            // 
            this.reportsBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.reportsBackButton.Location = new System.Drawing.Point(654, 385);
            this.reportsBackButton.Name = "reportsBackButton";
            this.reportsBackButton.Size = new System.Drawing.Size(100, 31);
            this.reportsBackButton.TabIndex = 1;
            this.reportsBackButton.Text = "Back";
            this.reportsBackButton.UseVisualStyleBackColor = true;
            this.reportsBackButton.Click += new System.EventHandler(this.reportsBackButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(401, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(353, 302);
            this.dataGridView1.TabIndex = 2;
            // 
            // scheduleReport
            // 
            this.scheduleReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.scheduleReport.Location = new System.Drawing.Point(41, 37);
            this.scheduleReport.Name = "scheduleReport";
            this.scheduleReport.Size = new System.Drawing.Size(317, 74);
            this.scheduleReport.TabIndex = 3;
            this.scheduleReport.Text = "Your Scheduled Appointments";
            this.scheduleReport.UseVisualStyleBackColor = true;
            this.scheduleReport.Click += new System.EventHandler(this.scheduleReport_Click);
            // 
            // apptTypeReport
            // 
            this.apptTypeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.apptTypeReport.Location = new System.Drawing.Point(41, 265);
            this.apptTypeReport.Name = "apptTypeReport";
            this.apptTypeReport.Size = new System.Drawing.Size(317, 74);
            this.apptTypeReport.TabIndex = 4;
            this.apptTypeReport.Text = "Number Of Appointment Types By Month";
            this.apptTypeReport.UseVisualStyleBackColor = true;
            this.apptTypeReport.Click += new System.EventHandler(this.apptTypeReport_Click);
            // 
            // customerApptReport
            // 
            this.customerApptReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.customerApptReport.Location = new System.Drawing.Point(41, 151);
            this.customerApptReport.Name = "customerApptReport";
            this.customerApptReport.Size = new System.Drawing.Size(317, 74);
            this.customerApptReport.TabIndex = 5;
            this.customerApptReport.Text = "Number Of Appointments By Customer";
            this.customerApptReport.UseVisualStyleBackColor = true;
            this.customerApptReport.Click += new System.EventHandler(this.customerApptReport_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerApptReport);
            this.Controls.Add(this.apptTypeReport);
            this.Controls.Add(this.scheduleReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reportsBackButton);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button reportsBackButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button scheduleReport;
        private System.Windows.Forms.Button apptTypeReport;
        private System.Windows.Forms.Button customerApptReport;
    }
}