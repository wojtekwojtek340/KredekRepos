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
    [Route("api/cake")]
    [ApiController]
    public class CakeController : ControllerBase
    {
        //serwis
        private CakeService cakeService;

        /// <summary>
        /// konstruktor
        /// </summary>
        public CakeController()
        {
            cakeService = new CakeService();
        }

        /// <summary>
        /// metoda get wyswietlajaca wszystkie ciasta
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var cakes = cakeService.Get();
            return Ok(cakes);
        }

        /// <summary>
        /// metoda post dodajaca ciasto
        /// </summary>
        /// <param name="cake"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Cake cake)
        {
            var id = cakeService.Post(cake);
            return Ok(id);
        }

        /// <summary>
        /// metoda put edytujaca ciasto
        /// </summary>
        /// <param name="cake"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put([FromBody] Cake cake, [FromRoute] int id)
        {
            if (id != cake.Id)
            {
                return Conflict("Nie można edytować id!");
            }
            else
            {
                var isUpdateSuccessful = cakeService.Put(cake, id);

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
        /// metoda delete usuwajaca ciasto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            bool isDeleteSuccesful = cakeService.Delete(id);
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