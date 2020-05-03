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
            this.uxCalculateHoursWorked = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uxAverageWorkPositionSalary = new System.Windows.Forms.Button();
            this.uxdataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uxSelectYearLabel = new System.Windows.Forms.Label();
            this.uxSelectYearComboBox = new System.Windows.Forms.ComboBox();
            this.uxSelectMonthComboBox = new System.Windows.Forms.ComboBox();
            this.uxSelectMonthLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxdataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(10, 377);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BakeryRadioButton
            // 
            this.BakeryRadioButton.AutoSize = true;
            this.BakeryRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BakeryRadioButton.Location = new System.Drawing.Point(87, 53);
            this.BakeryRadioButton.Name = "BakeryRadioButton";
            this.BakeryRadioButton.Size = new System.Drawing.Size(69, 20);
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
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chooose Department:";
            // 
            // ProduceRadioButton
            // 
            this.ProduceRadioButton.AutoSize = true;
            this.ProduceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProduceRadioButton.Location = new System.Drawing.Point(87, 26);
            this.ProduceRadioButton.Name = "ProduceRadioButton";
            this.ProduceRadioButton.Size = new System.Drawing.Size(77, 20);
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
            this.DeliRadioButton.Location = new System.Drawing.Point(18, 26);
            this.DeliRadioButton.Name = "DeliRadioButton";
            this.DeliRadioButton.Size = new System.Drawing.Size(50, 20);
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
            this.DairyRadioButton.Location = new System.Drawing.Point(18, 53);
            this.DairyRadioButton.Name = "DairyRadioButton";
            this.DairyRadioButton.Size = new System.Drawing.Size(58, 20);
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
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 364);
            this.panel1.TabIndex = 14;
            // 
            // uxListOfEmployees
            // 
            this.uxListOfEmployees.Enabled = false;
            this.uxListOfEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxListOfEmployees.Location = new System.Drawing.Point(18, 79);
            this.uxListOfEmployees.Name = "uxListOfEmployees";
            this.uxListOfEmployees.Size = new System.Drawing.Size(130, 37);
            this.uxListOfEmployees.TabIndex = 0;
            this.uxListOfEmployees.Text = "List of Employees";
            this.uxListOfEmployees.UseVisualStyleBackColor = true;
            this.uxListOfEmployees.Click += new System.EventHandler(this.UxListOfEmployees_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uxSelectMonthComboBox);
            this.panel2.Controls.Add(this.uxSelectMonthLabel);
            this.panel2.Controls.Add(this.uxSelectYearComboBox);
            this.panel2.Controls.Add(this.uxSelectYearLabel);
            this.panel2.Controls.Add(this.uxCalculateHoursWorked);
            this.panel2.Location = new System.Drawing.Point(-1, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 115);
            this.panel2.TabIndex = 17;
            // 
            // uxCalculateHoursWorked
            // 
            this.uxCalculateHoursWorked.Enabled = false;
            this.uxCalculateHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCalculateHoursWorked.Location = new System.Drawing.Point(16, 61);
            this.uxCalculateHoursWorked.Name = "uxCalculateHoursWorked";
            this.uxCalculateHoursWorked.Size = new System.Drawing.Size(130, 42);
            this.uxCalculateHoursWorked.TabIndex = 1;
            this.uxCalculateHoursWorked.Text = "Calculate Hours Worked";
            this.uxCalculateHoursWorked.UseVisualStyleBackColor = true;
            this.uxCalculateHoursWorked.Click += new System.EventHandler(this.UxCalculateHoursWorked_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.uxAverageWorkPositionSalary);
            this.panel3.Location = new System.Drawing.Point(-1, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 75);
            this.panel3.TabIndex = 18;
            // 
            // uxAverageWorkPositionSalary
            // 
            this.uxAverageWorkPositionSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAverageWorkPositionSalary.Location = new System.Drawing.Point(17, 9);
            this.uxAverageWorkPositionSalary.Name = "uxAverageWorkPositionSalary";
            this.uxAverageWorkPositionSalary.Size = new System.Drawing.Size(130, 52);
            this.uxAverageWorkPositionSalary.TabIndex = 16;
            this.uxAverageWorkPositionSalary.Text = "Average Work Position Salary";
            this.uxAverageWorkPositionSalary.UseVisualStyleBackColor = true;
            this.uxAverageWorkPositionSalary.Click += new System.EventHandler(this.UxAverageWorkPositionSalary_Click);
            // 
            // uxdataGridView
            // 
            this.uxdataGridView.AllowUserToDeleteRows = false;
            this.uxdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxdataGridView.Location = new System.Drawing.Point(183, 3);
            this.uxdataGridView.Name = "uxdataGridView";
            this.uxdataGridView.RowHeadersWidth = 51;
            this.uxdataGridView.Size = new System.Drawing.Size(386, 296);
            this.uxdataGridView.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.uxAddNewEmployeeButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(8, 310);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 61);
            this.panel4.TabIndex = 18;
            // 
            // uxSelectYearLabel
            // 
            this.uxSelectYearLabel.AutoSize = true;
            this.uxSelectYearLabel.Location = new System.Drawing.Point(18, 11);
            this.uxSelectYearLabel.Name = "uxSelectYearLabel";
            this.uxSelectYearLabel.Size = new System.Drawing.Size(65, 13);
            this.uxSelectYearLabel.TabIndex = 2;
            this.uxSelectYearLabel.Text = "Select Year:";
            // 
            // uxSelectYearComboBox
            // 
            this.uxSelectYearComboBox.FormattingEnabled = true;
            this.uxSelectYearComboBox.Items.AddRange(new object[] {
            "2020"});
            this.uxSelectYearComboBox.Location = new System.Drawing.Point(87, 8);
            this.uxSelectYearComboBox.Name = "uxSelectYearComboBox";
            this.uxSelectYearComboBox.Size = new System.Drawing.Size(69, 21);
            this.uxSelectYearComboBox.TabIndex = 3;
            this.uxSelectYearComboBox.SelectedIndexChanged += new System.EventHandler(this.uxSelectYearComboBox_SelectedIndexChanged);
            // 
            // uxSelectMonthComboBox
            // 
            this.uxSelectMonthComboBox.Enabled = false;
            this.uxSelectMonthComboBox.FormattingEnabled = true;
            this.uxSelectMonthComboBox.Items.AddRange(new object[] {
            "March",
            "April"});
            this.uxSelectMonthComboBox.Location = new System.Drawing.Point(87, 34);
            this.uxSelectMonthComboBox.Name = "uxSelectMonthComboBox";
            this.uxSelectMonthComboBox.Size = new System.Drawing.Size(69, 21);
            this.uxSelectMonthComboBox.TabIndex = 5;
            this.uxSelectMonthComboBox.SelectedIndexChanged += new System.EventHandler(this.uxSelectMonthComboBox_SelectedIndexChanged);
            // 
            // uxSelectMonthLabel
            // 
            this.uxSelectMonthLabel.AutoSize = true;
            this.uxSelectMonthLabel.Location = new System.Drawing.Point(12, 37);
            this.uxSelectMonthLabel.Name = "uxSelectMonthLabel";
            this.uxSelectMonthLabel.Size = new System.Drawing.Size(73, 13);
            this.uxSelectMonthLabel.TabIndex = 4;
            this.uxSelectMonthLabel.Text = "Select Month:";
            // 
            // EmployeeQueryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 419);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.uxdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackButton);
            this.Name = "EmployeeQueryUI";
            this.Text = "EmployeeQueryUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeQueryUI_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxdataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Button uxCalculateHoursWorked;
        private System.Windows.Forms.Button uxListOfEmployees;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView uxdataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox uxSelectMonthComboBox;
        private System.Windows.Forms.Label uxSelectMonthLabel;
        private System.Windows.Forms.ComboBox uxSelectYearComboBox;
        private System.Windows.Forms.Label uxSelectYearLabel;
    }
}