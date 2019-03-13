using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //图书表
    public class BookInfo
    {
        [Key]
        public int Bid { get; set; }
        public string Bname { get; set; }//书名
        public double Bprice { get; set; }//价格
        public int Cid { get; set; }//类别ID
        public int Lid_1 { get; set; }//柜
        public int Lid_2 { get; set; }//左右排数
        public int Lid_3 { get; set; }//列数
        public string BookDescription { get; set; }//书籍描述
        public int Inventory { get; set; }//库存
        public int Status { get; set; }//上下架
    }
}
