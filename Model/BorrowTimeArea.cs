using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //借书时间区域表
    public class BorrowTimeArea
    {
        [Key]
        public int Aid { get; set; }
        public string Aname { get; set; }
    }
}
