using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPastabar.Models
{
    public class Persoon
    {
        [Required(ErrorMessage = "Naam")]
        public string Naam { get; set; }
        [Required(ErrorMessage = "Voornaam")]
        public string Voornaam { get; set; }
        [Required(ErrorMessage = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefoon")]
        public string Telefoon { get; set; }
        [Required(ErrorMessage = "Geboortedatum")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Verleden(ErrorMessage = "Geboortedatum moet in het verleden liggen")]
        public DateTime Geboortedatum { get; set; }
    }
}