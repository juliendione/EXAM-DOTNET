using System.ComponentModel.DataAnnotations;

namespace MyContacts.Models
{
    
    
        public class Category
        {
        
        public int CategoryId { get; set; }

            [Required(ErrorMessage = "Veuillez saisir un nom de catégorie")]
            public string Name { get; set; } = null!;
        }
    
}
