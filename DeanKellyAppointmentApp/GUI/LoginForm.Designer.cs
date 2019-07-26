namespace DeanKellyAppointmentApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginLogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginUsernameLabel
            // 
            resources.ApplyResources(this.loginUsernameLabel, "loginUsernameLabel");
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            // 
            // loginPasswordLabel
            // 
            resources.ApplyResources(this.loginPasswordLabel, "loginPasswordLabel");
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            // 
            // loginUsernameTextBox
            // 
            resources.ApplyResources(this.loginUsernameTextBox, "loginUsernameTextBox");
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            // 
            // loginPasswordTextBox
            // 
            resources.ApplyResources(this.loginPasswordTextBox, "loginPasswordTextBox");
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            // 
            // loginLogInButton
            // 
            resources.ApplyResources(this.loginLogInButton, "loginLogInButton");
            this.loginLogInButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginLogInButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginLogInButton.Name = "loginLogInButton";
            this.loginLogInButton.UseVisualStyleBackColor = false;
            this.loginLogInButton.Click += new System.EventHandler(this.loginLogInButton_Click);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginLogInButton);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginUsernameTextBox);
            this.Controls.Add(this.loginPasswordLabel);
            this.Controls.Add(this.loginUsernameLabel);
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Button loginLogInButton;
    }
}

