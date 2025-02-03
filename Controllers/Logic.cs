using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace check.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Logic : ControllerBase
    {
        // GET: Logic
       

        [HttpGet]

        public IActionResult FuncExercise(int num)

        {

            
            return Ok($"{num}* 5 = {num* 5}");

        }

    }
    

        
    
}
