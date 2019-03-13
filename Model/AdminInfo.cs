using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //管理员表
    public class AdminInfo
    {
        [Key]
        public int Aid { get; set; }
        public string Aname { get; set; }
    }
}
