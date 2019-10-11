using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Data.Entities
{
    public class Manager
    {
        public int Id { get; set; }
        public User User { get; set; } // trae los campos de la tabla user ya que son los mismos y asi se evita la duplicidad de codigo

    }
}
