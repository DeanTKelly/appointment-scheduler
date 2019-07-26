namespace DeanKellyAppointmentApp
{
    partial class AddCustomerForm
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
            this.addCustomerPostalCodeBox = new System.Windows.Forms.TextBox();
            this.addCustomerNameBox = new System.Windows.Forms.TextBox();
            this.addCustomerAddressBox = new System.Windows.Forms.TextBox();
            this.addCustomerIDBox = new System.Windows.Forms.TextBox();
            this.addCustomerPostalCodeLabel = new System.Windows.Forms.Label();
            this.addCustomerCityLabel = new System.Windows.Forms.Label();
            this.addCustomerAddressLabel = new System.Windows.Forms.Label();
            this.addCustomerNameLabel = new System.Windows.Forms.Label();
            this.addCustomerIDLabel = new System.Windows.Forms.Label();
            this.addCustomerPhoneBox = new System.Windows.Forms.TextBox();
            this.addCustomerActiveLabel = new System.Windows.Forms.Label();
            this.addCustomerPhoneLabel = new System.Windows.Forms.Label();
            this.addCustomerCancelButton = new System.Windows.Forms.Button();
            this.addCustomerSaveButton = new System.Windows.Forms.Button();
            this.addCustomerActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.addCustomerCityComboBox = new System.Windows.Forms.ComboBox();
            this.addCustomerCountryBox = new System.Windows.Forms.TextBox();
            this.addCustomerCountryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCustomerPostalCodeBox
            // 
            this.addCustomerPostalCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerPostalCodeBox.Location = new System.Drawing.Point(156, 204);
            this.addCustomerPostalCodeBox.Name = "addCustomerPostalCodeBox";
            this.addCustomerPostalCodeBox.Size = new System.Drawing.Size(264, 26);
            this.addCustomerPostalCodeBox.TabIndex = 30;
            this.addCustomerPostalCodeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomerPostalCodeBox_KeyPress);
            // 
            // addCustomerNameBox
            // 
            this.addCustomerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerNameBox.Location = new System.Drawing.Point(156, 65);
            this.addCustomerNameBox.Name = "addCustomerNameBox";
            this.addCustomerNameBox.Size = new System.Drawing.Size(264, 26);
            this.addCustomerNameBox.TabIndex = 27;
            // 
            // addCustomerAddressBox
            // 
            this.addCustomerAddressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerAddressBox.Location = new System.Drawing.Point(156, 110);
            this.addCustomerAddressBox.Name = "addCustomerAddressBox";
            this.addCustomerAddressBox.Size = new System.Drawing.Size(264, 26);
            this.addCustomerAddressBox.TabIndex = 26;
            // 
            // addCustomerIDBox
            // 
            this.addCustomerIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerIDBox.Location = new System.Drawing.Point(156, 21);
            this.addCustomerIDBox.Name = "addCustomerIDBox";
            this.addCustomerIDBox.ReadOnly = true;
            this.addCustomerIDBox.Size = new System.Drawing.Size(264, 26);
            this.addCustomerIDBox.TabIndex = 25;
            this.addCustomerIDBox.Text = "Auto Generated";
            // 
            // addCustomerPostalCodeLabel
            // 
            this.addCustomerPostalCodeLabel.AutoSize = true;
            this.addCustomerPostalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerPostalCodeLabel.Location = new System.Drawing.Point(24, 210);
            this.addCustomerPostalCodeLabel.Name = "addCustomerPostalCodeLabel";
            this.addCustomerPostalCodeLabel.Size = new System.Drawing.Size(105, 20);
            this.addCustomerPostalCodeLabel.TabIndex = 24;
            this.addCustomerPostalCodeLabel.Text = "Postal Code:";
            // 
            // addCustomerCityLabel
            // 
            this.addCustomerCityLabel.AutoSize = true;
            this.addCustomerCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerCityLabel.Location = new System.Drawing.Point(24, 165);
            this.addCustomerCityLabel.Name = "addCustomerCityLabel";
            this.addCustomerCityLabel.Size = new System.Drawing.Size(43, 20);
            this.addCustomerCityLabel.TabIndex = 23;
            this.addCustomerCityLabel.Text = "City:";
            // 
            // addCustomerAddressLabel
            // 
            this.addCustomerAddressLabel.AutoSize = true;
            this.addCustomerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerAddressLabel.Location = new System.Drawing.Point(24, 116);
            this.addCustomerAddressLabel.Name = "addCustomerAddressLabel";
            this.addCustomerAddressLabel.Size = new System.Drawing.Size(76, 20);
            this.addCustomerAddressLabel.TabIndex = 21;
            this.addCustomerAddressLabel.Text = "Address:";
            // 
            // addCustomerNameLabel
            // 
            this.addCustomerNameLabel.AutoSize = true;
            this.addCustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerNameLabel.Location = new System.Drawing.Point(24, 71);
            this.addCustomerNameLabel.Name = "addCustomerNameLabel";
            this.addCustomerNameLabel.Size = new System.Drawing.Size(58, 20);
            this.addCustomerNameLabel.TabIndex = 20;
            this.addCustomerNameLabel.Text = "Name:";
            // 
            // addCustomerIDLabel
            // 
            this.addCustomerIDLabel.AutoSize = true;
            this.addCustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerIDLabel.Location = new System.Drawing.Point(24, 27);
            this.addCustomerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addCustomerIDLabel.Name = "addCustomerIDLabel";
            this.addCustomerIDLabel.Size = new System.Drawing.Size(109, 20);
            this.addCustomerIDLabel.TabIndex = 19;
            this.addCustomerIDLabel.Text = "Customer ID:";
            // 
            // addCustomerPhoneBox
            // 
            this.addCustomerPhoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerPhoneBox.Location = new System.Drawing.Point(156, 250);
            this.addCustomerPhoneBox.Name = "addCustomerPhoneBox";
            this.addCustomerPhoneBox.Size = new System.Drawing.Size(264, 26);
            this.addCustomerPhoneBox.TabIndex = 33;
            this.addCustomerPhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCustomerPhoneBox_KeyPress);
            // 
            // addCustomerActiveLabel
            // 
            this.addCustomerActiveLabel.AutoSize = true;
            this.addCustomerActiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerActiveLabel.Location = new System.Drawing.Point(24, 294);
            this.addCustomerActiveLabel.Name = "addCustomerActiveLabel";
            this.addCustomerActiveLabel.Size = new System.Drawing.Size(60, 20);
            this.addCustomerActiveLabel.TabIndex = 32;
            this.addCustomerActiveLabel.Text = "Active:";
            // 
            // addCustomerPhoneLabel
            // 
            this.addCustomerPhoneLabel.AutoSize = true;
            this.addCustomerPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerPhoneLabel.Location = new System.Drawing.Point(24, 256);
            this.addCustomerPhoneLabel.Name = "addCustomerPhoneLabel";
            this.addCustomerPhoneLabel.Size = new System.Drawing.Size(61, 20);
            this.addCustomerPhoneLabel.TabIndex = 31;
            this.addCustomerPhoneLabel.Text = "Phone:";
            // 
            // addCustomerCancelButton
            // 
            this.addCustomerCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerCancelButton.Location = new System.Drawing.Point(326, 361);
            this.addCustomerCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomerCancelButton.Name = "addCustomerCancelButton";
            this.addCustomerCancelButton.Size = new System.Drawing.Size(94, 29);
            this.addCustomerCancelButton.TabIndex = 36;
            this.addCustomerCancelButton.Text = "Cancel";
            this.addCustomerCancelButton.UseVisualStyleBackColor = true;
            this.addCustomerCancelButton.Click += new System.EventHandler(this.addCustomerCancelButton_Click);
            // 
            // addCustomerSaveButton
            // 
            this.addCustomerSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerSaveButton.Location = new System.Drawing.Point(156, 361);
            this.addCustomerSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomerSaveButton.Name = "addCustomerSaveButton";
            this.addCustomerSaveButton.Size = new System.Drawing.Size(94, 29);
            this.addCustomerSaveButton.TabIndex = 35;
            this.addCustomerSaveButton.Text = "Save";
            this.addCustomerSaveButton.UseVisualStyleBackColor = true;
            this.addCustomerSaveButton.Click += new System.EventHandler(this.addCustomerSaveButton_Click);
            // 
            // addCustomerActiveCheckBox
            // 
            this.addCustomerActiveCheckBox.AutoSize = true;
            this.addCustomerActiveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerActiveCheckBox.Location = new System.Drawing.Point(274, 297);
            this.addCustomerActiveCheckBox.Name = "addCustomerActiveCheckBox";
            this.addCustomerActiveCheckBox.Size = new System.Drawing.Size(18, 17);
            this.addCustomerActiveCheckBox.TabIndex = 37;
            this.addCustomerActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // addCustomerCityComboBox
            // 
            this.addCustomerCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCustomerCityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerCityComboBox.FormattingEnabled = true;
            this.addCustomerCityComboBox.Items.AddRange(new object[] {
            "Los Angeles",
            "New York",
            "London"});
            this.addCustomerCityComboBox.Location = new System.Drawing.Point(156, 157);
            this.addCustomerCityComboBox.Name = "addCustomerCityComboBox";
            this.addCustomerCityComboBox.Size = new System.Drawing.Size(264, 28);
            this.addCustomerCityComboBox.TabIndex = 38;
            // 
            // addCustomerCountryBox
            // 
            this.addCustomerCountryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerCountryBox.Location = new System.Drawing.Point(156, 21);
            this.addCustomerCountryBox.Name = "addCustomerCountryBox";
            this.addCustomerCountryBox.ReadOnly = true;
            this.addCustomerCountryBox.Size = new System.Drawing.Size(264, 26);
            this.addCustomerCountryBox.TabIndex = 40;
            // 
            // addCustomerCountryLabel
            // 
            this.addCustomerCountryLabel.AutoSize = true;
            this.addCustomerCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCustomerCountryLabel.Location = new System.Drawing.Point(348, 204);
            this.addCustomerCountryLabel.Name = "addCustomerCountryLabel";
            this.addCustomerCountryLabel.Size = new System.Drawing.Size(72, 20);
            this.addCustomerCountryLabel.TabIndex = 39;
            this.addCustomerCountryLabel.Text = "Country:";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 497);
            this.Controls.Add(this.addCustomerCityComboBox);
            this.Controls.Add(this.addCustomerActiveCheckBox);
            this.Controls.Add(this.addCustomerCancelButton);
            this.Controls.Add(this.addCustomerSaveButton);
            this.Controls.Add(this.addCustomerPhoneBox);
            this.Controls.Add(this.addCustomerActiveLabel);
            this.Controls.Add(this.addCustomerPhoneLabel);
            this.Controls.Add(this.addCustomerPostalCodeBox);
            this.Controls.Add(this.addCustomerNameBox);
            this.Controls.Add(this.addCustomerAddressBox);
            this.Controls.Add(this.addCustomerIDBox);
            this.Controls.Add(this.addCustomerPostalCodeLabel);
            this.Controls.Add(this.addCustomerCityLabel);
            this.Controls.Add(this.addCustomerAddressLabel);
            this.Controls.Add(this.addCustomerNameLabel);
            this.Controls.Add(this.addCustomerIDLabel);
            this.Controls.Add(this.addCustomerCountryLabel);
            this.Controls.Add(this.addCustomerCountryBox);
            this.Name = "AddCustomerForm";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addCustomerPostalCodeBox;
        private System.Windows.Forms.TextBox addCustomerNameBox;
        private System.Windows.Forms.TextBox addCustomerAddressBox;
        private System.Windows.Forms.TextBox addCustomerIDBox;
        private System.Windows.Forms.Label addCustomerPostalCodeLabel;
        private System.Windows.Forms.Label addCustomerCityLabel;
        private System.Windows.Forms.Label addCustomerAddressLabel;
        private System.Windows.Forms.Label addCustomerNameLabel;
        private System.Windows.Forms.Label addCustomerIDLabel;
        private System.Windows.Forms.TextBox addCustomerPhoneBox;
        private System.Windows.Forms.Label addCustomerActiveLabel;
        private System.Windows.Forms.Label addCustomerPhoneLabel;
        private System.Windows.Forms.Button addCustomerCancelButton;
        private System.Windows.Forms.Button addCustomerSaveButton;
        private System.Windows.Forms.CheckBox addCustomerActiveCheckBox;
        private System.Windows.Forms.ComboBox addCustomerCityComboBox;
        private System.Windows.Forms.TextBox addCustomerCountryBox;
        private System.Windows.Forms.Label addCustomerCountryLabel;
    }
}