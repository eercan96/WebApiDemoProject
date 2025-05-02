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

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            List<Urun> urunlerim = new List<Urun>();
            urunlerim=context.Urunler.ToList();
            return Ok(urunlerim);

        }
        [HttpPost("Add")]
        public IActionResult Add(Urun urun)
        {
            context.Urunler.Add(urun);
            context.SaveChanges();
            return Ok("İşlem Tamam");
        }

        [HttpGet("Delete")]
        public IActionResult Delete(int id) 
        {
            var result = context.Sepetim.Where(u => u.Id == id).FirstOrDefault();
            context.Remove(result);
            context.SaveChanges();
            var list=context.Sepetim.ToList();
            return Ok(list);
        }
     


    }
}
