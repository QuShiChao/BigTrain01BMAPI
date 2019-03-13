using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using IDAL;
using DAL;
using System.Reflection;

namespace Factory
{
    public class FactoryHelper<T>
    {
        public static AbstractFactory<T> GetFactory()
        {
            string className = ConfigurationManager.AppSettings["fac"];
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType(className);
            Type result = type.MakeGenericType(typeof(T));
            AbstractFactory<T> factory= assembly.CreateInstance(result.FullName) as AbstractFactory<T>;
            return factory;
        }
    }
}
