using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class DapperHelper<T> : IDal<T> where T : new()
    {
        private readonly IDbConnection conn = new SqlConnection("Data Source=.;Initial Catalog=LibraryManageDB;Integrated Security=True");
    public int Create(T t)
    {
        using (conn)
        {
            Type type = typeof(T);
            PropertyInfo[] pros = type.GetProperties();
            //实例化字符串进行拼接
            StringBuilder sb = new StringBuilder();
            sb.Append("insert into " + type.Name + " values(@");
            string sql = "";
            foreach (var item in pros)
            {
                //判断是否为主键
                if (item.GetCustomAttribute(typeof(KeyAttribute), true) == null)
                {
                    //string.IsNullOrEmpty(item.GetValue(t).ToString())
                    if (item.GetValue(t) == null)
                    {
                        sb.Append(",");
                    }
                    else
                    {
                        sb.Append(item.GetValue(t) + ",@");
                    }
                }
            }
            sql = sb.ToString().Substring(0, sb.Length - 2) + ")";
            return conn.Execute(sql, t);
        }
    }
    public List<T> GetAll()
    {
        using (conn)
        {
            Type type = typeof(T);
            string sql = "select * from " + type.Name + "";
            return conn.Query<T>(sql).ToList();
        }
    }
    public int Delete(int id)
    {
        using (conn)
        {
            Type type = typeof(T);
            PropertyInfo[] pros = type.GetProperties();
            string sql = "delete from " + type.Name + " where ";
            foreach (var item in pros)
            {
                if (item.GetCustomAttribute(typeof(KeyAttribute), true) != null)
                {
                    sql += item.Name + " = @Id";
                }
            }
            return conn.Execute(sql, new { Id = id });
        }
    }
    public int Update(T t)
    {
        using (conn)
        {
            Type type = typeof(T);
            var prop = type.GetProperties();
            StringBuilder sb = new StringBuilder();
            sb.Append("update " + type.Name + " set ");
            StringBuilder sb2 = new StringBuilder();
            sb2.Append(" where ");
            string str = "";
            foreach (var item in prop)
            {
                if (item.GetCustomAttribute(typeof(KeyAttribute), true) != null)
                {
                    sb2.Append(item.Name + "=@'" + item.GetValue(t));
                }
                else
                {
                    if (item.GetValue(t) != null)
                    {
                        sb.Append(item.Name + "=@'" + item.GetValue(t) + ",");
                    }

                }
            }
            str = sb.ToString().Substring(0, sb.Length - 1) + sb2.ToString();
            return conn.Execute(str, t);
        }

    }
}
}
