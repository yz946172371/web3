using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// 欢迎页面 
        /// </summary>
        /// <returns></returns>
        public ActionResult Welcome()
        {
            var a = 100;
            var sum = 0;
            for (var i = 1; i <= a; i++)
            {
                sum += i;
            }

            ViewBag.sum = sum;
            return View();
        }


        /// <summary>
        /// 新闻列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List(int page=10)
        {
            string[] data= new string[] { "NBA-詹皇里程碑之夜骑士胜奇才
超科比！",
                "科比自曝仍坚持凌晨4点起床" ,
                "追梦:没有球队能给我们带来挑战",
                "试传祺旗舰GS8：想当最强自主SUV"};

            ViewBag.data = data;
            ViewBag.Page = page;

            //ViewData["data"] = data;
            //ViewData.Model = data;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }

        /// <summary>
        /// 保存新闻内容
        /// </summary>
        /// <returns></returns>
        public ActionResult Save(string title, string content)
        {
            ViewBag.Title = title;
            ViewBag.Content = content;
            return View();
        }
    }
}