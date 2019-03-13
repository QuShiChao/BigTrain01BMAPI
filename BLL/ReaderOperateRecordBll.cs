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
    public class ReaderOperateRecordBll
    {
            static IDal<ReaderOperateRecord> recordDal = null;
            static ReaderOperateRecordBll()
            {
                if (recordDal == null)
                {
                recordDal = FactoryHelper<ReaderOperateRecord>.GetFactory().CreateDal("record");
                }
            }
            public static int Create(ReaderOperateRecord record)
            {
                return recordDal.Create(record);
            }
            public static int Update(ReaderOperateRecord record)
            {
                return recordDal.Update(record);
            }
            public static int Delete(int id)
            {
                return recordDal.Delete(id);
            }
            public static List<ReaderOperateRecord> GetAll()
            {
                return recordDal.GetAll();
            }
       
    }
}
