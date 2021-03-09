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

namespace Parcial2_ap1_20180240.UI.Reguistro
{
    public partial class rProyecto : Form
    {
        public rProyecto()
        {
            InitializeComponent();
        }
        public List<ProyectoDetalle> Detalle { get; set; }

        private void rProyecto_Load(object sender, EventArgs e)
        {
            TipoTareaComboBox.DataSource = TareasBLL.GetTarea();
            TipoTareaComboBox.DisplayMember = "TareaId";
            TipoTareaComboBox.ValueMember = "TipoTarea";
        }
        public void CargaGrid()
        {
            DataGridView.DataSource = null;
            DataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            ProyectoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Now.Date;
            RequerimientosTextBox.Clear();
            TiempoTextBox.Clear();
            TiempoTotalTextBox.Clear();

            CargaGrid();
        }
        private void LLenarCampo(Proyectos proyectos)
        {
            this.Detalle = new List<ProyectoDetalle>();
            ProyectoIdNumericUpDown.Value = proyectos.ProyectoId;
            TiempoTextBox.Text = proyectos.TiempoTotal.ToString();
            FechaDateTimePicker.Value = proyectos.Fecha;
            DescripcionTextBox.Text = proyectos.TiempoTotal.ToString();
        }

        private Proyectos LLenarClase()
        {
            Proyectos proyectos = new Proyectos();
            proyectos.ProyectoId.ToString();
            TiempoTotalTextBox.Text = proyectos.TiempoTotal.ToString();
            proyectos.Fecha = FechaDateTimePicker.Value.Date;
            proyectos.Descripcion = DescripcionTextBox.Text;
            return proyectos;
        }
        /* bool ExisteEnLaBasedeDato()
        {
            Proyectos proyectos = ProyectosBLL.Buscar(ProyectoIdNumericUpDown);
            return (proyectos != null);
        }*/
        public bool Validar()
        {
            bool paso = true;
            if (DescripcionTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(DescripcionTextBox, "Debe Agregar datos a este campo");
                DescripcionTextBox.Focus();
            }
            if (TipoTareaComboBox.Text == string.Empty)
            {
                ErrorProvider.SetError(TipoTareaComboBox, "Debe Agregar datos a este campo");
                TipoTareaComboBox.Focus();
            }
            if (RequerimientosTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(RequerimientosTextBox, "Debe Agregar datos a este campo");
                RequerimientosTextBox.Focus();
            }
            if (TiempoTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(TiempoTextBox, "Debe Agregar datos a este campo");
                TiempoTextBox.Focus();
            }
            if (TiempoTotalTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(TiempoTotalTextBox, "Debe Agregar datos a este campo");
                TiempoTotalTextBox.Focus();
            }
            return paso;
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Proyectos proyecto;
            int id;
            int.TryParse(ProyectoIdNumericUpDown.Text, out id);
            Limpiar();
            proyecto = ProyectosBLL.Buscar(id);
            if (proyecto != null)
            {
                MessageBox.Show("Proyecto Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Proyecto Inexistente", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.DataSource != null)
                this.Detalle = (List<ProyectoDetalle>)DataGridView.DataSource;
            if (TipoTareaComboBox.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Tipo de Tarea", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int total;
            int tiempo;

            Tarea tarea = TareasBLL.Buscar(Convert.ToInt32(TipoTareaComboBox));

            this.Detalle.Add(new ProyectoDetalle()
            {
                TipoId = Convert.ToInt32(TipoTareaComboBox.Text),
                TipoTarea = tarea.TipoTarea,
                Requerimiento = RequerimientosTextBox.Text,
                Tiempo = Convert.ToInt32(TiempoTextBox.Text)
            });
            CargaGrid();
            TipoTareaComboBox.Focus();

            total = Convert.ToInt32(TiempoTotalTextBox.Text);
            tiempo = Convert.ToInt32(TiempoTextBox.Text);
            total += tiempo;
            TiempoTotalTextBox.Text = Convert.ToString(total);
        }

        private void RemoverFilaButton_Click(object sender, EventArgs e)
        {
            string tiempo;
            int total = Convert.ToInt32(TiempoTotalTextBox.Text);

            if ((DataGridView.Rows.Count > 0 && DataGridView.CurrentRow != null))
            {
                tiempo = DataGridView.CurrentRow.Cells[3].Value.ToString();
                total -= Convert.ToInt32(tiempo);

                TiempoTextBox.Text = Convert.ToString(total);
                Detalle.RemoveAt(DataGridView.CurrentRow.Index);
                CargaGrid();
            }
            else
            {
                ErrorProvider.SetError(DataGridView, "No se encuentran datos aqui");
                DataGridView.Focus();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Proyectos proyectos;
            if (!Validar())
                return;
            proyectos = LLenarClase();

            var paso = ProyectosBLL.Guardar(proyectos);

            if (paso)
            {
                MessageBox.Show("Proyecto Guardaro", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Proyecto no se Guardo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            int id;
            int.TryParse(ProyectoIdNumericUpDown.Text, out id);

            if (ProyectosBLL.Eliminar(id))
            {
                MessageBox.Show("Rol Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Rol No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

