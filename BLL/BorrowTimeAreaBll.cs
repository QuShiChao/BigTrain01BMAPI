using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Factory;
using Model;

namespace BLL
{
    public class BorrowTimeAreaBll
    {
        static IDal<BorrowTimeArea> timeDal = null;
        static BorrowTimeAreaBll()
        {
            if (timeDal == null)
            {
                timeDal = FactoryHelper<BorrowTimeArea>.GetFactory().CreateDal("time");
            }
        }
        public static int Create(BorrowTimeArea time)
        {
            return timeDal.Create(time);
        }
        public static int Update(BorrowTimeArea time)
        {
            return timeDal.Update(time);
        }
        public static int Delete(int id)
        {
            return timeDal.Delete(id);
        }
        public static List<BorrowTimeArea> GetAll()
        {
            return timeDal.GetAll();
        }
    }
}
