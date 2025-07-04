using Licence360.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licence360.BLL.Repository.Entity
{
    public class AdminUserRepository : Base.BaseRepository<AdminUser>
    {
        public AdminUser LoginCheck(AdminUser vm)
        {
            AdminUser result = new AdminUser();

            AdminUser au = this.GetAll().Where(x => x.UserName == vm.UserName && x.Password == vm.Password).FirstOrDefault();

            if (au != null)
            {
                result = au;
            }
            else
            {
                result = new AdminUser();
            }

            return result;
        }
    }
}
