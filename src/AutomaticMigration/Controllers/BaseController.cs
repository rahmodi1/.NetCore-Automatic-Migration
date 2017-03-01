using AutomaticMigration.Data;
using Microsoft.AspNetCore.Mvc;

namespace AutomaticMigration.Controllers
{
    public class BaseController : Controller
    {
        private readonly SchoolContext _context;
        public BaseController(SchoolContext context)
        {
            _context = context;
        }

    }
}