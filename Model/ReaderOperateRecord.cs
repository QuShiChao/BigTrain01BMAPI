using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //借还图书记录表
    public class ReaderOperateRecord
    {
        [Key]
        public int Id { get; set; }
        public int CardId { get; set; }
        public int Bid { get; set; }
        public int Num { get; set; }
        public DateTime BorrowTime { get; set; }//--借书时间
        public int Aid { get; set; }//--可借时间
        public DateTime ReturnTime { get; set; }//--还书时间
        public int Status { get; set; }
    }
}
