
namespace newStock
{
    partial class FormMain
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
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonDelivery = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.Location = new System.Drawing.Point(38, 18);
            this.buttonWorkers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(112, 35);
            this.buttonWorkers.TabIndex = 0;
            this.buttonWorkers.Text = "Сотрудники";
            this.buttonWorkers.UseVisualStyleBackColor = true;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Location = new System.Drawing.Point(38, 63);
            this.buttonCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(112, 35);
            this.buttonCustomers.TabIndex = 1;
            this.buttonCustomers.Text = "Покупатели";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(38, 108);
            this.buttonProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(112, 35);
            this.buttonProducts.TabIndex = 2;
            this.buttonProducts.Text = "Товар";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonDelivery
            // 
            this.buttonDelivery.Location = new System.Drawing.Point(38, 152);
            this.buttonDelivery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelivery.Name = "buttonDelivery";
            this.buttonDelivery.Size = new System.Drawing.Size(112, 35);
            this.buttonDelivery.TabIndex = 3;
            this.buttonDelivery.Text = "Поставка";
            this.buttonDelivery.UseVisualStyleBackColor = true;
            this.buttonDelivery.Click += new System.EventHandler(this.buttonDelivery_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(38, 197);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(112, 35);
            this.buttonBuy.TabIndex = 4;
            this.buttonBuy.Text = "Продажа";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.UseWaitCursor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonDelivery);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonCustomers);
            this.Controls.Add(this.buttonWorkers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonDelivery;
        private System.Windows.Forms.Button buttonBuy;
    }
}