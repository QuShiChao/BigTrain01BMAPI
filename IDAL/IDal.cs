using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IDal<T>
    {
        int Create(T t);
        List<T> GetAll();
        int Delete(int id);
        int Update(T t);
    }
}
