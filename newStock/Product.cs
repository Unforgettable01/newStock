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
    public partial class Product : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ProductBusinessLogic productLogic;
        public Product(ProductBusinessLogic logic)
        {
            InitializeComponent();

            productLogic = logic;
        }
        ProductViewModel view;
        private void LoadData()
        {
            try
            {
                var list = productLogic.Read(null);
                if (list != null)
                {
                    dataGridViewProducts.DataSource = list;
                    dataGridViewProducts.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            

            try
            {
                if (view != null)
                {
                    productLogic.CreateOrUpdate(new ProductBindingModel
                    {
                        Id = view.Id,
                        ProductName = textBoxProductName.Text                       
                    });
                }
                else
                {
                    productLogic.CreateOrUpdate(new ProductBindingModel
                    {
                        ProductName = textBoxProductName.Text                        
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
