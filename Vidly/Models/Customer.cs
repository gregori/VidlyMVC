using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        // Propriedade de navegação
        public MembershipType MembershipType { get; set; }

        // chave estrangeira
        public byte MembershipTypeId { get; set; }
    }
}