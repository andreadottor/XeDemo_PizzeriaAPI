using System.ComponentModel.DataAnnotations;

namespace XeDemo.PizzeriaAPI.Models.PizzasV1
    {
    /// <summary>
    /// Classe utilizzata per l'inserimento di una nuova pizza
    /// </summary>
    public class PizzaInsertModel
    {

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        /// <summary>
        /// Prezzo
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Elenco degli ingredienti
        /// </summary>
        public string[] Ingredients { get; set; }

    }
}