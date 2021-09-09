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
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Worker>();
            form.ShowDialog();

        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Customer>();
            form.ShowDialog();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Product>();
            form.ShowDialog();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Buy>();
            form.ShowDialog();
        }

        private void buttonDelivery_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<Delivery>();
            form.ShowDialog();
        }
    }
}
