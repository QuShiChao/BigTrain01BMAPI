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
    public class BookCategoryBll
    {
        static IDal<BookCategory> cateDal = null;
        static BookCategoryBll()
        {
            if (cateDal == null)
            {
                cateDal = FactoryHelper<BookCategory>.GetFactory().CreateDal("cate");
            }
        }
        public static int Create(BookCategory cate)
        {
            return cateDal.Create(cate);
        }
        public static int Update(BookCategory cate)
        {
            return cateDal.Update(cate);
        }
        public static int Delete(int id)
        {
            return cateDal.Delete(id);
        }
        public static List<BookCategory> GetAll()
        {
            return cateDal.GetAll();
        }
    }
}
