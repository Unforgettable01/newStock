using BusinessLogic.Interfaces;
using BusinessLogic.Logic;
using DatabaseImplement.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace newStock
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<IWorkerStorage, WorkerStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<WorkerBusinessLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<ICustomerStorage, CustomerStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<CustomerBusinessLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IProductStorage, ProductStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<ProductBusinessLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IBuyStorage, BuyStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<BuyBusinessLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IDeliveryStorage, DeliveryStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<DeliveryBusinessLogic>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }

}
