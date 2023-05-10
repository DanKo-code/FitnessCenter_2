using FitnessCenter.BD.EntitiesBD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.BD.EntitiesBD
{
    public class Couches
    {
        public Guid Id { get; set; }

        public string Photo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Services> Services { get; set; }

    }
}
