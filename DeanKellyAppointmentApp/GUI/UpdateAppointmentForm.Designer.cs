using System;

namespace DeanKellyAppointmentApp
{
    partial class UpdateAppointmentForm
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
            this.updateApptEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateApptStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateApptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.updateApptTypeComboBox = new System.Windows.Forms.ComboBox();
            this.updateApptIDBox = new System.Windows.Forms.TextBox();
            this.updateApptEndTime = new System.Windows.Forms.Label();
            this.updateApptStartTime = new System.Windows.Forms.Label();
            this.updateApptDateLabel = new System.Windows.Forms.Label();
            this.updateApptTypeLabel = new System.Windows.Forms.Label();
            this.updateApptCustIDLabel = new System.Windows.Forms.Label();
            this.updateApptIDLabel = new System.Windows.Forms.Label();
            this.updateApptCancelButton = new System.Windows.Forms.Button();
            this.updateApptSaveButton = new System.Windows.Forms.Button();
            this.updateApptCustIDComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // updateApptEndTimePicker
            // 
            this.updateApptEndTimePicker.CustomFormat = "HH:mm";
            this.updateApptEndTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.updateApptEndTimePicker.Location = new System.Drawing.Point(232, 251);
            this.updateApptEndTimePicker.Name = "updateApptEndTimePicker";
            this.updateApptEndTimePicker.ShowUpDown = true;
            this.updateApptEndTimePicker.Size = new System.Drawing.Size(264, 26);
            this.updateApptEndTimePicker.TabIndex = 51;
            // 
            // updateApptStartTimePicker
            // 
            this.updateApptStartTimePicker.CustomFormat = "HH:mm";
            this.updateApptStartTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.updateApptStartTimePicker.Location = new System.Drawing.Point(232, 204);
            this.updateApptStartTimePicker.Name = "updateApptStartTimePicker";
            this.updateApptStartTimePicker.ShowUpDown = true;
            this.updateApptStartTimePicker.Size = new System.Drawing.Size(264, 26);
            this.updateApptStartTimePicker.TabIndex = 50;
            // 
            // updateApptDatePicker
            // 
            this.updateApptDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateApptDatePicker.Location = new System.Drawing.Point(232, 155);
            this.updateApptDatePicker.Name = "updateApptDatePicker";
            this.updateApptDatePicker.Size = new System.Drawing.Size(264, 26);
            this.updateApptDatePicker.TabIndex = 49;
            // 
            // updateApptTypeComboBox
            // 
            this.updateApptTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateApptTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptTypeComboBox.FormattingEnabled = true;
            this.updateApptTypeComboBox.Items.AddRange(new object[] {
            "New Appt",
            "Followup"});
            this.updateApptTypeComboBox.Location = new System.Drawing.Point(232, 104);
            this.updateApptTypeComboBox.Name = "updateApptTypeComboBox";
            this.updateApptTypeComboBox.Size = new System.Drawing.Size(264, 28);
            this.updateApptTypeComboBox.TabIndex = 48;
            // 
            // updateApptIDBox
            // 
            this.updateApptIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptIDBox.Location = new System.Drawing.Point(232, 12);
            this.updateApptIDBox.Name = "updateApptIDBox";
            this.updateApptIDBox.ReadOnly = true;
            this.updateApptIDBox.Size = new System.Drawing.Size(264, 26);
            this.updateApptIDBox.TabIndex = 41;
            // 
            // updateApptEndTime
            // 
            this.updateApptEndTime.AutoSize = true;
            this.updateApptEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptEndTime.Location = new System.Drawing.Point(15, 256);
            this.updateApptEndTime.Name = "updateApptEndTime";
            this.updateApptEndTime.Size = new System.Drawing.Size(43, 20);
            this.updateApptEndTime.TabIndex = 40;
            this.updateApptEndTime.Text = "End:";
            // 
            // updateApptStartTime
            // 
            this.updateApptStartTime.AutoSize = true;
            this.updateApptStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptStartTime.Location = new System.Drawing.Point(15, 209);
            this.updateApptStartTime.Name = "updateApptStartTime";
            this.updateApptStartTime.Size = new System.Drawing.Size(50, 20);
            this.updateApptStartTime.TabIndex = 39;
            this.updateApptStartTime.Text = "Start:";
            // 
            // updateApptDateLabel
            // 
            this.updateApptDateLabel.AutoSize = true;
            this.updateApptDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptDateLabel.Location = new System.Drawing.Point(15, 160);
            this.updateApptDateLabel.Name = "updateApptDateLabel";
            this.updateApptDateLabel.Size = new System.Drawing.Size(50, 20);
            this.updateApptDateLabel.TabIndex = 38;
            this.updateApptDateLabel.Text = "Date:";
            // 
            // updateApptTypeLabel
            // 
            this.updateApptTypeLabel.AutoSize = true;
            this.updateApptTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptTypeLabel.Location = new System.Drawing.Point(15, 111);
            this.updateApptTypeLabel.Name = "updateApptTypeLabel";
            this.updateApptTypeLabel.Size = new System.Drawing.Size(50, 20);
            this.updateApptTypeLabel.TabIndex = 36;
            this.updateApptTypeLabel.Text = "Type:";
            // 
            // updateApptCustIDLabel
            // 
            this.updateApptCustIDLabel.AutoSize = true;
            this.updateApptCustIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptCustIDLabel.Location = new System.Drawing.Point(15, 62);
            this.updateApptCustIDLabel.Name = "updateApptCustIDLabel";
            this.updateApptCustIDLabel.Size = new System.Drawing.Size(87, 20);
            this.updateApptCustIDLabel.TabIndex = 31;
            this.updateApptCustIDLabel.Text = "Customer:";
            // 
            // updateApptIDLabel
            // 
            this.updateApptIDLabel.AutoSize = true;
            this.updateApptIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptIDLabel.Location = new System.Drawing.Point(15, 17);
            this.updateApptIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updateApptIDLabel.Name = "updateApptIDLabel";
            this.updateApptIDLabel.Size = new System.Drawing.Size(129, 20);
            this.updateApptIDLabel.TabIndex = 30;
            this.updateApptIDLabel.Text = "Appointment ID:";
            // 
            // updateApptCancelButton
            // 
            this.updateApptCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptCancelButton.Location = new System.Drawing.Point(402, 313);
            this.updateApptCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateApptCancelButton.Name = "updateApptCancelButton";
            this.updateApptCancelButton.Size = new System.Drawing.Size(94, 29);
            this.updateApptCancelButton.TabIndex = 29;
            this.updateApptCancelButton.Text = "Cancel";
            this.updateApptCancelButton.UseVisualStyleBackColor = true;
            this.updateApptCancelButton.Click += new System.EventHandler(this.updateApptCancelButton_Click);
            // 
            // updateApptSaveButton
            // 
            this.updateApptSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptSaveButton.Location = new System.Drawing.Point(232, 313);
            this.updateApptSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateApptSaveButton.Name = "updateApptSaveButton";
            this.updateApptSaveButton.Size = new System.Drawing.Size(94, 29);
            this.updateApptSaveButton.TabIndex = 28;
            this.updateApptSaveButton.Text = "Save";
            this.updateApptSaveButton.UseVisualStyleBackColor = true;
            this.updateApptSaveButton.Click += new System.EventHandler(this.updateApptSaveButton_Click);
            // 
            // updateApptCustIDComboBox
            // 
            this.updateApptCustIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateApptCustIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updateApptCustIDComboBox.FormattingEnabled = true;
            this.updateApptCustIDComboBox.Location = new System.Drawing.Point(232, 54);
            this.updateApptCustIDComboBox.Name = "updateApptCustIDComboBox";
            this.updateApptCustIDComboBox.Size = new System.Drawing.Size(264, 28);
            this.updateApptCustIDComboBox.TabIndex = 52;
            // 
            // UpdateAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 373);
            this.Controls.Add(this.updateApptCustIDComboBox);
            this.Controls.Add(this.updateApptEndTimePicker);
            this.Controls.Add(this.updateApptStartTimePicker);
            this.Controls.Add(this.updateApptDatePicker);
            this.Controls.Add(this.updateApptTypeComboBox);
            this.Controls.Add(this.updateApptIDBox);
            this.Controls.Add(this.updateApptEndTime);
            this.Controls.Add(this.updateApptStartTime);
            this.Controls.Add(this.updateApptDateLabel);
            this.Controls.Add(this.updateApptTypeLabel);
            this.Controls.Add(this.updateApptCustIDLabel);
            this.Controls.Add(this.updateApptIDLabel);
            this.Controls.Add(this.updateApptCancelButton);
            this.Controls.Add(this.updateApptSaveButton);
            this.Name = "UpdateAppointmentForm";
            this.Text = "Update Appointment";
            this.Load += new System.EventHandler(this.UpdateAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker updateApptEndTimePicker;
        private System.Windows.Forms.DateTimePicker updateApptStartTimePicker;
        private System.Windows.Forms.DateTimePicker updateApptDatePicker;
        private System.Windows.Forms.ComboBox updateApptTypeComboBox;
        private System.Windows.Forms.TextBox updateApptIDBox;
        private System.Windows.Forms.Label updateApptEndTime;
        private System.Windows.Forms.Label updateApptStartTime;
        private System.Windows.Forms.Label updateApptDateLabel;
        private System.Windows.Forms.Label updateApptTypeLabel;
        private System.Windows.Forms.Label updateApptCustIDLabel;
        private System.Windows.Forms.Label updateApptIDLabel;
        private System.Windows.Forms.Button updateApptCancelButton;
        private System.Windows.Forms.Button updateApptSaveButton;
        private System.Windows.Forms.ComboBox updateApptCustIDComboBox;

        public DateTime startTime
        {
            get { return startTime; }
            set { startTime = DateTime.SpecifyKind(updateApptStartTimePicker.Value, DateTimeKind.Utc); }

        }

        public DateTime endTime
        {
            get { return endTime; }
            set { endTime = DateTime.SpecifyKind(updateApptEndTimePicker.Value, DateTimeKind.Utc); }

        }
    }
}