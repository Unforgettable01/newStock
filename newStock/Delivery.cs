using BusinessLogic.BindingModels;
using BusinessLogic.Logic;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace newStock
{
    public partial class Delivery : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly DeliveryBusinessLogic deliveryLogic;
        private readonly WorkerBusinessLogic workerLogic;

        public Delivery(DeliveryBusinessLogic delLog, WorkerBusinessLogic worLog)
        {
            InitializeComponent();
            deliveryLogic = delLog;
            workerLogic = worLog;
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                List<WorkerViewModel> list = workerLogic.Read(null);
                if (list != null)
                {
                    comboBoxWorkers.DisplayMember = "WorkerName";
                    comboBoxWorkers.ValueMember = "Id";
                    comboBoxWorkers.DataSource = list;
                    comboBoxWorkers.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveDelivery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxWorkers.Text))
            {
                MessageBox.Show("Заполните поле ФИО Сотрудника", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(dateTimePickerDeliveryDate.Text))
            {
                MessageBox.Show("Заполните поле Дата поставки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                deliveryLogic.CreateDelivery(new DeliveryBindingModel
                {
                    WorkerId = Convert.ToInt32(comboBoxWorkers.SelectedValue),
                    DateDelivery = dateTimePickerDeliveryDate.Value
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
