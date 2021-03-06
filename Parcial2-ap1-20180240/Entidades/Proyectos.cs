using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_ap1_20180240.Entidades
{
    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int TiempoTotal { get; set; }
        [ForeignKey("ProyectoId")]
        public List<ProyectoDetalle> Detalle { get; set; }

        public Proyectos()
        {
            ProyectoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            TiempoTotal = 0;

            Detalle = new List<ProyectoDetalle>();
        }

    }
}
