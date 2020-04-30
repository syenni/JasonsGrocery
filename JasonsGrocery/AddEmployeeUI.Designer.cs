namespace JasonsGrocery
{
    partial class AddEmployeeUI
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
            this.uxWorkPositionComboBox = new System.Windows.Forms.ComboBox();
            this.uxHourlyPayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxHourlyPayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxEmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.uxWorkPositionLabel = new System.Windows.Forms.Label();
            this.uxDepartmentNameLabel = new System.Windows.Forms.Label();
            this.uxDeparmentNameComboBox = new System.Windows.Forms.ComboBox();
            this.uxAddEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxHourlyPayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxWorkPositionComboBox
            // 
            this.uxWorkPositionComboBox.Enabled = false;
            this.uxWorkPositionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWorkPositionComboBox.FormattingEnabled = true;
            this.uxWorkPositionComboBox.Items.AddRange(new object[] {
            "Clerk",
            "Manager",
            "Assistant Manager",
            "Janitor",
            "Director",
            "Cashier"});
            this.uxWorkPositionComboBox.Location = new System.Drawing.Point(111, 71);
            this.uxWorkPositionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxWorkPositionComboBox.Name = "uxWorkPositionComboBox";
            this.uxWorkPositionComboBox.Size = new System.Drawing.Size(79, 24);
            this.uxWorkPositionComboBox.TabIndex = 19;
            this.uxWorkPositionComboBox.SelectedIndexChanged += new System.EventHandler(this.uxWorkPositionComboBox_SelectedIndexChanged);
            // 
            // uxHourlyPayNumericUpDown
            // 
            this.uxHourlyPayNumericUpDown.DecimalPlaces = 2;
            this.uxHourlyPayNumericUpDown.Enabled = false;
            this.uxHourlyPayNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHourlyPayNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.uxHourlyPayNumericUpDown.Location = new System.Drawing.Point(111, 105);
            this.uxHourlyPayNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.uxHourlyPayNumericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.uxHourlyPayNumericUpDown.Name = "uxHourlyPayNumericUpDown";
            this.uxHourlyPayNumericUpDown.Size = new System.Drawing.Size(78, 22);
            this.uxHourlyPayNumericUpDown.TabIndex = 17;
            this.uxHourlyPayNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxHourlyPayNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // uxHourlyPayLabel
            // 
            this.uxHourlyPayLabel.AutoSize = true;
            this.uxHourlyPayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHourlyPayLabel.Location = new System.Drawing.Point(29, 107);
            this.uxHourlyPayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxHourlyPayLabel.Name = "uxHourlyPayLabel";
            this.uxHourlyPayLabel.Size = new System.Drawing.Size(77, 16);
            this.uxHourlyPayLabel.TabIndex = 18;
            this.uxHourlyPayLabel.Text = "Hourly Pay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name:";
            // 
            // uxEmployeeNameTextBox
            // 
            this.uxEmployeeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEmployeeNameTextBox.Location = new System.Drawing.Point(111, 6);
            this.uxEmployeeNameTextBox.Name = "uxEmployeeNameTextBox";
            this.uxEmployeeNameTextBox.Size = new System.Drawing.Size(78, 22);
            this.uxEmployeeNameTextBox.TabIndex = 21;
            this.uxEmployeeNameTextBox.TextChanged += new System.EventHandler(this.uxEmployeeNameTextBox_TextChanged);
            // 
            // uxWorkPositionLabel
            // 
            this.uxWorkPositionLabel.AutoSize = true;
            this.uxWorkPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWorkPositionLabel.Location = new System.Drawing.Point(12, 74);
            this.uxWorkPositionLabel.Name = "uxWorkPositionLabel";
            this.uxWorkPositionLabel.Size = new System.Drawing.Size(94, 16);
            this.uxWorkPositionLabel.TabIndex = 22;
            this.uxWorkPositionLabel.Text = "Work Position:";
            // 
            // uxDepartmentNameLabel
            // 
            this.uxDepartmentNameLabel.AutoSize = true;
            this.uxDepartmentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDepartmentNameLabel.Location = new System.Drawing.Point(25, 41);
            this.uxDepartmentNameLabel.Name = "uxDepartmentNameLabel";
            this.uxDepartmentNameLabel.Size = new System.Drawing.Size(81, 16);
            this.uxDepartmentNameLabel.TabIndex = 24;
            this.uxDepartmentNameLabel.Text = "Department:";
            // 
            // uxDeparmentNameComboBox
            // 
            this.uxDeparmentNameComboBox.Enabled = false;
            this.uxDeparmentNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDeparmentNameComboBox.FormattingEnabled = true;
            this.uxDeparmentNameComboBox.Items.AddRange(new object[] {
            "Dairy",
            "Deli",
            "Bakery",
            "Produce"});
            this.uxDeparmentNameComboBox.Location = new System.Drawing.Point(111, 38);
            this.uxDeparmentNameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxDeparmentNameComboBox.Name = "uxDeparmentNameComboBox";
            this.uxDeparmentNameComboBox.Size = new System.Drawing.Size(78, 24);
            this.uxDeparmentNameComboBox.TabIndex = 23;
            this.uxDeparmentNameComboBox.SelectedIndexChanged += new System.EventHandler(this.uxDeparmentNameComboBox_SelectedIndexChanged);
            // 
            // uxAddEmployeeButton
            // 
            this.uxAddEmployeeButton.Enabled = false;
            this.uxAddEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddEmployeeButton.Location = new System.Drawing.Point(19, 132);
            this.uxAddEmployeeButton.Name = "uxAddEmployeeButton";
            this.uxAddEmployeeButton.Size = new System.Drawing.Size(174, 23);
            this.uxAddEmployeeButton.TabIndex = 25;
            this.uxAddEmployeeButton.Text = "Add Employee";
            this.uxAddEmployeeButton.UseVisualStyleBackColor = true;
            this.uxAddEmployeeButton.Click += new System.EventHandler(this.uxAddEmployeeButton_Click);
            // 
            // AddEmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 165);
            this.Controls.Add(this.uxAddEmployeeButton);
            this.Controls.Add(this.uxDepartmentNameLabel);
            this.Controls.Add(this.uxDeparmentNameComboBox);
            this.Controls.Add(this.uxWorkPositionLabel);
            this.Controls.Add(this.uxEmployeeNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxWorkPositionComboBox);
            this.Controls.Add(this.uxHourlyPayNumericUpDown);
            this.Controls.Add(this.uxHourlyPayLabel);
            this.Name = "AddEmployeeUI";
            this.Text = "AddEmployeeUI";
            ((System.ComponentModel.ISupportInitialize)(this.uxHourlyPayNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxWorkPositionComboBox;
        private System.Windows.Forms.NumericUpDown uxHourlyPayNumericUpDown;
        private System.Windows.Forms.Label uxHourlyPayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxEmployeeNameTextBox;
        private System.Windows.Forms.Label uxWorkPositionLabel;
        private System.Windows.Forms.Label uxDepartmentNameLabel;
        private System.Windows.Forms.ComboBox uxDeparmentNameComboBox;
        private System.Windows.Forms.Button uxAddEmployeeButton;
    }
}