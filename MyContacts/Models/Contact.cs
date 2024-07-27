using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MyContacts.Models
{
    public class Contact
    {

        
        // PK pour la table Contact
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Veuillez saisir un prénom")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Veuillez saisir un nom de famille")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Veuillez entrer un numéro de téléphone")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Veuillez saisir une adresse e-mail")]
        public string Email { get; set; } = null!;

        // FK pour la table des catégories
        [Required(ErrorMessage = "Veuillez sélectionner une catégorie")]
        public int? CategoryId { get; set; }

        // Propriété de navigation
        [ValidateNever]
        public Category Category { get; set; } = null!;

        public DateTime DateAdded { get; set; }
    }
}
