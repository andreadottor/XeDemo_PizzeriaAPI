namespace XeDemo.PizzeriaAPI.Models.PizzasV1
{
    /// <summary>
    /// Classe utilizzata per ritornare le info in caso di un elenco
    /// </summary>
    public class PizzaModel
    {

        public PizzaModel()
        {
            
        }

        public PizzaModel(Pizza pizza)
        {
            this.Id = pizza.Id;
            this.Name = pizza.Name;
            this.Price = pizza.Price;
        }

        /// <summary>
        /// Identificativo
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Prezzo
        /// </summary>
        public decimal Price { get; set; }

    }
}