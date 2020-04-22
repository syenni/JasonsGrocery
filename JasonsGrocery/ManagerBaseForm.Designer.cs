namespace JasonsGrocery
{
    partial class ManagerBaseForm
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
            this.ProductButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductButton
            // 
            this.ProductButton.Location = new System.Drawing.Point(12, 113);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(165, 95);
            this.ProductButton.TabIndex = 0;
            this.ProductButton.Text = "Products";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(12, 12);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(165, 95);
            this.EmployeeButton.TabIndex = 1;
            this.EmployeeButton.Text = "Employees";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.Location = new System.Drawing.Point(12, 214);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(165, 95);
            this.SalesButton.TabIndex = 2;
            this.SalesButton.Text = "Sales";
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // ManagerBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 319);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.ProductButton);
            this.Name = "ManagerBaseForm";
            this.Text = "ManagerBaseForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerBaseForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button SalesButton;
    }
}