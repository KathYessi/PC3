using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PC3simulacro.Data;
using PC3simulacro.Models;

namespace PC3simulacro.Controllers
{
    public class ProductoController
    {
        public class HomeController :Controller
        {
            private readonly WebAppContext _context;

            private int year;

            private int month;

            public HomeController ( WebAppContext context)
            {
                _context= context;
            }
            
       }
    }
}