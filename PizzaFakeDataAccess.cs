using System;
using System.Collections.Generic;
using System.Linq;
using XeDemo.PizzeriaAPI;
using XeDemo.PizzeriaAPI.Models.PizzasV1;

public class PizzaFakeDataAccess : IPizzaDataAccess
{

    IList<Pizza> list;

    public PizzaFakeDataAccess()
    {

        list = new List<Pizza>();
        list.Add(new Pizza(){
            Id = 1,
            Name = "Margherita",
            Price = 4.00M,
            Ingredients = new string[] { "Mozzarella", "Pomodoro" }
        });
        list.Add(new Pizza(){
            Id = 2,
            Name = "Capricciosa",
            Price = 5.50M,
            Ingredients = new string[] { "Mozzarella", "Pomodoro", "Prosciutto", "Funghi", "Carciofi" }
        });
        list.Add(new Pizza(){
            Id = 3,
            Name = "Tonno e cipolla",
            Price = 4.00M,
            Ingredients = new string[] { "Mozzarella", "Pomodoro", "Tonno", "Cipolla" }
        });
        list.Add(new Pizza(){
            Id = 4,
            Name = "Diavola",
            Price = 4.00M,
            Ingredients = new string[] { "Mozzarella", "Pomodoro", "Salamino" }
        });
        list.Add(new Pizza(){
            Id = 5,
            Name = "Marinara",
            Price = 4.00M,
            Ingredients = new string[] { "Pomodoro", "Aglio" }
        });



    }


    /// <summary>
    /// Ritorna l'elenco delle pizze
    /// </summary>
    public IEnumerable<PizzaModel> GetAllPizzas()
    {
        return list.Select(p => new PizzaModel(p)).ToArray();
    }

    /// <summary>
    /// Ritorna una pizza dato il suo identificativo
    /// </summary>
    /// <param name="id">Identificativo della pizza</param>
    public PizzaDetailsModel GetPizza(int id)
    {
        var result = list.FirstOrDefault(p => p.Id == id);
        if(result != null)
            return new PizzaDetailsModel(result);
        
        return null;
    }
    
    /// <summary>
    /// Inserimento di una nuova pizza
    /// </summary>
    /// <param name="pizza">Pizza da inserire</param>
    /// <returns>Identificativo della pizza inserita</returns>
    public int InsertPizza(PizzaInsertModel pizza)
    {
        return DateTime.Now.Second;
    }

    /// <summary>
    /// Aggiornamento di una  pizza
    /// </summary>
    /// <param name="pizza">Pizza da modificare</param>
    public void UpdatePizza(PizzaEditModel pizza)
    {
        throw new NotImplementedException();
    }
}