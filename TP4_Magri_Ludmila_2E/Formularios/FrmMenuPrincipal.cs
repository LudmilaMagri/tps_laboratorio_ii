using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if((MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void btnPlantaSinFruto_Click(object sender, EventArgs e)
        {
            FrmListarPlantaSinFruto fSinFruto = new FrmListarPlantaSinFruto();
            if(fSinFruto.ShowDialog() == DialogResult.OK)
            {
                this.BringToFront();
            }
        }

        private void btnPlantaConFruto_Click(object sender, EventArgs e)
        {
            FrmListarPlantaConFruto fConFruto = new FrmListarPlantaConFruto();
            if (fConFruto.ShowDialog() == DialogResult.OK)
            {
                this.BringToFront();
            }
        }

        private void btnPlantaMusgo_Click(object sender, EventArgs e)
        {
            FrmListarPlantaMusgo fMusgo = new FrmListarPlantaMusgo();
            if (fMusgo.ShowDialog() == DialogResult.OK)
            {
                this.BringToFront();
            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            FrmFiltros filtros = new FrmFiltros();
            if (filtros.ShowDialog() == DialogResult.OK)
            {
                this.BringToFront();
            }
        }
    }
}
