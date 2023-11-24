namespace Inventory
{
    partial class Form1
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
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.sellPriceTextBox = new System.Windows.Forms.TextBox();
            this.mfgDatePicker = new System.Windows.Forms.DateTimePicker();
            this.expDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productDescTextBox = new System.Windows.Forms.RichTextBox();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.gridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(52, 33);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(251, 22);
            this.productNameTextBox.TabIndex = 1;
            // 
            // sellPriceTextBox
            // 
            this.sellPriceTextBox.Location = new System.Drawing.Point(52, 149);
            this.sellPriceTextBox.Name = "sellPriceTextBox";
            this.sellPriceTextBox.Size = new System.Drawing.Size(251, 22);
            this.sellPriceTextBox.TabIndex = 4;
            this.sellPriceTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // mfgDatePicker
            // 
            this.mfgDatePicker.Location = new System.Drawing.Point(52, 345);
            this.mfgDatePicker.Name = "mfgDatePicker";
            this.mfgDatePicker.Size = new System.Drawing.Size(200, 22);
            this.mfgDatePicker.TabIndex = 8;
            this.mfgDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // expDatePicker
            // 
            this.expDatePicker.Location = new System.Drawing.Point(52, 401);
            this.expDatePicker.Name = "expDatePicker";
            this.expDatePicker.Size = new System.Drawing.Size(200, 22);
            this.expDatePicker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sell Price";
            // 
            // productDataGrid
            // 
            this.productDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGrid.Location = new System.Drawing.Point(360, 33);
            this.productDataGrid.Name = "productDataGrid";
            this.productDataGrid.RowHeadersWidth = 51;
            this.productDataGrid.RowTemplate.Height = 24;
            this.productDataGrid.Size = new System.Drawing.Size(968, 321);
            this.productDataGrid.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Product Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mfg. Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Exp. Date";
            // 
            // productDescTextBox
            // 
            this.productDescTextBox.Location = new System.Drawing.Point(52, 259);
            this.productDescTextBox.Name = "productDescTextBox";
            this.productDescTextBox.Size = new System.Drawing.Size(251, 35);
            this.productDescTextBox.TabIndex = 19;
            this.productDescTextBox.Text = "";
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(53, 91);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(250, 22);
            this.quantityUpDown.TabIndex = 20;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(53, 201);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(250, 24);
            this.categoryComboBox.TabIndex = 21;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.Location = new System.Drawing.Point(798, 379);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(158, 44);
            this.addProductBtn.TabIndex = 22;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 450);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.productDescTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productDataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expDatePicker);
            this.Controls.Add(this.mfgDatePicker);
            this.Controls.Add(this.sellPriceTextBox);
            this.Controls.Add(this.productNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox sellPriceTextBox;
        private System.Windows.Forms.DateTimePicker mfgDatePicker;
        private System.Windows.Forms.DateTimePicker expDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView productDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox productDescTextBox;
        private System.Windows.Forms.NumericUpDown quantityUpDown;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.BindingSource gridBindingSource;
    }
}

