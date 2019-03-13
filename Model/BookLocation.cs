using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //图书存放位置表
    public class BookLocation
    {
        [Key]
        public int Lid { get; set; }//位置表ID
        public string Lname { get; set; }//位置名称
        public int Pid { get; set; }//父级ID
    }
}
