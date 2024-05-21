using Microsoft.EntityFrameworkCore;
using Siparis_Bussiness.Abstract;
using Siparis_DAL.Concrete.EfCore;
using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siparis_Bussiness.Concrete
{
    public class WorkerManager : IWorkerService
    {
        EfCoreWorkerDal _workerDal=new EfCoreWorkerDal();
        public void Add(Worker worker)
        {
            _workerDal.Add(worker);
            
        }

        public void Delete(Worker worker)
        {
            _workerDal.Delete(worker);
        }

        public List<Worker> GetAll()
        {
            return _workerDal.GetAll();
        }

        public Worker GetById(int workerId)
        {
            return _workerDal.GetById(workerId);
        }

        public void Update(Worker worker)
        {
            _workerDal.Update(worker);
        }
    }
}
