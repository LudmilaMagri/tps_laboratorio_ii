using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace Formularios
{
    public partial class FrmListarPlantaSinFruto : Form
    {
        List<PlantaSinFruto> listaSinFruto;
        PlantaSinFruto plantaSinFruto;

        public FrmListarPlantaSinFruto()
        {
            InitializeComponent();
            listaSinFruto = CargaDeDatos.RetornarListaSinFruto();
            plantaSinFruto = new PlantaSinFruto();
           
        }
        private void FrmListarPlantaSinFruto_Load(object sender, EventArgs e)
        {
            cmbTipoPlanta.DataSource = Enum.GetValues(typeof(PlantaSinFruto.ETipoPlanta));
            dgvListarSinFruto.DataSource = listaSinFruto;
        }
        public void ActualizarDgv()
        {
            dgvListarSinFruto.DataSource = null;
            listaSinFruto = CargaDeDatos.RetornarListaSinFruto();
            dgvListarSinFruto.DataSource = listaSinFruto;
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCicloVida.Text, out int añosVidaParse);
            float.TryParse(txtCantAgua.Text, out float cantAguaParse);
            float.TryParse(txtAltura.Text, out float alturaParse);
            string mensaje = txtNombre.Text;
            try
            {
                switch (cmbTipoPlanta.SelectedItem)
                {
                    case PlantaSinFruto.ETipoPlanta.Arbol:
                        PlantaSinFruto.AltaSinFruto(new PlantaSinFruto(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, PlantaSinFruto.ETipoPlanta.Arbol, alturaParse));
                        break;
                    case PlantaSinFruto.ETipoPlanta.Arbusto:
                        PlantaSinFruto.AltaSinFruto(new PlantaSinFruto(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, PlantaSinFruto.ETipoPlanta.Arbusto, alturaParse));
                        break;
                }
                ActualizarDgv();
            }
            catch (NombreException)
            {
                NombreException name = new NombreException();
                lblCatchNombre.Text = name.Message.ToString();
            }
            catch (OrigenException)
            {
                OrigenException origen = new OrigenException();
                lblCatchOrigen.Text = origen.Message.ToString();
            }
            catch (FamiliaException)
            {
                FamiliaException familia = new FamiliaException();
                lblCatchFamilia.Text = familia.Message.ToString();
            }
            catch (AniosVidaException)
            {
                AniosVidaException aniosVidaException = new AniosVidaException();
                lblCatchVida.Text = aniosVidaException.Message.ToString();
            }
            catch (CantidadAguaException)
            {
                CantidadAguaException cantAgua = new CantidadAguaException();
                lblCatchCantAgua.Text = cantAgua.Message.ToString();
            }
            catch(AlturaException)
            {
                AlturaException altura = new AlturaException();
                lblCatchAltura.Text = altura.Message.ToString();
            }
            
            
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListarSinFruto.SelectedRows.Count > 0)
            {
                txtIdPlanta.Text = dgvListarSinFruto.CurrentRow.Cells[1].Value.ToString();
                txtAltura.Text = dgvListarSinFruto.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = dgvListarSinFruto.CurrentRow.Cells[3].Value.ToString();
                txtFamilia.Text = dgvListarSinFruto.CurrentRow.Cells[4].Value.ToString();
                txtOrigen.Text = dgvListarSinFruto.CurrentRow.Cells[5].Value.ToString();
                txtCicloVida.Text = dgvListarSinFruto.CurrentRow.Cells[6].Value.ToString();
                txtCantAgua.Text = dgvListarSinFruto.CurrentRow.Cells[7].Value.ToString();
                ActualizarDgv();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCicloVida.Text, out int añosVidaParse);
            float.TryParse(txtCantAgua.Text, out float cantAguaParse);
            float.TryParse(txtAltura.Text, out float alturaParse);

            try
            {

                if (!(txtIdPlanta.Text == ""))
                {
                    foreach (PlantaSinFruto item in listaSinFruto)
                    {
                        if (item.Id == int.Parse(txtIdPlanta.Text))
                        {
                            item.Nombre = txtNombre.Text;
                            item.Familia = txtFamilia.Text;
                            item.Origen = txtOrigen.Text;
                            item.AniosVida = int.Parse(txtCicloVida.Text);
                            item.CantidadAgua = float.Parse(txtCantAgua.Text);
                            item.Altura = float.Parse(txtAltura.Text);
                            lblMensaje.Text = "Modificacion Exitosa";
                        }
                    }
                }
                else
                    MessageBox.Show("Ingrese los datos");
            }
            catch (NombreException )
            {
                lblCatchNombre.Text = "Error al ingresar el nombre";
            }
            catch (OrigenException)
            {
                lblCatchOrigen.Text = "Error al ingresar el origen";
            }
            catch (FamiliaException)
            {
                lblCatchFamilia.Text = "Error al ingresar la familia";
            }
            catch (AniosVidaException)
            {
                lblCatchVida.Text = "Error al ingresar los años de vida";
            }
            catch (CantidadAguaException)
            {
                lblCatchCantAgua.Text = "Error al ingresar la cantidad de agua";
            }
            catch (AlturaException)
            {
                lblCatchAltura.Text = "Error al ingresar la altura";
            }
            
        }

      
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvListarSinFruto.SelectedRows.Count > 0)
            {
                txtIdPlanta.Text = dgvListarSinFruto.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("Esta seguro de eliminar esta planta?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int.TryParse(txtIdPlanta.Text, out int idAux);
                    plantaSinFruto.EliminarPlanta(idAux);
                    lblMensaje.Text = "Planta eliminada exitosamente";
                    ActualizarDgv();
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar");
            }
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                Archivos<List<PlantaSinFruto>>.EscribirJson(listaSinFruto, "Planta_Sin_Fruto");
                lblMensaje.Text = "Guardado con exito en .json";
            }
            catch (EscribirJsonException)
            {
                EscribirJsonException ex = new EscribirJsonException();
                lblMensaje.Text = ex.Message.ToString();
            }
        }

        private void btnGuardarXml_Click(object sender, EventArgs e)
        {
            try
            {
                Archivos<List<PlantaSinFruto>>.EscribirXml(listaSinFruto, "Planta_Sin_Fruto");
                lblMensaje.Text = "Guardado con exito en .xml";
            }
            catch(EscribirXmlException)
            {
                EscribirXmlException ex = new EscribirXmlException();
                lblMensaje.Text = ex.Message.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Limpia los text box y los label
        /// </summary>
        private void Limpiar()
        {
            txtNombre.Clear();
            txtOrigen.Clear();
            txtFamilia.Clear();
            txtCicloVida.Clear();
            txtCantAgua.Clear();
            txtIdPlanta.Clear();
            txtAltura.Clear();
            lblMensaje.Text = " ";
            lblCatchAltura.Text = " ";
            lblCatchCantAgua.Text = " ";
            lblCatchFamilia.Text = " ";
            lblCatchNombre.Text = " ";
            lblCatchOrigen.Text = " ";
            lblCatchVida.Text = " ";
        }
    }
}
