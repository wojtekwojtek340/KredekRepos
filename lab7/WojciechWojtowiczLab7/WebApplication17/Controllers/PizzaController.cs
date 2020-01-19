using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication17.Models;
using WebApplication17.Service;

namespace WebApplication17.Controllers
{
    [Route("api/pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        //serwis
        private IPizzaService pizzaService;

        /// <summary>
        /// konstruktor
        /// </summary>
        public PizzaController()
        {
            pizzaService = new PizzaService();
        }

        /// <summary>
        /// wyswiettlenie wszytkich pizz
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var pizzas = pizzaService.Get();
            return Ok(pizzas);
        }

        /// <summary>
        /// dodanie pizzy
        /// </summary>
        /// <param name="pizza"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Pizza pizza)
        {
            var id = pizzaService.Post(pizza);
            return Ok(id);


        }

        /// <summary>
        /// edycja pizzy
        /// </summary>
        /// <param name="pizza"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Pizza pizza, [FromRoute] int id)
        {
            if(id != pizza.Id)
            {
                return Conflict("Nie można edytować id!");
            }
            else
            {
                var isUpdateSuccessful = pizzaService.Put(pizza, id);

                if(isUpdateSuccessful)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }
        }

        /// <summary>
        /// usuniecie pizzy
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            bool isDeleteSuccesful = pizzaService.Delete(id);
            if(isDeleteSuccesful)
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}