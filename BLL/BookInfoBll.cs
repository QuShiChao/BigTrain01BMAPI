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
    public class BookInfoBll
    {
        static IDal<BookInfo> bookDal = null;
        static BookInfoBll()
        {
            if (bookDal == null)
            {
                bookDal = FactoryHelper<BookInfo>.GetFactory().CreateDal("book");
            }
        }
        public static int Create(BookInfo book)
        {
            return bookDal.Create(book);
        }
        public static int Update(BookInfo book)
        {
            return bookDal.Update(book);
        }
        public static int Delete(int id)
        {
            return bookDal.Delete(id);
        }
        public static List<BookInfo> GetAll()
        {
            return bookDal.GetAll();
        }
    }
}
