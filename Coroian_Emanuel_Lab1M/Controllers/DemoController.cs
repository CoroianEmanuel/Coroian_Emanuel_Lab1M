using Microsoft.AspNetCore.Mvc;

namespace Coroian_Emanuel_Lab1M.Controllers
{
    public class DemoController : Controller
    {
        [Route("hello")]
        public string Hello() => "Salut!";

        [HttpGet("hello/{name}")]
        public string HelloByName(string name) => $"Salut, {name}!";

        [HttpGet("calc/{a:int}/{b:int}")]
        public string Calculate(int a, int b) => $"Suma este: {a + b}";
    }
}
