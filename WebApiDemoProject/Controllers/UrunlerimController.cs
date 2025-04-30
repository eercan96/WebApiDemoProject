using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemoProject.Model;

namespace WebApiDemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlerimController : ControllerBase
    {
        Context context=new Context();

        [HttpGet]
        public IActionResult GetList()
        {
            List<Urun> urunlerim = new List<Urun>();
            urunlerim=context.Urunler.ToList();
            return Ok(urunlerim);

        }
     


    }
}
