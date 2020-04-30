namespace JasonsGrocery
{
    partial class SalesQueryUI
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
            this.uxdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uxDailySales = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.uxdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxdateTimePicker
            // 
            this.uxdateTimePicker.Location = new System.Drawing.Point(16, 15);
            this.uxdateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.uxdateTimePicker.Name = "uxdateTimePicker";
            this.uxdateTimePicker.Size = new System.Drawing.Size(236, 22);
            this.uxdateTimePicker.TabIndex = 0;
            // 
            // uxDailySales
            // 
            this.uxDailySales.Location = new System.Drawing.Point(273, 13);
            this.uxDailySales.Margin = new System.Windows.Forms.Padding(4);
            this.uxDailySales.Name = "uxDailySales";
            this.uxDailySales.Size = new System.Drawing.Size(100, 28);
            this.uxDailySales.TabIndex = 1;
            this.uxDailySales.Text = "Daily Sales";
            this.uxDailySales.UseVisualStyleBackColor = true;
            this.uxDailySales.Click += new System.EventHandler(this.UxDailySales_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(16, 414);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(100, 39);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // uxdataGridView
            // 
            this.uxdataGridView.AllowUserToDeleteRows = false;
            this.uxdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxdataGridView.Location = new System.Drawing.Point(13, 51);
            this.uxdataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.uxdataGridView.Name = "uxdataGridView";
            this.uxdataGridView.RowHeadersWidth = 51;
            this.uxdataGridView.Size = new System.Drawing.Size(600, 355);
            this.uxdataGridView.TabIndex = 13;
            // 
            // SalesQueryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 468);
            this.Controls.Add(this.uxdataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.uxDailySales);
            this.Controls.Add(this.uxdateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesQueryUI";
            this.Text = "SalesQueryUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesQueryUI_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.uxdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxdateTimePicker;
        private System.Windows.Forms.Button uxDailySales;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView uxdataGridView;
    }
}