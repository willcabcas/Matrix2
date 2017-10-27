using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Matrix.MVC.Models;
using Matrix.BLL;

namespace Matrix.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public int ResetValDataBase(int casoPrueba)
        {
            return new HomeBLL().resetDB(casoPrueba);
        }

        public int crearCubo3D(int tamanoCubo3D, int numeroOperaciones)
        {
            return new HomeBLL().crearCubo3D(tamanoCubo3D, numeroOperaciones);
        }

        public int updateCubo3D(int x, int y, int z,int val)
        {
            return new HomeBLL().updateCubo3D(x,y,z,val);
        }

        public int queryCubo3D(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            return new HomeBLL().queryCubo3D(x1, y1, z1, x2, y2, z2);
        }
    }
}
