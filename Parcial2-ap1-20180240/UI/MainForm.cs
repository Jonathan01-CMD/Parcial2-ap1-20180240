using Parcial2_ap1_20180240.UI.Consultas;
using Parcial2_ap1_20180240.UI.Reguistro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_ap1_20180240.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.RegistroToolStripMenuItem.Click += new EventHandler(this.RegistroToolStripMenuItem_ItemClicked);
            this.ConsultaToolStripMenuItem.Click += new EventHandler(this.ConsultaToolStripMenuItem_ItemClicked);
        }
        private void RegistroToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var proyecto = new rProyecto();
            proyecto.MdiParent = this;
            proyecto.Show();
        }
        private void ConsultaToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var proyecto = new cProyecto();
            proyecto.MdiParent = this;
            proyecto.Show();
        }
    }
}
