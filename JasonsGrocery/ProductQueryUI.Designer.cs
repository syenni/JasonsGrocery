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
            this.uxCheckItemStock = new System.Windows.Forms.Button();
            this.uxItemUnderQuantity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxdataGridView = new System.Windows.Forms.DataGridView();
            this.DeliRadioButton = new System.Windows.Forms.RadioButton();
            this.ProduceRadioButton = new System.Windows.Forms.RadioButton();
            this.BakeryRadioButton = new System.Windows.Forms.RadioButton();
            this.DairyRadioButton = new System.Windows.Forms.RadioButton();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uxTopProducts = new System.Windows.Forms.Button();
            this.uxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxPriceHighToLow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.uxdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxCheckItemStock
            // 
            this.uxCheckItemStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCheckItemStock.Location = new System.Drawing.Point(24, 97);
            this.uxCheckItemStock.Margin = new System.Windows.Forms.Padding(4);
            this.uxCheckItemStock.Name = "uxCheckItemStock";
            this.uxCheckItemStock.Size = new System.Drawing.Size(173, 46);
            this.uxCheckItemStock.TabIndex = 0;
            this.uxCheckItemStock.Text = "Check Item Stock";
            this.uxCheckItemStock.UseVisualStyleBackColor = true;
            this.uxCheckItemStock.Click += new System.EventHandler(this.UxCheckItemStock_Click);
            // 
            // uxItemUnderQuantity
            // 
            this.uxItemUnderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxItemUnderQuantity.Location = new System.Drawing.Point(24, 223);
            this.uxItemUnderQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.uxItemUnderQuantity.Name = "uxItemUnderQuantity";
            this.uxItemUnderQuantity.Size = new System.Drawing.Size(173, 52);
            this.uxItemUnderQuantity.TabIndex = 1;
            this.uxItemUnderQuantity.Text = "Item Under Quantity";
            this.uxItemUnderQuantity.UseVisualStyleBackColor = true;
            this.uxItemUnderQuantity.Click += new System.EventHandler(this.uxItemUnderQuantity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chooose Department:";
            // 
            // uxdataGridView
            // 
            this.uxdataGridView.AllowUserToDeleteRows = false;
            this.uxdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxdataGridView.Location = new System.Drawing.Point(261, 9);
            this.uxdataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.uxdataGridView.Name = "uxdataGridView";
            this.uxdataGridView.RowHeadersWidth = 51;
            this.uxdataGridView.Size = new System.Drawing.Size(789, 490);
            this.uxdataGridView.TabIndex = 5;
            // 
            // DeliRadioButton
            // 
            this.DeliRadioButton.AutoSize = true;
            this.DeliRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.DeliRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliRadioButton.Location = new System.Drawing.Point(24, 32);
            this.DeliRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeliRadioButton.Name = "DeliRadioButton";
            this.DeliRadioButton.Size = new System.Drawing.Size(60, 24);
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
            this.ProduceRadioButton.Location = new System.Drawing.Point(116, 32);
            this.ProduceRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProduceRadioButton.Name = "ProduceRadioButton";
            this.ProduceRadioButton.Size = new System.Drawing.Size(92, 24);
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
            this.BakeryRadioButton.Location = new System.Drawing.Point(116, 65);
            this.BakeryRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.BakeryRadioButton.Name = "BakeryRadioButton";
            this.BakeryRadioButton.Size = new System.Drawing.Size(82, 24);
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
            this.DairyRadioButton.Location = new System.Drawing.Point(24, 65);
            this.DairyRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.DairyRadioButton.Name = "DairyRadioButton";
            this.DairyRadioButton.Size = new System.Drawing.Size(70, 24);
            this.DairyRadioButton.TabIndex = 9;
            this.DairyRadioButton.TabStop = true;
            this.DairyRadioButton.Text = "Dairy";
            this.DairyRadioButton.UseVisualStyleBackColor = false;
            this.DairyRadioButton.Click += new System.EventHandler(this.DairyRadioButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(16, 459);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 39);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.uxTopProducts);
            this.panel1.Controls.Add(this.uxNumericUpDown);
            this.panel1.Controls.Add(this.uxPriceHighToLow);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProduceRadioButton);
            this.panel1.Controls.Add(this.DeliRadioButton);
            this.panel1.Controls.Add(this.uxCheckItemStock);
            this.panel1.Controls.Add(this.uxItemUnderQuantity);
            this.panel1.Controls.Add(this.DairyRadioButton);
            this.panel1.Controls.Add(this.BakeryRadioButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 443);
            this.panel1.TabIndex = 12;
            // 
            // uxTopProducts
            // 
            this.uxTopProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTopProducts.Location = new System.Drawing.Point(24, 367);
            this.uxTopProducts.Margin = new System.Windows.Forms.Padding(4);
            this.uxTopProducts.Name = "uxTopProducts";
            this.uxTopProducts.Size = new System.Drawing.Size(173, 64);
            this.uxTopProducts.TabIndex = 16;
            this.uxTopProducts.Text = "Top 10 Products";
            this.uxTopProducts.UseVisualStyleBackColor = true;
            // 
            // uxNumericUpDown
            // 
            this.uxNumericUpDown.Location = new System.Drawing.Point(51, 193);
            this.uxNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxNumericUpDown.Name = "uxNumericUpDown";
            this.uxNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.uxNumericUpDown.TabIndex = 13;
            // 
            // uxPriceHighToLow
            // 
            this.uxPriceHighToLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPriceHighToLow.Location = new System.Drawing.Point(24, 295);
            this.uxPriceHighToLow.Margin = new System.Windows.Forms.Padding(4);
            this.uxPriceHighToLow.Name = "uxPriceHighToLow";
            this.uxPriceHighToLow.Size = new System.Drawing.Size(173, 64);
            this.uxPriceHighToLow.TabIndex = 15;
            this.uxPriceHighToLow.Text = "Price(High->Low)";
            this.uxPriceHighToLow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Items Under Quantity:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, 151);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 136);
            this.panel2.TabIndex = 17;
            // 
            // uxProductQueryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 517);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.uxdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uxProductQueryUI";
            this.Text = "ProductQueryUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerUI_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.uxdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxCheckItemStock;
        private System.Windows.Forms.Button uxItemUnderQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uxdataGridView;
        private System.Windows.Forms.RadioButton DeliRadioButton;
        private System.Windows.Forms.RadioButton ProduceRadioButton;
        private System.Windows.Forms.RadioButton BakeryRadioButton;
        private System.Windows.Forms.RadioButton DairyRadioButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uxTopProducts;
        private System.Windows.Forms.NumericUpDown uxNumericUpDown;
        private System.Windows.Forms.Button uxPriceHighToLow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}