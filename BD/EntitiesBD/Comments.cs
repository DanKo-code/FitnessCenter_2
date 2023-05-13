using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.BD.EntitiesBD
{
    public class Comments
    {
        public Guid Id { get; set; }

        public string CommentBody { get; set; }

        public virtual Clients Clients { get; set; }
        public virtual Couches Couches { get; set; }
    }
}
