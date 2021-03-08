using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_ap1_20180240.Entidades
{
    public class ProyectoDetalle
    {
        [Key]
        public int TipoId { get; set; }
        public string TipoTarea { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }
    }
}
