using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIClientes.Models
{
    public class ClienteDto
    {
        
        public int Id { get; set; }
       
        public string Nombre { get; set; }
        
        public string Apellido { get; set; }
       
        public string Direccion { get; set; }
       
        public string Telefono { get; set; }
    }
}
