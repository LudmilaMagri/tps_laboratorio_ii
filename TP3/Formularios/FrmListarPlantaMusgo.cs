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
    public partial class FrmListarPlantaMusgo : Form
    {
        List<PlantaMusgo> listaMusgo;
        PlantaMusgo plantaMusgo;
        public FrmListarPlantaMusgo()
        {
            InitializeComponent();
            listaMusgo = CargaDeDatos.RetornarListaMusgo();
            plantaMusgo = new PlantaMusgo();
        }

        private void FrmListarPlantaMusgo_Load(object sender, EventArgs e)
        {
            dgvMusgo.DataSource = listaMusgo;
        }
        public void ActualizarDgv()
        {
            dgvMusgo.DataSource = null;
            listaMusgo = CargaDeDatos.RetornarListaMusgo();
            dgvMusgo.DataSource = listaMusgo;
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCicloVida.Text, out int añosVidaParse);
            float.TryParse(txtCantidadAgua.Text, out float cantAguaParse);
            float.TryParse(txtCantEsporas.Text, out float alturaParse);
            int.TryParse(txtCantEsporas.Text, out int cantEsporas);

            try
            {
                plantaMusgo.AltaMusgo(new PlantaMusgo(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, cantEsporas));
                lblMensaje.Text = "Planta agregada";
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
                lblOrigen.Text = origen.Message.ToString();
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
                lblCatchAgua.Text = cantAgua.Message.ToString();
            }
            catch (CantidadEsporasException)
            {
                CantidadEsporasException esporas = new CantidadEsporasException();
                lblCatchEsporas.Text = esporas.Message.ToString();
            }


        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMusgo.SelectedRows.Count > 0)
            {
                txtIdPlanta.Text = dgvMusgo.CurrentRow.Cells[0].Value.ToString();
                txtCantEsporas.Text = dgvMusgo.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvMusgo.CurrentRow.Cells[2].Value.ToString();
                txtFamilia.Text = dgvMusgo.CurrentRow.Cells[3].Value.ToString();
                txtOrigen.Text = dgvMusgo.CurrentRow.Cells[4].Value.ToString();
                txtCicloVida.Text = dgvMusgo.CurrentRow.Cells[5].Value.ToString();
                txtCantidadAgua.Text = dgvMusgo.CurrentRow.Cells[6].Value.ToString();
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
                    foreach (PlantaMusgo item in listaMusgo)
                    {
                        if (item.Id == int.Parse(txtIdPlanta.Text))
                        {
                            item.Nombre = txtNombre.Text;
                            item.Familia = txtFamilia.Text;
                            item.Origen = txtOrigen.Text;
                            item.AniosVida = int.Parse(txtCicloVida.Text);
                            item.CantidadAgua = float.Parse(txtCantidadAgua.Text);
                            item.CantidadEsporas = int.Parse(txtCantEsporas.Text);
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
                lblOrigen.Text = origen.Message.ToString();
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
                lblCatchAgua.Text = cantAgua.Message.ToString();
            }
            catch (CantidadEsporasException)
            {
                CantidadEsporasException esporas = new CantidadEsporasException();
                lblCatchEsporas.Text = esporas.Message.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMusgo.SelectedRows.Count > 0)
            {
                txtIdPlanta.Text = dgvMusgo.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("Esta seguro de eliminar esta planta?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int.TryParse(txtIdPlanta.Text, out int idAux);
                    plantaMusgo.EliminarPlanta(idAux);
                    lblMensaje.Text = "Planta eliminada exitosamente";
                    ActualizarDgv();
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                Archivos<List<PlantaMusgo>>.EscribirJson(listaMusgo, "Lista_Musgos_Actualizada");
                lblMensaje.Text = "Guardado con exito en .json";
            }
            catch(EscribirJsonException)
            {
                EscribirJsonException ex = new EscribirJsonException();
                lblMensaje.Text = ex.Message.ToString();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            lblMensaje.Text = " ";
            lblCatchAgua.Text = " ";
            lblCatchFamilia.Text = " ";
            lblCatchNombre.Text = " ";
            lblOrigen.Text = " ";
            lblCatchVida.Text = " ";
        }

        private void btnGuardarCambios_Click_1(object sender, EventArgs e)
        {
            try
            {
                Archivos<List<PlantaMusgo>>.EscribirJson(listaMusgo, "Planta_Musgo");
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
                Archivos<List<PlantaMusgo>>.EscribirXml(listaMusgo, "Planta_Musgo");
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
