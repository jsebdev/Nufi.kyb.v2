using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Nufi.kyb.v2.Services;
using Nufi.kyb.v2.Models;

namespace Nufi.kyb.v2.Models
{
    public class AntecedetesPage : Page
    {
        public AntecedetesPage(SuperSeccion[] superSecciones) : base(superSecciones)
        {
            SuperSecciones = superSecciones;
        }
    }
}