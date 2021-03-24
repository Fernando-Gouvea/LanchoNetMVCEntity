using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LanchoNetEntityFramework.Dal
{
    public class PizzaInitializer : DropCreateDatabaseIfModelChanges<PizzaContext>
    {

        protected override void Seed(PizzaContext context)
        {
            var pizzas = new List<Pizza>
            {
                new Pizza{Id = 1, Descricao = "Pizza de calabreza", Valor = 50}
            };

            pizzas.ForEach(p => context.Pizzas.Add(p));
            context.SaveChanges();

        }

    }
}