using Microsoft.AspNetCore.Mvc;

namespace Coroian_Emanuel_Lab1M.Controllers
{
    public class FirstController : Controller
    {
        public string Index()
        {
            return "Bun venit în prima mea aplicatie ASP.NET Core MVC!";
        }
        public string Hello()
        {
            return "Salut, utilizatorule! Ma bucur ca ai ajuns aici.";
        }

        public string Mesaj(string nume, int varsta)
        {
            return $"Salut {nume}, ai {varsta} ani.";
        }
    }
}
