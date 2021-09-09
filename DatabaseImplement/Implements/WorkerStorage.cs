using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseImplement.Implements
{
    public class WorkerStorage: IWorkerStorage
    {
        public List<WorkerViewModel> GetFullList()
        {
            using (var context = new newStockContext())
            {
                return context.Worker
                .Select(CreateModel).ToList();
            }
        }

        public List<WorkerViewModel> GetFilteredList(WorkerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new newStockContext())
            {
                return context.Worker
                    .Where(rec =>
                    rec.Fio.Contains(model.WorkerName) || (rec.Login.Equals(model.Login) && rec.Password.Equals(model.Password)))
                    .Select(CreateModel).ToList();
            }
        }

        public WorkerViewModel GetElement(WorkerBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new newStockContext())
            {
                var worker = context.Worker
                .FirstOrDefault(rec => rec.Login.Equals(model.Login) || rec.Id == model.Id);
                return worker != null ?
                CreateModel(worker) : null;
            }
        }

        public void Insert(WorkerBindingModel model)
        {
            using (var context = new newStockContext())
            {
                context.Worker.Add(CreateModel(model, new Worker()));
                context.SaveChanges();
            }
        }

        public void Update(WorkerBindingModel model)
        {
            using (var context = new newStockContext())
            {
                var element = context.Worker.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Работник не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(WorkerBindingModel model)
        {
            using (var context = new newStockContext())
            {
                Worker element = context.Worker.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Worker.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Работник не найден");
                }
            }
        }

        private Worker CreateModel(WorkerBindingModel model, Worker worker)
        {
            worker.Fio = model.WorkerName;
            worker.Login = model.Login;
            worker.Password = model.Password;
            return worker;
        }

        private WorkerViewModel CreateModel(Worker worker)
        {
            return new WorkerViewModel
            {
                Id = worker.Id,
                WorkerName = worker.Fio,
                Login = worker.Login,
                Password = worker.Password
            };
        }
    }
}
