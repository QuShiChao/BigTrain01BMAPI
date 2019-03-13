using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReaderInfo
    {
        //用户表
        [Key]
        public int Rid { get; set; }
        public string Rname { get; set; }
        public string Tel { get; set; }//手机号
        public int CardId { get; set; }//--借书卡Id
        public string WeChat { get; set; }//微信号
        public int Role { get; set; }//--0读者,1会员
        public double Balance { get; set; }//--余额
        public int Integral { get; set; }//--积分
    }
}
