using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.BD.EntitiesBD.Repositories
{
    public class CommentsRepository
    {
        private BDContext context;

        public CommentsRepository(BDContext context)
        {
            this.context = context;
        }

        public bool AddComments(Comments Comment)
        {
            try
            {
                context.Comments.Add(Comment);

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
