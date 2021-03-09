using Parcial2_ap1_20180240.BLL;
using Parcial2_ap1_20180240.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_ap1_20180240.UI.Consultas
{
    public partial class cProyecto : Form
    {
        public List<ProyectoDetalle> Detalle { get; set; }
        public cProyecto()
        {
            InitializeComponent();
            this.Detalle = new List<ProyectoDetalle>();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Proyectos>();

            if (!string.IsNullOrEmpty(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = ProyectosBLL.GetList(r => r.ProyectoId == Converciones.ToInt(CriterioTextBox.Text));
                        break;

                    case 1:
                        lista = ProyectosBLL.GetList(e => e.Descripcion.Contains(CriterioTextBox.Text));
                        break;

                }
            }
            else
            {
                lista = ProyectosBLL.GetList(c => true);
            }

            DataGridView.DataSource = null;
            DataGridView.DataSource = lista;
        }
    }
}
