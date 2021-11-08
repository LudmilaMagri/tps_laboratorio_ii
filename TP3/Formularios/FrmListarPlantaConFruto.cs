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
    public partial class FrmListarPlantaConFruto : Form
    {
        List<PlantaConFruto> listaConFruto;
        PlantaConFruto plantaConFruto;


        public FrmListarPlantaConFruto()
        {
            InitializeComponent();
            listaConFruto = CargaDeDatos.RetornarListaConFruto();
            plantaConFruto = new PlantaConFruto();
        }

       
        private void FrmListarPlantaConFruto_Load(object sender, EventArgs e)
        {
            cmbColorFlor.DataSource = Enum.GetValues(typeof(PlantaConFruto.EColorFlor));
            dgvConFruto.DataSource = listaConFruto;
        }

        /// <summary>
        /// Actualiza el DataGridView
        /// </summary>
        public void ActualizarDgv()
        {
            dgvConFruto.DataSource = null;
            listaConFruto = CargaDeDatos.RetornarListaConFruto();
            dgvConFruto.DataSource = listaConFruto;
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCicloVida.Text, out int añosVidaParse);
            float.TryParse(txtCantidadAgua.Text, out float cantAguaParse);
            float.TryParse(txtAltura.Text, out float alturaParse);

            try
            {
                switch (cmbColorFlor.SelectedItem)
                {
                    case PlantaConFruto.EColorFlor.roja:
                        PlantaConFruto.AltaConFruto(new PlantaConFruto(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, PlantaConFruto.EColorFlor.roja, txtTipoFruto.Text ,alturaParse));
                        break;
                    case PlantaConFruto.EColorFlor.rosa:
                        PlantaConFruto.AltaConFruto(new PlantaConFruto(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, PlantaConFruto.EColorFlor.rosa, txtTipoFruto.Text, alturaParse));
                        break;
                    case PlantaConFruto.EColorFlor.amarilla:
                        PlantaConFruto.AltaConFruto(new PlantaConFruto(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, PlantaConFruto.EColorFlor.amarilla, txtTipoFruto.Text, alturaParse));
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
            catch (AlturaException)
            {
                AlturaException altura = new AlturaException();
                lblCatchAltura.Text = altura.Message.ToString();
            }
            catch(FrutoException)
            {
                FrutoException fruto = new FrutoException();
                lblCatchFruto.Text = fruto.Message.ToString();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvConFruto.SelectedRows.Count > 0)
            {
                txtIdPlanta.Text = dgvConFruto.CurrentRow.Cells[0].Value.ToString();
                txtTipoFruto.Text = dgvConFruto.CurrentRow.Cells[2].Value.ToString();
                txtAltura.Text = dgvConFruto.CurrentRow.Cells[3].Value.ToString();
                txtNombre.Text = dgvConFruto.CurrentRow.Cells[4].Value.ToString();
                txtFamilia.Text = dgvConFruto.CurrentRow.Cells[5].Value.ToString();
                txtOrigen.Text = dgvConFruto.CurrentRow.Cells[6].Value.ToString();
                txtCicloVida.Text = dgvConFruto.CurrentRow.Cells[7].Value.ToString();
                txtCantidadAgua.Text = dgvConFruto.CurrentRow.Cells[8].Value.ToString();
                ActualizarDgv();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }
        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            try
            { 
                if (!(txtIdPlanta.Text == ""))
                {
                    foreach (PlantaConFruto item in listaConFruto)
                    {
                        if (item.Id == int.Parse(txtIdPlanta.Text))
                        {
                            item.Nombre = txtNombre.Text;
                            item.Familia = txtFamilia.Text;
                            item.Origen = txtOrigen.Text;
                            item.AniosVida = int.Parse(txtCicloVida.Text);
                            item.CantidadAgua = float.Parse(txtCantidadAgua.Text);
                            item.Altura = float.Parse(txtAltura.Text);
                            item.Fruto = txtTipoFruto.Text;
                            lblMensaje.Text = "Modificacion Exitosa";
                        }
                    }
                    ActualizarDgv();
                }
                else
                    MessageBox.Show("Ingrese los datos");
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
            catch (AlturaException)
            {
                AlturaException altura = new AlturaException();
                lblCatchAltura.Text = altura.Message.ToString();
            }
            catch (FrutoException)
            {
                FrutoException fruto = new FrutoException();
                lblCatchFruto.Text = fruto.Message.ToString();
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvConFruto.SelectedRows.Count > 0)
            {
                txtIdPlanta.Text = dgvConFruto.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("Esta seguro de eliminar esta planta?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int.TryParse(txtIdPlanta.Text, out int idAux);
                    plantaConFruto.EliminarPlanta(idAux);
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
            txtCantidadAgua.Clear();
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


        private void btnGuardarCambios_Click_1(object sender, EventArgs e)
        {
            try
            {
                Archivos<List<PlantaConFruto>>.EscribirJson(listaConFruto, "Lista_ConFruto_Actualizada");
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
                Archivos<List<PlantaConFruto>>.EscribirXml(listaConFruto, "Planta_Con_Fruto");
                lblMensaje.Text = "Guardado con exito en .xml";
            }
            catch (EscribirXmlException)
            {
                EscribirXmlException ex = new EscribirXmlException();
                lblMensaje.Text = ex.Message.ToString();
            }
        }
    }
}
