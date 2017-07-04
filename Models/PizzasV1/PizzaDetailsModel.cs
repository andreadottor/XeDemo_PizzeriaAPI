namespace XeDemo.PizzeriaAPI.Models.PizzasV1
{
        
    /// <summary>
    /// Classe di dettaglio della Pizza. Contiene anche la lista degli ingredienti
    /// </summary>
    public class PizzaDetailsModel : PizzaModel
    {
        public PizzaDetailsModel()
        {
            
        }

        public PizzaDetailsModel(Pizza pizza)
        {
            this.Id = pizza.Id;
            this.Name = pizza.Name;
            this.Price = pizza.Price;
            this.Ingredients = pizza.Ingredients;
        }

        public PizzaDetailsModel(int id, PizzaInsertModel pizza)
        {
            this.Id = id;
            this.Name = pizza.Name;
            this.Price = pizza.Price;
            this.Ingredients = pizza.Ingredients;
        }

        /// <summary>
        /// Elenco degli ingredienti
        /// </summary>
        public string[] Ingredients { get; set; }

    }
}
