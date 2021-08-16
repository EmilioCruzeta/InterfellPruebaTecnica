using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InterfellPruebaTecnica.Modelos
{
    public class Clientes
    {
   
        [Key]
        public int id { get; set; }

        public string cliente_nombre { get; set; }
        public string cliente_apellido { get; set; }
        public string cliente_descripcion { get; set; }
        public DateTime cliente_fecha { get; set; }

    }
}
