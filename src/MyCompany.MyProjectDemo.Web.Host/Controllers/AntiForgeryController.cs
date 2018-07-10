using Microsoft.AspNetCore.Antiforgery;
using MyCompany.MyProjectDemo.Controllers;

namespace MyCompany.MyProjectDemo.Web.Host.Controllers
{
    public class AntiForgeryController : MyProjectDemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
