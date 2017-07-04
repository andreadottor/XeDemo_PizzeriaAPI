using System;
namespace XeDemo.PizzeriaAPI
{
    public class Pizza
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

        public int UserLastEdit { get; set; }

        public DateTime DateLastEdit { get; set; }

        public int UserCreate { get; set; }

        public DateTime DateCreate { get; set; }
    }
}