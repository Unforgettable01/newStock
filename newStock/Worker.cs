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
    public partial class Worker : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly WorkerBusinessLogic workerLogic;
        public Worker(WorkerBusinessLogic logic)
        {
            InitializeComponent();
            workerLogic = logic;
        }

        WorkerViewModel  view;
        private void LoadData()
        {
            try
            {
                var list = workerLogic.Read(null);
                if (list != null)
                {
                    dataGridViewWorkers.DataSource = list;
                    dataGridViewWorkers.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void FormWorkers_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIOWorker.Text))
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
                    workerLogic.CreateOrUpdate(new WorkerBindingModel
                    {
                        Id = view.Id,
                        WorkerName = textBoxFIOWorker.Text,
                        Login = textBoxLogin.Text,
                        Password=textBoxPassword.Text,
                    });
                }
                else
                {
                    workerLogic.CreateOrUpdate(new WorkerBindingModel
                    {
                        WorkerName = textBoxFIOWorker.Text,
                        Login = textBoxLogin.Text,
                        Password=textBoxPassword.Text,
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
