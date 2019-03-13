using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //图书类别表
    public class BookCategory
    {
        [Key]
        public int Cid { get; set; }//类别ID
        public string Cname { get; set; }//类别名称
    }
}
