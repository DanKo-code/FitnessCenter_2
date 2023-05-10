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

        //public List<Couches> GetAllCouches()
        //{
        //    try
        //    {
        //        //TODO СХУЯЛИ НЕ ВИДЕН CONTEXT COUCHES!!!!???????????????
        //        //return context.
        //    }
        //    catch
        //    {
        //        return new List<Couches>();
        //    }
        //}
    }
}
