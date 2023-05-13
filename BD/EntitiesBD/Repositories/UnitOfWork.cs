using FitnessCenter.BD.Repositories.EntitiesBD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.BD.EntitiesBD.Repositories
{
    class UnitOfWork : IDisposable
    {
        private BDContext context = new BDContext();
        private bool disposed = false;

        private AbonementRepository abonementRepo;
        private ClientRepository clientRepo;
        private OrderRepository orderRepo;
        private ServiceRepository serviceRepo;
        private CouchesRepository coucheRepo;
        private CommentsRepository commentsRepo;

        public CommentsRepository CommentsRepo
        {
            get
            {
                if (commentsRepo == null)
                    commentsRepo = new CommentsRepository(context);
                return commentsRepo;
            }
        }

        public CouchesRepository CoucheRepo
        {
            get
            {
                if (coucheRepo == null)
                    coucheRepo = new CouchesRepository(context);
                return coucheRepo;
            }
        }

        public ServiceRepository ServiceRepo
        {
            get
            {
                if (serviceRepo == null)
                    serviceRepo = new ServiceRepository(context);
                return serviceRepo;
            }
        }

        public AbonementRepository AbonementRepo
        {
            get
            {
                if (abonementRepo == null)
                    abonementRepo = new AbonementRepository(context);
                return abonementRepo;
            }
        }

        public ClientRepository ClientRepo
        {
            get
            {
                if(clientRepo == null)
                    clientRepo = new ClientRepository(context);
                return clientRepo;
            }
        }

        public OrderRepository OrderRepo
        {
            get
            {
                if (orderRepo == null)
                    orderRepo = new OrderRepository(context);
                return orderRepo;
            }
        }

        public void Save() => context.SaveChanges();


        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    context.Dispose();
                this.disposed = true;
            }
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

