
namespace newStock
{
    partial class Buy
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
            this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
            this.labelNameCustomer = new System.Windows.Forms.Label();
            this.dateTimePickerBuyDate = new System.Windows.Forms.DateTimePicker();
            this.labelBuyDate = new System.Windows.Forms.Label();
            this.buttonSaveBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.FormattingEnabled = true;
            this.comboBoxCustomers.Location = new System.Drawing.Point(228, 24);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.Size = new System.Drawing.Size(543, 28);
            this.comboBoxCustomers.TabIndex = 0;
            // 
            // labelNameCustomer
            // 
            this.labelNameCustomer.AutoSize = true;
            this.labelNameCustomer.Location = new System.Drawing.Point(13, 24);
            this.labelNameCustomer.Name = "labelNameCustomer";
            this.labelNameCustomer.Size = new System.Drawing.Size(209, 30);
            this.labelNameCustomer.TabIndex = 1;
            this.labelNameCustomer.Text = "ФИО покупателя";
            // 
            // dateTimePickerBuyDate
            // 
            this.dateTimePickerBuyDate.Location = new System.Drawing.Point(571, 76);
            this.dateTimePickerBuyDate.Name = "dateTimePickerBuyDate";
            this.dateTimePickerBuyDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerBuyDate.TabIndex = 2;
            // 
            // labelBuyDate
            // 
            this.labelBuyDate.AutoSize = true;
            this.labelBuyDate.Location = new System.Drawing.Point(17, 81);
            this.labelBuyDate.Name = "labelBuyDate";
            this.labelBuyDate.Size = new System.Drawing.Size(282, 30);
            this.labelBuyDate.TabIndex = 3;
            this.labelBuyDate.Text = "Выберите дату покупки";
            // 
            // buttonSaveBuy
            // 
            this.buttonSaveBuy.Location = new System.Drawing.Point(326, 180);
            this.buttonSaveBuy.Name = "buttonSaveBuy";
            this.buttonSaveBuy.Size = new System.Drawing.Size(115, 41);
            this.buttonSaveBuy.TabIndex = 4;
            this.buttonSaveBuy.Text = "Оформить";
            this.buttonSaveBuy.UseVisualStyleBackColor = true;
            this.buttonSaveBuy.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveBuy);
            this.Controls.Add(this.labelBuyDate);
            this.Controls.Add(this.dateTimePickerBuyDate);
            this.Controls.Add(this.labelNameCustomer);
            this.Controls.Add(this.comboBoxCustomers);
            this.Name = "Buy";
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.Windows.Forms.Label labelNameCustomer;
        private System.Windows.Forms.DateTimePicker dateTimePickerBuyDate;
        private System.Windows.Forms.Label labelBuyDate;
        private System.Windows.Forms.Button buttonSaveBuy;
    }
}