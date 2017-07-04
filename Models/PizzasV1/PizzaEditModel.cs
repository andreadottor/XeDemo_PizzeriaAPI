namespace XeDemo.PizzeriaAPI.Models.PizzasV1
{
    /// <summary>
    /// Classe utilizzata per la modifica di una pizza
    /// </summary>
    public class PizzaEditModel
    {

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

        /// <summary>
        /// Elenco degli ingredienti
        /// </summary>
        public string[] Ingredients { get; set; }

    }
}