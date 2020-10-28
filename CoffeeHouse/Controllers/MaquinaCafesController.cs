using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeHouse.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeHouse.Controllers
{
    public class MaquinaCafesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(MaquinaCafe maquinaCafe)
        {
            string descricao = "";
            double valor = 0.0;
            ViewBag.Messagem = "";

            switch (maquinaCafe.TipoCafe)
            {
                case 1:
                    descricao = "Cappuccino";
                    valor = 3.5;
                    break;
                case 2:
                    descricao = "Mocha";
                    valor = 4;
                    break;
                case 3:
                    descricao = "Café com Leite";
                    valor = 3;
                    break;
                default:
                    ViewBag.Messagem = "Selecione um dos tipos de cafés disponíveis";
                    break;
            }

            var obj = new MaquinaCafe
            {
                UmCentavo = maquinaCafe.UmCentavo,
                CincoCentavo = maquinaCafe.CincoCentavo,
                DezCentavo = maquinaCafe.DezCentavo,
                VinteCincoCentavo = maquinaCafe.VinteCincoCentavo,
                CinquentaCentavo = maquinaCafe.CinquentaCentavo,
                UmReal = maquinaCafe.UmReal,
               TipoCafe = maquinaCafe.TipoCafe,
               Descricao = descricao
            };

            return View(obj);
        }
    }
}
