using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        // Propriedade de navegação
        public MembershipType MembershipType { get; set; }

        // chave estrangeira
        [Display(Name = "Tipo de Associação")]
        public byte MembershipTypeId { get; set; }
    }
}
