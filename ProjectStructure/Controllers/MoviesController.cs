using Microsoft.AspNetCore.Mvc;

namespace ProjectStructure.Controllers
{
    public class MoviesController : Controller
    {
        //Action =>public non static 
        public IActionResult GetMovie(int id)//لازم يكون زي اللي ف الراوتprameterاسم ال 
        {
            if (id == 0)
                return BadRequest();//helper method دي كدا اللي جوا ال  
            if (id == 10)
                return NotFound();
            if (id == 11)
                return Content($"Movie Id Is {id}","text/html");
            return BadRequest();
        }
        public string Index()
        {
            return " hello from index";
        }
    }
}
