using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Controllers
{
    public class ErrorController : Controller
    {
        public string Handler(int code)
        {
            return "A következő hiba van: " + code;
        }
    }
}
