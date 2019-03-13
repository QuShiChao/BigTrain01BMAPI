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
    public class BookLocationBll
    {
        static IDal<BookLocation> locationDal = null;
        static BookLocationBll()
        {
            if (locationDal == null)
            {
                locationDal = FactoryHelper<BookLocation>.GetFactory().CreateDal("location");
            }
        }
        public static int Create(BookLocation location)
        {
            return locationDal.Create(location);
        }
        public static int Update(BookLocation location)
        {
            return locationDal.Update(location);
        }
        public static int Delete(int id)
        {
            return locationDal.Delete(id);
        }
        public static List<BookLocation> GetAll()
        {
            return locationDal.GetAll();
        }
    }
}
