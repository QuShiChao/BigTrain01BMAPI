using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;

namespace LibraryManageService.Controllers
{
    public class LibraryManageController : ApiController
    {
        [HttpPost]//管理员添加
        public int AddAdmin(AdminInfo adminInfo)
        {
            return AdminBll.Create(adminInfo);
        }
        [HttpGet]//管理员显示
        public List<AdminInfo> GetAdmin()
        {
            return AdminBll.GetAll();
        }
        [HttpDelete]//管理员删除
        public int DelAdmin(int id)
        {
            return AdminBll.Delete(id);
        }
        [HttpPut]//管理员修改
        public int UpdAdmin(AdminInfo adminInfo)
        {
            return AdminBll.Update(adminInfo);
        }

        /// <summary>
        /// 图书类别
        /// </summary>
        /// <param name="bookCategory"></param>
        /// <returns></returns>
        [HttpPost]//图书类别添加
        public int AddCategory(BookCategory bookCategory)
        {
            return BookCategoryBll.Create(bookCategory);
        }
        [HttpGet]//图书类别查看
        public List<BookCategory> GetCategory()
        {
            return BookCategoryBll.GetAll();
        }
        [HttpDelete]//图书类别删除
        public int DelCategory(int id)
        {
            return BookCategoryBll.Delete(id);
        }
        [HttpPut]//图书类别修改
        public int UpdCategory(BookCategory bookCategory)
        {
            return BookCategoryBll.Update(bookCategory);
        }

        /// <summary>
        /// 图书
        /// </summary>
        /// <param name="bookInfo"></param>
        /// <returns></returns>
        [HttpPost]//图书添加
        public int AddInfo(BookInfo bookInfo)
        {
            return BookInfoBll.Create(bookInfo);
        }
        [HttpGet]//图书查看
        public List<BookInfo> GetInfo()
        {
            return BookInfoBll.GetAll();
        }
        [HttpDelete]//图书删除
        public int DelInfo(int id)
        {
            return BookInfoBll.Delete(id);
        }
        [HttpPut]//图书修改
        public int UpdInfo(BookInfo bookInfo)
        {
            return BookInfoBll.Update(bookInfo);
        }

        /// <summary>
        /// 图书存放表
        /// </summary>
        /// <param name="bookLocation"></param>
        /// <returns></returns>
        [HttpPost]//图书存放位置添加
        public int AddLocation(BookLocation bookLocation)
        {
            return BookLocationBll.Create(bookLocation);
        }
        [HttpGet]//图书存放位置查看
        public List<BookLocation> GetLocation()
        {
            return BookLocationBll.GetAll();
        }
        [HttpDelete]//图书存放位置删除
        public int DelLocation(int id)
        {
            return BookLocationBll.Delete(id);
        }
        [HttpPut]//图书存放位置修改
        public int UpdLocation(BookLocation bookLocation)
        {
            return BookLocationBll.Update(bookLocation);
        }
        /// <summary>
        /// 借书时间区域表
        /// </summary>
        /// <param name="bookInfo"></param>
        /// <returns></returns>
        [HttpPost]//借书时间添加
        public int AddTime(BorrowTimeArea borrowTimeArea)
        {
            return BorrowTimeAreaBll.Create(borrowTimeArea);
        }
        [HttpGet]//借书时间查看
        public List<BorrowTimeArea> GetTime()
        {
            return BorrowTimeAreaBll.GetAll();
        }
        [HttpDelete]//借书时间删除
        public int DelTime(int id)
        {
            return BorrowTimeAreaBll.Delete(id);
        }
        [HttpPut]//借书时间修改
        public int UpdTime(BorrowTimeArea borrowTimeArea)
        {
            return BorrowTimeAreaBll.Update(borrowTimeArea);
        }
        /// <summary>
        /// 圈子表
        /// </summary>
        /// <param name="bookInfo"></param>
        /// <returns></returns>
        [HttpPost]//圈子添加
        public int AddCircle(CircleInfo circleInfo)
        {
            return CircleInfoBll.Create(circleInfo);
        }
        [HttpGet]//圈子查看
        public List<CircleInfo> GetCircle()
        {
            return CircleInfoBll.GetAll();
        }
        [HttpDelete]//圈子删除
        public int DelCircle(int id)
        {
            return CircleInfoBll.Delete(id);
        }
        [HttpPut]//圈子修改
        public int UpdCircle(CircleInfo circleInfo)
        {
            return CircleInfoBll.Update(circleInfo);
        }
        /// <summary>
        /// 用户表
        /// </summary>
        /// <param name="circleInfo"></param>
        /// <returns></returns>
        [HttpPost]//用户添加
        public int AddReader(ReaderInfo readerInfo)
        {
            return ReaderInfoBll.Create(readerInfo);
        }
        [HttpGet]//用户查看
        public List<ReaderInfo> GetReader()
        {
            return ReaderInfoBll.GetAll();
        }
        [HttpDelete]//用户删除
        public int DelReader(int id)
        {
            return ReaderInfoBll.Delete(id);
        }
        [HttpPut]//用户修改
        public int UpdReader(ReaderInfo readerInfo)
        {
            return ReaderInfoBll.Update(readerInfo);
        }
        /// <summary>
        /// 借还图书记录表
        /// </summary>
        /// <param name="readerInfo"></param>
        /// <returns></returns>

        [HttpPost]//记录添加
        public int AddOperateRecord(ReaderOperateRecord readerOperateRecord)
        {
            return ReaderOperateRecordBll.Create(readerOperateRecord);
        }
        [HttpGet]//记录查看
        public List<ReaderOperateRecord> GetOperateRecord()
        {
            return ReaderOperateRecordBll.GetAll();
        }
        [HttpDelete]//记录删除
        public int DelOperateRecord(int id)
        {
            return ReaderOperateRecordBll.Delete(id);
        }
        [HttpPut]//记录修改
        public int UpdOperateRecord(ReaderOperateRecord readerOperateRecord)
        {
            return ReaderOperateRecordBll.Update(readerOperateRecord);
        }
    }
}
