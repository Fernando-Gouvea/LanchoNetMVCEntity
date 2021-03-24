﻿using LanchoNetEntityFramework.Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LanchoNetEntityFramework.Controllers
{
    public class PizzaController : Controller
    {
        private PizzaContext db = new PizzaContext();

        // GET: Pizza
        public ActionResult Index()
        {
            return View(db.Pizzas.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                db.Pizzas.Add(pizza);
                db.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(pizza);

        } 

        public ActionResult Edit(int id)
        {
            return View(db.Pizzas.First(p => p.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                Pizza pizzaUpdate = db.Pizzas.First(p => p.Id == pizza.Id);
                pizzaUpdate.Descricao = pizza.Descricao;
                pizzaUpdate.Valor = pizza.Valor;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(pizza);

        }

        public ActionResult Details(int id)
        {
            return View(db.Pizzas.First(p => p.Id == id));
        }

        public ActionResult Delete(int id)
        {
            return View(db.Pizzas.First(p => p.Id == id));
        }



        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var pizza = db.Pizzas.First(p => p.Id == id);
            db.Pizzas.Remove(pizza);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}