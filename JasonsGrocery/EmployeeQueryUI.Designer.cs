namespace JasonsGrocery
{
    partial class EmployeeQueryUI
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
            this.BackButton = new System.Windows.Forms.Button();
            this.BakeryRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ProduceRadioButton = new System.Windows.Forms.RadioButton();
            this.DeliRadioButton = new System.Windows.Forms.RadioButton();
            this.DairyRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uxListOfEmployees = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uxAddNewEmployeeButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uxAverageWorkPositionSalary = new System.Windows.Forms.Button();
            this.uxdataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(13, 337);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 39);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BakeryRadioButton
            // 
            this.BakeryRadioButton.AutoSize = true;
            this.BakeryRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakeryRadioButton.Location = new System.Drawing.Point(116, 65);
            this.BakeryRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BakeryRadioButton.Name = "BakeryRadioButton";
            this.BakeryRadioButton.Size = new System.Drawing.Size(82, 24);
            this.BakeryRadioButton.TabIndex = 8;
            this.BakeryRadioButton.TabStop = true;
            this.BakeryRadioButton.Text = "Bakery";
            this.BakeryRadioButton.UseVisualStyleBackColor = true;
            this.BakeryRadioButton.CheckedChanged += new System.EventHandler(this.BakeryRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chooose Department:";
            // 
            // ProduceRadioButton
            // 
            this.ProduceRadioButton.AutoSize = true;
            this.ProduceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProduceRadioButton.Location = new System.Drawing.Point(116, 32);
            this.ProduceRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProduceRadioButton.Name = "ProduceRadioButton";
            this.ProduceRadioButton.Size = new System.Drawing.Size(92, 24);
            this.ProduceRadioButton.TabIndex = 7;
            this.ProduceRadioButton.TabStop = true;
            this.ProduceRadioButton.Text = "Produce";
            this.ProduceRadioButton.UseVisualStyleBackColor = true;
            this.ProduceRadioButton.CheckedChanged += new System.EventHandler(this.ProduceRadioButton_CheckedChanged);
            // 
            // DeliRadioButton
            // 
            this.DeliRadioButton.AutoSize = true;
            this.DeliRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeliRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliRadioButton.Location = new System.Drawing.Point(24, 32);
            this.DeliRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeliRadioButton.Name = "DeliRadioButton";
            this.DeliRadioButton.Size = new System.Drawing.Size(60, 24);
            this.DeliRadioButton.TabIndex = 6;
            this.DeliRadioButton.TabStop = true;
            this.DeliRadioButton.Text = "Deli";
            this.DeliRadioButton.UseVisualStyleBackColor = false;
            this.DeliRadioButton.CheckedChanged += new System.EventHandler(this.DeliRadioButton_CheckedChanged);
            // 
            // DairyRadioButton
            // 
            this.DairyRadioButton.AutoSize = true;
            this.DairyRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.DairyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DairyRadioButton.Location = new System.Drawing.Point(24, 65);
            this.DairyRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DairyRadioButton.Name = "DairyRadioButton";
            this.DairyRadioButton.Size = new System.Drawing.Size(70, 24);
            this.DairyRadioButton.TabIndex = 9;
            this.DairyRadioButton.TabStop = true;
            this.DairyRadioButton.Text = "Dairy";
            this.DairyRadioButton.UseVisualStyleBackColor = false;
            this.DairyRadioButton.CheckedChanged += new System.EventHandler(this.DairyRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ProduceRadioButton);
            this.panel1.Controls.Add(this.DeliRadioButton);
            this.panel1.Controls.Add(this.uxListOfEmployees);
            this.panel1.Controls.Add(this.DairyRadioButton);
            this.panel1.Controls.Add(this.BakeryRadioButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(11, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 326);
            this.panel1.TabIndex = 14;
            // 
            // uxListOfEmployees
            // 
            this.uxListOfEmployees.Enabled = false;
            this.uxListOfEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxListOfEmployees.Location = new System.Drawing.Point(24, 97);
            this.uxListOfEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxListOfEmployees.Name = "uxListOfEmployees";
            this.uxListOfEmployees.Size = new System.Drawing.Size(173, 46);
            this.uxListOfEmployees.TabIndex = 0;
            this.uxListOfEmployees.Text = "List of Employees";
            this.uxListOfEmployees.UseVisualStyleBackColor = true;
            this.uxListOfEmployees.Click += new System.EventHandler(this.UxListOfEmployees_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uxAddNewEmployeeButton);
            this.panel2.Location = new System.Drawing.Point(-1, 238);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 87);
            this.panel2.TabIndex = 17;
            // 
            // uxAddNewEmployeeButton
            // 
            this.uxAddNewEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddNewEmployeeButton.Location = new System.Drawing.Point(21, 17);
            this.uxAddNewEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxAddNewEmployeeButton.Name = "uxAddNewEmployeeButton";
            this.uxAddNewEmployeeButton.Size = new System.Drawing.Size(173, 52);
            this.uxAddNewEmployeeButton.TabIndex = 1;
            this.uxAddNewEmployeeButton.Text = "Add New Employee";
            this.uxAddNewEmployeeButton.UseVisualStyleBackColor = true;
            this.uxAddNewEmployeeButton.Click += new System.EventHandler(this.uxAddNewEmployeeButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.uxAverageWorkPositionSalary);
            this.panel3.Location = new System.Drawing.Point(-1, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 92);
            this.panel3.TabIndex = 18;
            // 
            // uxAverageWorkPositionSalary
            // 
            this.uxAverageWorkPositionSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAverageWorkPositionSalary.Location = new System.Drawing.Point(23, 11);
            this.uxAverageWorkPositionSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxAverageWorkPositionSalary.Name = "uxAverageWorkPositionSalary";
            this.uxAverageWorkPositionSalary.Size = new System.Drawing.Size(173, 64);
            this.uxAverageWorkPositionSalary.TabIndex = 16;
            this.uxAverageWorkPositionSalary.Text = "Average Work Position Salary";
            this.uxAverageWorkPositionSalary.UseVisualStyleBackColor = true;
            this.uxAverageWorkPositionSalary.Click += new System.EventHandler(this.UxAverageWorkPositionSalary_Click);
            // 
            // uxdataGridView
            // 
            this.uxdataGridView.AllowUserToDeleteRows = false;
            this.uxdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxdataGridView.Location = new System.Drawing.Point(244, 4);
            this.uxdataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxdataGridView.Name = "uxdataGridView";
            this.uxdataGridView.RowHeadersWidth = 51;
            this.uxdataGridView.Size = new System.Drawing.Size(515, 373);
            this.uxdataGridView.TabIndex = 15;
            // 
            // EmployeeQueryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 398);
            this.Controls.Add(this.uxdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeQueryUI";
            this.Text = "EmployeeQueryUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeQueryUI_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.RadioButton BakeryRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ProduceRadioButton;
        private System.Windows.Forms.RadioButton DeliRadioButton;
        private System.Windows.Forms.RadioButton DairyRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uxAverageWorkPositionSalary;
        private System.Windows.Forms.Button uxAddNewEmployeeButton;
        private System.Windows.Forms.Button uxListOfEmployees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView uxdataGridView;
        private System.Windows.Forms.Panel panel3;
    }
}