using Microsoft.AspNetCore.Mvc;
using WebApiDemoProject.Model;

namespace WebApiDemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SepetimController : ControllerBase
    {
        Context context =new Context();

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            var result=context.Sepetim.ToList();
            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Add(Sepet sepet) 
        { 
            
            context.Sepetim.Add(sepet);
            context.SaveChanges();
            return Ok("Sepete ürün eklendi");

        }

        [HttpGet("[action]/{id}")]
        public IActionResult Delete(int id)
        {
            var result =context.Sepetim.FirstOrDefault(x => x.Id == id);
            context.Sepetim.Remove(result);
            context.SaveChanges();
            return Ok("Ürün silindi");
        }
    }
}
