using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication17.Models;

namespace WebApplication17.Service
{

    public class PizzaService : IPizzaService
    {

        //lista pizz
        public static List<Pizza> pizzas = new List<Pizza>();

        /// <summary>
        /// dodawanie pizzy
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        public int Post(Pizza pizza)
        {
            int id;
            if (pizzas.Count() == 0)
            {
                id = 0;
                pizza.Id = id;

            }
            else
            {
                id = pizzas.Max(x => x.Id);
                pizza.Id = ++id;
            }

            pizzas.Add(pizza);
            return id;
        }

        /// <summary>
        /// zwracanie listy pizz
        /// </summary>
        /// <returns></returns>
        public List<Pizza> Get()
        {
            return pizzas;
        }

        /// <summary>
        /// edycja pizz
        /// </summary>
        /// <param name="pizza"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Put(Pizza pizza, int Id)
        {
            var pizzaToUpdate = pizzas.Where(x => x.Id.Equals(Id)).Single();
            pizzaToUpdate.Name = pizza.Name;
            pizzaToUpdate.Cost = pizza.Cost;
            pizzaToUpdate.Description = pizza.Description;
            return true;
        }

        /// <summary>
        /// usuniecie pizzy
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            var pizza = pizzas.Where(x => x.Id.Equals(Id)).SingleOrDefault();            
            if (pizza == null)
            {
                return false;

            }
            else
            {
                pizzas.Remove(pizza);
                return true;
            }
        }
    }
}
