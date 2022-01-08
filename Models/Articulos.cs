using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_WebApplication.Models
{
    public class Articulos
    {       
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Existencia { get; set; }

    }
}
