using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using DAL;
using System.Configuration;
using System.Reflection;

namespace Factory
{
    public class DapperFactory<T> : AbstractFactory<T>
    {
        public override IDal<T> CreateDal(string dalName)
        {
            string curPath= AppDomain.CurrentDomain.BaseDirectory;
            Assembly assembly = Assembly.LoadFrom(curPath+"bin/DAL.dll");
            string className = ConfigurationManager.AppSettings[dalName];
            IDal<T> dal = assembly.CreateInstance(className) as IDal<T>;
            return dal;
        }
    }
}
