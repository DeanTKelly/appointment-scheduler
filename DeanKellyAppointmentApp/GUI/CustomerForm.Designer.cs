namespace DeanKellyAppointmentApp
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            this.customerAddButton = new System.Windows.Forms.Button();
            this.customerUpdateButton = new System.Windows.Forms.Button();
            this.customerDeleteButton = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerMainMenuButton = new System.Windows.Forms.Button();
            this.u04pMbDataSet = new DeanKellyAppointmentApp.U04pMbDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new DeanKellyAppointmentApp.U04pMbDataSetTableAdapters.customerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u04pMbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerAddButton
            // 
            this.customerAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerAddButton.Location = new System.Drawing.Point(21, 373);
            this.customerAddButton.Name = "customerAddButton";
            this.customerAddButton.Size = new System.Drawing.Size(100, 33);
            this.customerAddButton.TabIndex = 0;
            this.customerAddButton.Text = "Add";
            this.customerAddButton.UseVisualStyleBackColor = true;
            this.customerAddButton.Click += new System.EventHandler(this.customerAddButton_Click);
            // 
            // customerUpdateButton
            // 
            this.customerUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerUpdateButton.Location = new System.Drawing.Point(183, 373);
            this.customerUpdateButton.Name = "customerUpdateButton";
            this.customerUpdateButton.Size = new System.Drawing.Size(100, 33);
            this.customerUpdateButton.TabIndex = 1;
            this.customerUpdateButton.Text = "Update";
            this.customerUpdateButton.UseVisualStyleBackColor = true;
            this.customerUpdateButton.Click += new System.EventHandler(this.customerUpdateButton_Click);
            // 
            // customerDeleteButton
            // 
            this.customerDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerDeleteButton.Location = new System.Drawing.Point(339, 373);
            this.customerDeleteButton.Name = "customerDeleteButton";
            this.customerDeleteButton.Size = new System.Drawing.Size(100, 33);
            this.customerDeleteButton.TabIndex = 2;
            this.customerDeleteButton.Text = "Delete";
            this.customerDeleteButton.UseVisualStyleBackColor = true;
            this.customerDeleteButton.Click += new System.EventHandler(this.customerDeleteButton_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(21, 24);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(754, 332);
            this.customerDataGridView.TabIndex = 3;
            // 
            // customerMainMenuButton
            // 
            this.customerMainMenuButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.customerMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerMainMenuButton.Location = new System.Drawing.Point(675, 373);
            this.customerMainMenuButton.Name = "customerMainMenuButton";
            this.customerMainMenuButton.Size = new System.Drawing.Size(100, 33);
            this.customerMainMenuButton.TabIndex = 4;
            this.customerMainMenuButton.Text = "Back";
            this.customerMainMenuButton.UseVisualStyleBackColor = false;
            this.customerMainMenuButton.Click += new System.EventHandler(this.customerBackButton_Click);
            // 
            // u04pMbDataSet
            // 
            this.u04pMbDataSet.DataSetName = "U04pMbDataSet";
            this.u04pMbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.u04pMbDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.customerMainMenuButton);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customerDeleteButton);
            this.Controls.Add(this.customerUpdateButton);
            this.Controls.Add(this.customerAddButton);
            this.Name = "CustomerForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u04pMbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerAddButton;
        private System.Windows.Forms.Button customerUpdateButton;
        private System.Windows.Forms.Button customerDeleteButton;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button customerMainMenuButton;
        private U04pMbDataSet u04pMbDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private U04pMbDataSetTableAdapters.customerTableAdapter customerTableAdapter;
    }
}