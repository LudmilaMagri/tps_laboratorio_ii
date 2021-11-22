using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "CARGANDO...";
            this.Refresh();
            pbGif.Show();
            btnFiltros.BackColor = Color.Gray;
            btnPlantaConFruto.BackColor = Color.Gray;
            btnPlantaSinFruto.BackColor = Color.Gray;
            btnPlantaMusgo.BackColor = Color.Gray;
            btnFiltros.Enabled = false;
            btnPlantaConFruto.Enabled = false;
            btnPlantaSinFruto.Enabled = false;
            btnPlantaMusgo.Enabled = false;
            this.Cargar();
            
            this.Refresh();
        }

        private async void Cargar()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                if (this.btnFiltros.InvokeRequired && this.btnPlantaConFruto.InvokeRequired &&
                    this.btnPlantaSinFruto.InvokeRequired && this.btnPlantaMusgo.InvokeRequired)
                {
                    this.btnFiltros.BeginInvoke((MethodInvoker)delegate ()
                    {
                        btnFiltros.BackColor = Color.FromArgb(181, 205, 163);
                        btnFiltros.Enabled = true;
                        lblMensaje.Text = "Carga completada";
                        btnPlantaConFruto.BackColor = Color.FromArgb(181, 205, 163);
                        btnPlantaConFruto.Enabled = true;
                        btnPlantaSinFruto.BackColor = Color.FromArgb(181, 205, 163);
                        btnPlantaSinFruto.Enabled = true;
                        btnPlantaMusgo.BackColor = Color.FromArgb(181, 205, 163);
                        btnPlantaMusgo.Enabled = true;
                        this.Refresh();
                        pbGif.Hide();
                    });
                }
            });
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
