using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface IAdminRepository
    {

        bool Insert(Admin b);
        bool Update(Admin b);
        bool Delete(string aid);

        List<Admin> GetAdmin(string aid);

        List<Admin> GetAllAdmin();


      

    }
}
