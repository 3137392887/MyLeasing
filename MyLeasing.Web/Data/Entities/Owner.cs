using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        public User User { get; set; } // trae los campos de la tabla user ya que son los mismos y asi se evita la duplicidad de codigo

        public ICollection<Property> Properties { get; set; } // relacion entre clases
        public ICollection<Contract> Contracts { get; set; }
    }
}
