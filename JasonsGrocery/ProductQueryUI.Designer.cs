namespace JasonsGrocery
{
    partial class uxProductQueryUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeliRadioButton = new System.Windows.Forms.RadioButton();
            this.ProduceRadioButton = new System.Windows.Forms.RadioButton();
            this.BakeryRadioButton = new System.Windows.Forms.RadioButton();
            this.DairyRadioButton = new System.Windows.Forms.RadioButton();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check Item Stock";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Item Under Quantity";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chooose Department:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(196, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(592, 398);
            this.dataGridView1.TabIndex = 5;
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
            this.DeliRadioButton.Click += new System.EventHandler(this.DeliRadioButton_Click);
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
            this.ProduceRadioButton.Click += new System.EventHandler(this.ProduceRadioButton_Click);
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
            this.BakeryRadioButton.Click += new System.EventHandler(this.BakeryRadioButton_Click);
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
            this.DairyRadioButton.Click += new System.EventHandler(this.DairyRadioButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 373);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProduceRadioButton);
            this.panel1.Controls.Add(this.DeliRadioButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.DairyRadioButton);
            this.panel1.Controls.Add(this.BakeryRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 360);
            this.panel1.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(18, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 52);
            this.button3.TabIndex = 16;
            this.button3.Text = "Top 10 Products";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(38, 158);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(18, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 52);
            this.button4.TabIndex = 15;
            this.button4.Text = "Price(High->Low)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Items Under Quantity:";
            // 
            // uxProductQueryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "uxProductQueryUI";
            this.Text = "ProductQueryUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerUI_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton DeliRadioButton;
        private System.Windows.Forms.RadioButton ProduceRadioButton;
        private System.Windows.Forms.RadioButton BakeryRadioButton;
        private System.Windows.Forms.RadioButton DairyRadioButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}