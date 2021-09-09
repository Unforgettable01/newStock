using BusinessLogic.BindingModels;
using BusinessLogic.Logic;
using BusinessLogic.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace newStock
{
    public partial class Customer : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly CustomerBusinessLogic customerLogic;
        public Customer(CustomerBusinessLogic logic)
        {
            InitializeComponent();
            customerLogic = logic;
        }
        CustomerViewModel view;
        private void LoadData()
        {
            try
            {
                var list = customerLogic.Read(null);
                if (list != null)
                {
                    dataGridViewCustomers.DataSource = list;
                    dataGridViewCustomers.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIOCustomer.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (view != null)
                {
                    customerLogic.CreateOrUpdate(new CustomerBindingModel
                    {
                        Id = view.Id,
                        CustomerName = textBoxFIOCustomer.Text,
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                    });
                }
                else
                {
                    customerLogic.CreateOrUpdate(new CustomerBindingModel
                    {
                        CustomerName = textBoxFIOCustomer.Text,
                        Login = textBoxLogin.Text,
                        Password = textBoxPassword.Text,
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DbUpdateException exe)
            {
                MessageBox.Show(exe?.InnerException?.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
