using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.BD.EntitiesBD.Repositories
{
    public class CouchesRepository
    {
        private BDContext context;

        public CouchesRepository(BDContext context) => this.context = context;

        public List<Couches> GetAllCouches()
        {
            try
            {
                return context.Couches.Include(x=>x.Services).ToList();
            }
            catch
            {
                return new List<Couches>();
            }
        }

        public bool RemoveCouch(Couches Couche)
        {
            try
            {
                context.Couches.Remove(Couche);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddAbonement(Couches couch)
        {
            try
            {
                context.Couches.Add(couch);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SaveAllChanges()
        {
            try
            {
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
