using BusinessLogic.BindingModels;
using BusinessLogic.Logic;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace newStock
{
    public partial class Buy : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly BuyBusinessLogic buyLogic;
        private readonly CustomerBusinessLogic customerLogic;
        public Buy(BuyBusinessLogic bLog, CustomerBusinessLogic cLog)
        {
            InitializeComponent();
            buyLogic = bLog;
            customerLogic = cLog;
        }

        private void FormCreateBuy_Load(object sender, EventArgs e)
        {
            try
            {
                List<CustomerViewModel> list = customerLogic.Read(null);
                if (list != null)
                {
                    comboBoxCustomers.DisplayMember = "CustomerName";
                    comboBoxCustomers.ValueMember = "Id";
                    comboBoxCustomers.DataSource = list;
                    comboBoxCustomers.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxCustomers.Text))
            {
                MessageBox.Show("Заполните поле ФИО Покупателя", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(dateTimePickerBuyDate.Text))
            {
                MessageBox.Show("Заполните поле Дата покупки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                buyLogic.CreateBuy(new BuyBindingModel
                {
                    CustomerId = Convert.ToInt32(comboBoxCustomers.SelectedValue),
                    DateBuy = dateTimePickerBuyDate.Value
                }); ;
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
