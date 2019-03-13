using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;
using IDAL;
using Model;

namespace BLL
{
    public class AdminBll
    {
        static IDal<AdminInfo> adminDal =null;
        static AdminBll()
        {
            if (adminDal == null)
            {
                adminDal = FactoryHelper<AdminInfo>.GetFactory().CreateDal("admin");
            }
        }
        public static int Create(AdminInfo admin)
        {
            return adminDal.Create(admin);
        }
        public static int Update(AdminInfo admin)
        {
            return adminDal.Update(admin);
        }
        public static int Delete(int id)
        {
            return adminDal.Delete(id);
        }
        public static List<AdminInfo> GetAll()
        {
            return adminDal.GetAll();
        }
    }
}
