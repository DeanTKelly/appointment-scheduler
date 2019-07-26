using System;

namespace DeanKellyAppointmentApp
{
    partial class AddAppointmentForm
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
            this.addApptSaveButton = new System.Windows.Forms.Button();
            this.addApptCancelButton = new System.Windows.Forms.Button();
            this.addApptIDLabel = new System.Windows.Forms.Label();
            this.addApptCustIDLabel = new System.Windows.Forms.Label();
            this.addApptTypeLabel = new System.Windows.Forms.Label();
            this.addApptDateLabel = new System.Windows.Forms.Label();
            this.addApptStartTime = new System.Windows.Forms.Label();
            this.addApptEndTime = new System.Windows.Forms.Label();
            this.addApptIDBox = new System.Windows.Forms.TextBox();
            this.addApptTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addApptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addApptStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addApptEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addApptCustIDComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addApptSaveButton
            // 
            this.addApptSaveButton.Location = new System.Drawing.Point(226, 319);
            this.addApptSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.addApptSaveButton.Name = "addApptSaveButton";
            this.addApptSaveButton.Size = new System.Drawing.Size(94, 29);
            this.addApptSaveButton.TabIndex = 0;
            this.addApptSaveButton.Text = "Save";
            this.addApptSaveButton.UseVisualStyleBackColor = true;
            this.addApptSaveButton.Click += new System.EventHandler(this.addApptSaveButton_Click);
            // 
            // addApptCancelButton
            // 
            this.addApptCancelButton.Location = new System.Drawing.Point(396, 319);
            this.addApptCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.addApptCancelButton.Name = "addApptCancelButton";
            this.addApptCancelButton.Size = new System.Drawing.Size(94, 29);
            this.addApptCancelButton.TabIndex = 1;
            this.addApptCancelButton.Text = "Cancel";
            this.addApptCancelButton.UseVisualStyleBackColor = true;
            this.addApptCancelButton.Click += new System.EventHandler(this.addApptCancelButton_Click);
            // 
            // addApptIDLabel
            // 
            this.addApptIDLabel.AutoSize = true;
            this.addApptIDLabel.Location = new System.Drawing.Point(16, 20);
            this.addApptIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addApptIDLabel.Name = "addApptIDLabel";
            this.addApptIDLabel.Size = new System.Drawing.Size(129, 20);
            this.addApptIDLabel.TabIndex = 2;
            this.addApptIDLabel.Text = "Appointment ID:";
            // 
            // addApptCustIDLabel
            // 
            this.addApptCustIDLabel.AutoSize = true;
            this.addApptCustIDLabel.Location = new System.Drawing.Point(16, 67);
            this.addApptCustIDLabel.Name = "addApptCustIDLabel";
            this.addApptCustIDLabel.Size = new System.Drawing.Size(87, 20);
            this.addApptCustIDLabel.TabIndex = 3;
            this.addApptCustIDLabel.Text = "Customer:";
            // 
            // addApptTypeLabel
            // 
            this.addApptTypeLabel.AutoSize = true;
            this.addApptTypeLabel.Location = new System.Drawing.Point(16, 118);
            this.addApptTypeLabel.Name = "addApptTypeLabel";
            this.addApptTypeLabel.Size = new System.Drawing.Size(50, 20);
            this.addApptTypeLabel.TabIndex = 8;
            this.addApptTypeLabel.Text = "Type:";
            // 
            // addApptDateLabel
            // 
            this.addApptDateLabel.AutoSize = true;
            this.addApptDateLabel.Location = new System.Drawing.Point(16, 168);
            this.addApptDateLabel.Name = "addApptDateLabel";
            this.addApptDateLabel.Size = new System.Drawing.Size(50, 20);
            this.addApptDateLabel.TabIndex = 10;
            this.addApptDateLabel.Text = "Date:";
            // 
            // addApptStartTime
            // 
            this.addApptStartTime.AutoSize = true;
            this.addApptStartTime.Location = new System.Drawing.Point(16, 220);
            this.addApptStartTime.Name = "addApptStartTime";
            this.addApptStartTime.Size = new System.Drawing.Size(50, 20);
            this.addApptStartTime.TabIndex = 11;
            this.addApptStartTime.Text = "Start:";
            // 
            // addApptEndTime
            // 
            this.addApptEndTime.AutoSize = true;
            this.addApptEndTime.Location = new System.Drawing.Point(16, 272);
            this.addApptEndTime.Name = "addApptEndTime";
            this.addApptEndTime.Size = new System.Drawing.Size(43, 20);
            this.addApptEndTime.TabIndex = 12;
            this.addApptEndTime.Text = "End:";
            // 
            // addApptIDBox
            // 
            this.addApptIDBox.Location = new System.Drawing.Point(226, 14);
            this.addApptIDBox.Name = "addApptIDBox";
            this.addApptIDBox.ReadOnly = true;
            this.addApptIDBox.Size = new System.Drawing.Size(264, 26);
            this.addApptIDBox.TabIndex = 13;
            this.addApptIDBox.Text = "Auto Generated";
            // 
            // addApptTypeComboBox
            // 
            this.addApptTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addApptTypeComboBox.FormattingEnabled = true;
            this.addApptTypeComboBox.Items.AddRange(new object[] {
            "New Appt",
            "Followup"});
            this.addApptTypeComboBox.Location = new System.Drawing.Point(226, 110);
            this.addApptTypeComboBox.Name = "addApptTypeComboBox";
            this.addApptTypeComboBox.Size = new System.Drawing.Size(264, 28);
            this.addApptTypeComboBox.TabIndex = 24;
            // 
            // addApptDatePicker
            // 
            this.addApptDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addApptDatePicker.Location = new System.Drawing.Point(226, 162);
            this.addApptDatePicker.Name = "addApptDatePicker";
            this.addApptDatePicker.Size = new System.Drawing.Size(264, 26);
            this.addApptDatePicker.TabIndex = 25;
            // 
            // addApptStartTimePicker
            // 
            this.addApptStartTimePicker.CustomFormat = "HH:mm";
            this.addApptStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.addApptStartTimePicker.Location = new System.Drawing.Point(226, 214);
            this.addApptStartTimePicker.Name = "addApptStartTimePicker";
            this.addApptStartTimePicker.ShowUpDown = true;
            this.addApptStartTimePicker.Size = new System.Drawing.Size(264, 26);
            this.addApptStartTimePicker.TabIndex = 26;
            // 
            // addApptEndTimePicker
            // 
            this.addApptEndTimePicker.CustomFormat = "HH:mm";
            this.addApptEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.addApptEndTimePicker.Location = new System.Drawing.Point(226, 266);
            this.addApptEndTimePicker.Name = "addApptEndTimePicker";
            this.addApptEndTimePicker.ShowUpDown = true;
            this.addApptEndTimePicker.Size = new System.Drawing.Size(264, 26);
            this.addApptEndTimePicker.TabIndex = 27;
            // 
            // addApptCustIDComboBox
            // 
            this.addApptCustIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addApptCustIDComboBox.FormattingEnabled = true;
            this.addApptCustIDComboBox.Location = new System.Drawing.Point(226, 59);
            this.addApptCustIDComboBox.Name = "addApptCustIDComboBox";
            this.addApptCustIDComboBox.Size = new System.Drawing.Size(264, 28);
            this.addApptCustIDComboBox.TabIndex = 28;
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 371);
            this.Controls.Add(this.addApptCustIDComboBox);
            this.Controls.Add(this.addApptEndTimePicker);
            this.Controls.Add(this.addApptStartTimePicker);
            this.Controls.Add(this.addApptDatePicker);
            this.Controls.Add(this.addApptTypeComboBox);
            this.Controls.Add(this.addApptIDBox);
            this.Controls.Add(this.addApptEndTime);
            this.Controls.Add(this.addApptStartTime);
            this.Controls.Add(this.addApptDateLabel);
            this.Controls.Add(this.addApptTypeLabel);
            this.Controls.Add(this.addApptCustIDLabel);
            this.Controls.Add(this.addApptIDLabel);
            this.Controls.Add(this.addApptCancelButton);
            this.Controls.Add(this.addApptSaveButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAppointmentForm";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addApptSaveButton;
        private System.Windows.Forms.Button addApptCancelButton;
        private System.Windows.Forms.Label addApptIDLabel;
        private System.Windows.Forms.Label addApptCustIDLabel;
        private System.Windows.Forms.Label addApptTypeLabel;
        private System.Windows.Forms.Label addApptDateLabel;
        private System.Windows.Forms.Label addApptStartTime;
        private System.Windows.Forms.Label addApptEndTime;
        private System.Windows.Forms.TextBox addApptIDBox;
        private System.Windows.Forms.ComboBox addApptTypeComboBox;
        private System.Windows.Forms.DateTimePicker addApptDatePicker;
        private System.Windows.Forms.DateTimePicker addApptStartTimePicker;
        private System.Windows.Forms.DateTimePicker addApptEndTimePicker;
        private System.Windows.Forms.ComboBox addApptCustIDComboBox;

        //public DateTime startTime
        //{
        //    get { return startTime; }
        //    set { startTime = DateTime.SpecifyKind(addApptStartTimePicker.Value, DateTimeKind.Utc); }

        //}

        //public DateTime endTime
        //{
        //    get { return endTime; }
        //    set { endTime = DateTime.SpecifyKind(addApptEndTimePicker.Value, DateTimeKind.Utc); }

        //}
    }
    
}