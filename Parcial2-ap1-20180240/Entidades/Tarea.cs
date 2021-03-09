using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_ap1_20180240.Entidades
{
    public class Tarea
    {
        [Key]
        public int TareaId { get; set; }
        public string TipoTarea { get; set; }
        [ForeignKey("TareaId")]
        public virtual Tarea Tareas { get; set; }


    }
}
