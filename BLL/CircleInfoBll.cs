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
    public class CircleInfoBll
    {
        static IDal<CircleInfo> circleDal = null;
        static CircleInfoBll()
        {
            if (circleDal == null)
            {
                circleDal = FactoryHelper<CircleInfo>.GetFactory().CreateDal("circle");
            }
        }
        public static int Create(CircleInfo circle)
        {
            return circleDal.Create(circle);
        }
        public static int Update(CircleInfo circle)
        {
            return circleDal.Update(circle);
        }
        public static int Delete(int id)
        {
            return circleDal.Delete(id);
        }
        public static List<CircleInfo> GetAll()
        {
            return circleDal.GetAll();
        }
    }
}
