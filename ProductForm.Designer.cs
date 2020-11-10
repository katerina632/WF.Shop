namespace _6__MultiWindow
{
    partial class ProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.canselButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pricenumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.countNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.countryComboBox1 = new System.Windows.Forms.ComboBox();
            this.discountNumericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pricenumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discount:";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.Location = new System.Drawing.Point(23, 271);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(104, 56);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Create";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // canselButton
            // 
            this.canselButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canselButton.Location = new System.Drawing.Point(194, 271);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(104, 56);
            this.canselButton.TabIndex = 6;
            this.canselButton.Text = "Cansel";
            this.canselButton.UseVisualStyleBackColor = true;
            this.canselButton.Click += new System.EventHandler(this.canselButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(107, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(168, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // pricenumericUpDown1
            // 
            this.pricenumericUpDown1.Location = new System.Drawing.Point(106, 86);
            this.pricenumericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pricenumericUpDown1.Name = "pricenumericUpDown1";
            this.pricenumericUpDown1.Size = new System.Drawing.Size(169, 20);
            this.pricenumericUpDown1.TabIndex = 8;
            // 
            // countNumericUpDown2
            // 
            this.countNumericUpDown2.Location = new System.Drawing.Point(106, 123);
            this.countNumericUpDown2.Name = "countNumericUpDown2";
            this.countNumericUpDown2.Size = new System.Drawing.Size(169, 20);
            this.countNumericUpDown2.TabIndex = 9;
            // 
            // countryComboBox1
            // 
            this.countryComboBox1.FormattingEnabled = true;
            this.countryComboBox1.Items.AddRange(new object[] {
            "Ukraine",
            "China",
            "USA",
            "Thailand",
            "Poland"});
            this.countryComboBox1.Location = new System.Drawing.Point(106, 161);
            this.countryComboBox1.Name = "countryComboBox1";
            this.countryComboBox1.Size = new System.Drawing.Size(169, 21);
            this.countryComboBox1.TabIndex = 10;
            // 
            // discountNumericUpDown3
            // 
            this.discountNumericUpDown3.Location = new System.Drawing.Point(107, 209);
            this.discountNumericUpDown3.Name = "discountNumericUpDown3";
            this.discountNumericUpDown3.Size = new System.Drawing.Size(168, 20);
            this.discountNumericUpDown3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(131, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "INFO";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 365);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.discountNumericUpDown3);
            this.Controls.Add(this.countryComboBox1);
            this.Controls.Add(this.countNumericUpDown2);
            this.Controls.Add(this.pricenumericUpDown1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.canselButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "Product Form";
            ((System.ComponentModel.ISupportInitialize)(this.pricenumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button canselButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown pricenumericUpDown1;
        private System.Windows.Forms.NumericUpDown countNumericUpDown2;
        private System.Windows.Forms.ComboBox countryComboBox1;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown3;
        private System.Windows.Forms.Label label6;
    }
}