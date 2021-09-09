
namespace newStock
{
    partial class Delivery
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
            this.labelWorkerFIO = new System.Windows.Forms.Label();
            this.labelDeliveryDate = new System.Windows.Forms.Label();
            this.comboBoxWorkers = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSaveDelivery = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxCountProduct = new System.Windows.Forms.TextBox();
            this.labelCountProduct = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWorkerFIO
            // 
            this.labelWorkerFIO.AutoSize = true;
            this.labelWorkerFIO.Location = new System.Drawing.Point(59, 60);
            this.labelWorkerFIO.Name = "labelWorkerFIO";
            this.labelWorkerFIO.Size = new System.Drawing.Size(208, 20);
            this.labelWorkerFIO.TabIndex = 0;
            this.labelWorkerFIO.Text = "Укажите ФИО сотрудника";
            // 
            // labelDeliveryDate
            // 
            this.labelDeliveryDate.AutoSize = true;
            this.labelDeliveryDate.Location = new System.Drawing.Point(59, 139);
            this.labelDeliveryDate.Name = "labelDeliveryDate";
            this.labelDeliveryDate.Size = new System.Drawing.Size(199, 20);
            this.labelDeliveryDate.TabIndex = 1;
            this.labelDeliveryDate.Text = "Выберите дату поставки";
            // 
            // comboBoxWorkers
            // 
            this.comboBoxWorkers.FormattingEnabled = true;
            this.comboBoxWorkers.Location = new System.Drawing.Point(14, 98);
            this.comboBoxWorkers.Name = "comboBoxWorkers";
            this.comboBoxWorkers.Size = new System.Drawing.Size(296, 28);
            this.comboBoxWorkers.TabIndex = 2;
            // 
            // dateTimePickerDeliveryDate
            // 
            this.dateTimePickerDeliveryDate.Location = new System.Drawing.Point(63, 186);
            this.dateTimePickerDeliveryDate.Name = "dateTimePickerDeliveryDate";
            this.dateTimePickerDeliveryDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDeliveryDate.TabIndex = 3;
            // 
            // buttonSaveDelivery
            // 
            this.buttonSaveDelivery.Location = new System.Drawing.Point(44, 327);
            this.buttonSaveDelivery.Name = "buttonSaveDelivery";
            this.buttonSaveDelivery.Size = new System.Drawing.Size(239, 54);
            this.buttonSaveDelivery.TabIndex = 4;
            this.buttonSaveDelivery.Text = "Оформить поставку";
            this.buttonSaveDelivery.UseVisualStyleBackColor = true;
            this.buttonSaveDelivery.Click += new System.EventHandler(this.buttonSaveDelivery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelWorkerFIO);
            this.groupBox1.Controls.Add(this.buttonSaveDelivery);
            this.groupBox1.Controls.Add(this.comboBoxWorkers);
            this.groupBox1.Controls.Add(this.dateTimePickerDeliveryDate);
            this.groupBox1.Controls.Add(this.labelDeliveryDate);
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 409);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оформление поставки";
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.buttonSave);
            this.groupBoxProducts.Controls.Add(this.textBoxCountProduct);
            this.groupBoxProducts.Controls.Add(this.labelCountProduct);
            this.groupBoxProducts.Controls.Add(this.labelProducts);
            this.groupBoxProducts.Controls.Add(this.comboBoxProducts);
            this.groupBoxProducts.Location = new System.Drawing.Point(378, 43);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(410, 395);
            this.groupBoxProducts.TabIndex = 6;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Оформление товара";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(75, 316);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(245, 54);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Связать поставку с товаром";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxCountProduct
            // 
            this.textBoxCountProduct.Location = new System.Drawing.Point(173, 231);
            this.textBoxCountProduct.Name = "textBoxCountProduct";
            this.textBoxCountProduct.Size = new System.Drawing.Size(46, 26);
            this.textBoxCountProduct.TabIndex = 7;
            // 
            // labelCountProduct
            // 
            this.labelCountProduct.AutoSize = true;
            this.labelCountProduct.Location = new System.Drawing.Point(113, 177);
            this.labelCountProduct.Name = "labelCountProduct";
            this.labelCountProduct.Size = new System.Drawing.Size(171, 20);
            this.labelCountProduct.TabIndex = 6;
            this.labelCountProduct.Text = "Укажите количество ";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(113, 46);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(207, 20);
            this.labelProducts.TabIndex = 5;
            this.labelProducts.Text = "Укажите названия товара";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(12, 84);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(398, 28);
            this.comboBoxProducts.TabIndex = 4;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxProducts);
            this.Controls.Add(this.groupBox1);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWorkerFIO;
        private System.Windows.Forms.Label labelDeliveryDate;
        private System.Windows.Forms.ComboBox comboBoxWorkers;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeliveryDate;
        private System.Windows.Forms.Button buttonSaveDelivery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.TextBox textBoxCountProduct;
        private System.Windows.Forms.Label labelCountProduct;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Button buttonSave;
    }
}