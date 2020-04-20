namespace JasonsGrocery
{
    partial class BossUI
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
            this.uxHoursWorked = new System.Windows.Forms.Button();
            this.uxClockIn = new System.Windows.Forms.Button();
            this.uxClockOut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxHoursWorked
            // 
            this.uxHoursWorked.Location = new System.Drawing.Point(239, 23);
            this.uxHoursWorked.Name = "uxHoursWorked";
            this.uxHoursWorked.Size = new System.Drawing.Size(103, 46);
            this.uxHoursWorked.TabIndex = 0;
            this.uxHoursWorked.Text = "HoursWorked";
            this.uxHoursWorked.UseVisualStyleBackColor = true;
            this.uxHoursWorked.Click += new System.EventHandler(this.Button1_Click);
            // 
            // uxClockIn
            // 
            this.uxClockIn.Location = new System.Drawing.Point(406, 23);
            this.uxClockIn.Name = "uxClockIn";
            this.uxClockIn.Size = new System.Drawing.Size(103, 49);
            this.uxClockIn.TabIndex = 1;
            this.uxClockIn.Text = "ClockIn";
            this.uxClockIn.UseVisualStyleBackColor = true;
            // 
            // uxClockOut
            // 
            this.uxClockOut.Location = new System.Drawing.Point(575, 23);
            this.uxClockOut.Name = "uxClockOut";
            this.uxClockOut.Size = new System.Drawing.Size(103, 49);
            this.uxClockOut.TabIndex = 2;
            this.uxClockOut.Text = "ClockOut";
            this.uxClockOut.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 22);
            this.textBox1.TabIndex = 4;
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Location = new System.Drawing.Point(48, 127);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersWidth = 51;
            this.uxDataGrid.RowTemplate.Height = 24;
            this.uxDataGrid.Size = new System.Drawing.Size(671, 257);
            this.uxDataGrid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "EmployeeID";
            // 
            // BossUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDataGrid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxClockOut);
            this.Controls.Add(this.uxClockIn);
            this.Controls.Add(this.uxHoursWorked);
            this.Name = "BossUI";
            this.Text = "BossUI";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxHoursWorked;
        private System.Windows.Forms.Button uxClockIn;
        private System.Windows.Forms.Button uxClockOut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Label label1;
    }
}