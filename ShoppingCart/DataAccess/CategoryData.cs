using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryData
    {
        static public List<Category> GetAll()
        {
            using (NorthwindEntities context = new NorthwindEntities())
            {
                try
                {
                    return context.Categories.ToList();
                }
                catch (EntityException entityExcp)
                {
                    Logger.Write(entityExcp);
                    return null;
                }
            }
        }

        static public Category GetByID(int id)
        {
            using (NorthwindEntities context = new NorthwindEntities())
            {
                try
                {
                    return context.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
                }
                catch (EntityException entityExcp)
                {
                    Logger.Write(entityExcp);
                    return null;
                }

            }
        }
    }
}
