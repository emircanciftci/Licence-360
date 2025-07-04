using Licence360.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licence360.BLL.Repository.Entity
{
    public class CustomerRepository : Base.BaseRepository<Customer>
    {
        public bool Update(Customer dat)
        {
            var gelen = this.Find(dat.ID);
            gelen.CompanyName = dat.CompanyName;
            gelen.AuthPerson = dat.AuthPerson;
            gelen.Email = dat.Email;
            gelen.Phone = dat.Phone;
            gelen.Address = dat.Address;
            this.Save();
            return true;

        }
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
