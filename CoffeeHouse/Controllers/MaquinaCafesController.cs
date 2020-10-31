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
            double valorCafe = 0.0;
            ViewBag.Messagem = "";

            switch (maquinaCafe.TipoCafe)
            {
                case 1:
                    descricao = "Cappuccino";
                    valorCafe = 3.5;
                    break;
                case 2:
                    descricao = "Mocha";
                    valorCafe = 4;
                    break;
                case 3:
                    descricao = "Café com Leite";
                    valorCafe = 3;
                    break;
                default:
                    ViewBag.Messagem = "Selecione um dos tipos de cafés disponíveis";
                    break;
            }

            double umCentavo = maquinaCafe.UmCentavo * 0.01;
            double cincoCentavo = maquinaCafe.CincoCentavo * 0.05;
            double dezCentavo = maquinaCafe.DezCentavo * 0.10;
            double vinteCincoCentavo = maquinaCafe.VinteCincoCentavo * 0.25;
            double cinquentaCentavo = maquinaCafe.CinquentaCentavo * 0.5;
            double umReal = maquinaCafe.UmReal * 1.0;

            if (maquinaCafe.UmCentavo == 1 || maquinaCafe.CincoCentavo == 1)
            {
                return RedirectToAction(nameof(DefeitoLeitora));
            }

            double valorAceito = dezCentavo + vinteCincoCentavo + cinquentaCentavo
                + umReal;
            double troco = 0.0;

            if (valorAceito >= valorCafe)
            {
                troco = valorAceito - valorCafe;

            }
            else {
                descricao = "O valor de pagamento não pode comprar o café";
                troco = valorAceito;
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
                ValorCafe = valorCafe,
                Descricao = descricao,
                Troco = troco,
                ValorAceito = valorAceito
            };



            return View(obj);
        }

        public IActionResult DefeitoLeitora()
        {
            ViewBag.Erro = "Erro na leitora de moeda: A máquina não está aceitando as" +
                " moedas R$ 0.01 e R$ 0.05";
            return View();
        }
    }
}
