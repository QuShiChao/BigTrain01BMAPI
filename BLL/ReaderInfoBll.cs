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
    public class ReaderInfoBll
    {
        static IDal<ReaderInfo> readerDal = null;
        static ReaderInfoBll()
        {
            if (readerDal == null)
            {
                readerDal = FactoryHelper<ReaderInfo>.GetFactory().CreateDal("reader");
            }
        }
        public static int Create(ReaderInfo location)
        {
            return readerDal.Create(location);
        }
        public static int Update(ReaderInfo location)
        {
            return readerDal.Update(location);
        }
        public static int Delete(int id)
        {
            return readerDal.Delete(id);
        }
        public static List<ReaderInfo> GetAll()
        {
            return readerDal.GetAll();
        }
    }
}
