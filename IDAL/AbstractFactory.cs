using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public abstract class AbstractFactory<T>
    {
        public abstract IDal<T> CreateDal(string dalName);
    }
}
