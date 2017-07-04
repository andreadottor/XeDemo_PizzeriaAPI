using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XeDemo.PizzeriaAPI.Models.PizzasV1;

namespace XeDemo.PizzeriaAPI.Controllers
{
    [Route("api/v1/pizzas")]
    public class PizzasV1Controller : Controller
    {
        IPizzaDataAccess _data;
        public PizzasV1Controller(IPizzaDataAccess data)
        {
            this._data = data;
        }

        // GET api/pizzas
        /// <summary>
        /// Metodo che permette di recuperare l'elenco delle pizze
        /// </summary>
        /// <returns>Elenco delle pizze</returns>
        [HttpGet]
        public IEnumerable<PizzaModel> Get()
        {
            return this._data.GetAllPizzas();
        }

        // GET api/pizzas/5
        /// <summary>
        /// Metodo che permette di recuperare le informazioni di una precisa pizza
        /// </summary>
        /// <param name="id">Identificativo della pizza</param>
        /// <returns>Info della pizza</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = this._data.GetPizza(id);
            if(result == null)
                return NotFound();
            
            return Ok(result);
        }

        // POST api/pizzas
        /// <summary>
        /// Inserimento di una nuova pizza
        /// </summary>
        /// <param name="pizza">Nuova pizza</param>
        [HttpPost]
        public IActionResult Post([FromBody]PizzaInsertModel pizza)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            // continuo con l'inserimento della pizza
            var newId = this._data.InsertPizza(pizza);

            return CreatedAtAction("Get", new { id = newId }, new PizzaDetailsModel(newId, pizza));
        }

        // PUT api/pizzas/5
        /// <summary>
        /// Modifica di una pizza
        /// </summary>
        /// <param name="id">Identificativo della pizza da aggiornare</param>
        /// <param name="pizza">Pizza con i dati aggiornati</param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]PizzaEditModel pizza)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // salvo l'oggetto
            pizza.Id = id;
            this._data.UpdatePizza(pizza);

            return NoContent();
        }

        // DELETE api/pizzas/5
        /// <summary>
        /// Cancellazione di una pizza
        /// </summary>
        /// <param name="id">Identificativo della pizza da cancellare</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
