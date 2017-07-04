using System;
using System.Collections.Generic;
using XeDemo.PizzeriaAPI;
using XeDemo.PizzeriaAPI.Models.PizzasV1;
public interface IPizzaDataAccess
{
    /// <summary>
    /// Ritorna l'elenco delle pizze
    /// </summary>
    IEnumerable<PizzaModel> GetAllPizzas();    

    /// <summary>
    /// Ritorna una pizza dato il suo identificativo
    /// </summary>
    /// <param name="id">Identificativo della pizza</param>
    PizzaDetailsModel GetPizza(int id);

    /// <summary>
    /// Inserimento di una nuova pizza
    /// </summary>
    /// <param name="pizza">Pizza da inserire</param>
    /// <returns>Identificativo della pizza inserita</returns>
    int InsertPizza(PizzaInsertModel pizza);

    /// <summary>
    /// Aggiornamento di una  pizza
    /// </summary>
    /// <param name="pizza">Pizza da modificare</param>
    void UpdatePizza(PizzaEditModel pizza);
}