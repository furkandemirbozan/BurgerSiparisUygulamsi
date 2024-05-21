using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Bussiness.Abstract
{
    public interface IWorkerService
    {
        List<Worker> GetAll();
        Worker GetById(int workerId);
        void Add(Worker worker);
        void Update(Worker worker);
        void Delete(Worker worker);
    }
}
