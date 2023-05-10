using FitnessCenter.BD.EntitiesBD.Repositories;
using FitnessCenter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.ViewModel
{
    public class CouchesViewModel : ObservableObject
    {
        private UnitOfWork context;

        #region Accessors (helpers for ui design)

        #endregion

        #region Commands

        #endregion

        public CouchesViewModel()
        {
            context = new UnitOfWork();

           
        }
    }
}
