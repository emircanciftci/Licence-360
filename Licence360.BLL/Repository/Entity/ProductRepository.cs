using Licence360.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licence360.BLL.Repository.Entity
{
   public class ProductRepository : Base.BaseRepository<Product>
    {
        public bool UpdateIsActive(int ID)
        {
            bool result;
            var dbResult = this.Find(ID);
            if (dbResult.IsActive == true)
            {
                dbResult.IsActive = false;
                result = false;
            }
            else
            {
                dbResult.IsActive = true;
                result = true;
            }
            this.Save();
            return result;
        }
    }
}
