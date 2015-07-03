using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SupplierData
    {
        static public string GetSupplierNameByID(int id)
        {
            using (NorthwindEntities context = new NorthwindEntities())
            {
                try
                {
                    return context.Suppliers.Where(x => x.SupplierID == id).FirstOrDefault().CompanyName;
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
