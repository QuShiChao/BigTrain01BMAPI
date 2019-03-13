using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManageService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
//List<AdminInfo> adminList = AdminBll.GetAll();
//List<BookCategory> bookCategoryList = BookCategoryBll.GetAll();
//List<BookInfo> bookInfoList = BookInfoBll.GetAll();
//List<BookLocation> bookLocationList = BookLocationBll.GetAll();
//List<BorrowTimeArea> borrowTimeAreaList = BorrowTimeAreaBll.GetAll();
//List<CircleInfo> circleInfoList = CircleInfoBll.GetAll();
//List<ReaderInfo> readerInfoList = ReaderInfoBll.GetAll();
//List<ReaderOperateRecord> readerOperateRecordList = ReaderOperateRecordBll.GetAll();