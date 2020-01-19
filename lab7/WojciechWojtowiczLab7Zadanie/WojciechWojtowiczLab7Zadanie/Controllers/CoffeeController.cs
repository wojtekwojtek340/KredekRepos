using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WojciechWojtowiczLab7Zadanie.Models;
using WojciechWojtowiczLab7Zadanie.Service;

namespace WojciechWojtowiczLab7Zadanie.Controllers
{
    [Route("api/coffee")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        //serwis
        private CoffeeService coffeeService;

        /// <summary>
        /// konstruktor
        /// </summary>
        public CoffeeController()
        {
            coffeeService = new CoffeeService();
        }

        /// <summary>
        /// metoda get wyswietlajaca wszystkie kawy
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var coffes = coffeeService.Get();
            return Ok(coffes);
        }

        /// <summary>
        /// metoda post dodajaca kawe
        /// </summary>
        /// <param name="coffe"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Coffee coffe)
        {
            var id = coffeeService.Post(coffe);
            return Ok(id);
        }

        /// <summary>
        /// metoda put edytujaca kawe
        /// </summary>
        /// <param name="coffe"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Coffee coffe, [FromRoute] int id)
        {
            if (id != coffe.Id)
            {
                return Conflict("Nie można edytować id!");
            }
            else
            {
                var isUpdateSuccessful = coffeeService.Put(coffe, id);

                if (isUpdateSuccessful)
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
        /// metoda delete usuwająca kawe
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            bool isDeleteSuccesful = coffeeService.Delete(id);
            if (isDeleteSuccesful)
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