using Microsoft.AspNetCore.Mvc;

namespace Web404.Controllers
{
    public class ErrorController : Controller
    {
        [Route("error/404", Order = 9)]
        public IActionResult Error404()
        {
            ViewBag.code = 404;
            return View();
        }

        [Route("error/{code:int}", Order = 1)]
        public IActionResult Error(int code)
        {
            ViewBag.code = code;
            switch (code)
            {
                case 404:
                    ViewBag.msg = "对不起，请求的资源不存在。";
                    break;
                case 401:
                    ViewBag.msg = "对不起，您无权限访问此页面。";
                    break;
                default:
                    ViewBag.msg = "服务异常，请稍后重试！";
                    break;
            }

            return View("Error404");
        }
    }
}
