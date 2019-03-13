using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class CircleInfo
    {
        [Key]
        public int Id { get; set; }
        public int Rid { get; set; }//读者ID
        public string Comment { get; set; }//评论
        public DateTime PublishTime { get; set; }//发表时间
        public int Status { get; set; }//--0未审核，1审核通过，2审核失败

    }
}
