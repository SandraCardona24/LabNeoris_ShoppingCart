using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductData
    {
        public static Product GetById(int id)
        {
            using (var context = new NorthwindEntities())
            {
                try
                {
                    return context.Products.Where(x => x.ProductID == id).FirstOrDefault();
                }
                catch (EntityException entityExcp)
                {
                    Logger.Write(entityExcp);
                    return null;
                }
            }
        }

        public static List<Product> GetAll()
        {
            using (var context = new NorthwindEntities())
            {
                try
                {
                    return context.Products.ToList();
                }
                catch (EntityException entityExcp)
                {
                    Logger.Write(entityExcp);
                    return null;
                }
            }
        }

        public static void UpdateProduct(Product product)
        {
            using (var context = new NorthwindEntities())
            {
                try
                {
                    context.Entry(product).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (EntityException entityExcp)
                {
                    Logger.Write(entityExcp);
                    return;
                }
            }
        }
    }
}
