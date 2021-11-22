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
            plantaMusgo.MostrarPlantaMusgo += MostrarColoresLista;
            plantaMusgo.MostrarPlantaMusgo += MostrarLista;
            plantaMusgo.MostrarPlantaMusgo += MostrarImagen;
            plantaMusgo.ControlarLista(listaMusgo);
        }

        private void FrmListarPlantaMusgo_Load(object sender, EventArgs e)
        {
            CustomUI();
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
                PlantaMusgo planta = new PlantaMusgo(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, cantEsporas);
                plantaMusgo.AltaMusgo(planta);
               Conexion_DB.AgregarPlantaMusgo(planta);
                lblMensaje.Text = "Planta agregada";
                ActualizarDgv();
                plantaMusgo.ControlarLista(listaMusgo);
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
                            Conexion_DB.GuardarPlantaMusgo(item, item.Id);
                            lblMensaje.Text = "Modificacion Exitosa";
                        }
                    }
                    ActualizarDgv();
                    plantaMusgo.ControlarLista(listaMusgo);
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
                    Conexion_DB.EliminarPlantaMusgo(idAux);
                    lblMensaje.Text = "Planta eliminada exitosamente";
                    ActualizarDgv();
                    plantaMusgo.ControlarLista(listaMusgo);
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

        #region Manejadores

        /// <summary>
        /// Muestra la cantidad de plantas que tiene la lista 
        /// </summary>
        /// <param name="lista">lista de plantas</param>
        private void MostrarLista(List<PlantaMusgo> lista)
        {
            this.Refresh();
            lblEvento.Text = "Cantidad de plantas: " + lista.Count.ToString();
        }
        /// <summary>
        /// Colorea el texto segun la cantidad de plantas
        /// </summary>
        /// <param name="lista"></param>
        private void MostrarColoresLista(List<PlantaMusgo> lista)
        {
            if (lista.Count <= 3)
            {
                this.Refresh();
                lblEvento.BackColor = Color.DarkRed;
            }
            else if (lista.Count >= 3 && lista.Count <= 5)
            {

                this.Refresh();
                lblEvento.BackColor = Color.Coral;
            }
            else if (lista.Count > 5 && lista.Count <= 7)
            {
                this.Refresh();
                lblEvento.BackColor = Color.Orange;
            }
            else if (lista.Count > 7 && lista.Count <= 9)
            {
                this.Refresh();
                lblEvento.BackColor = Color.YellowGreen;
            }
            else
            {
                this.Refresh();
                lblEvento.BackColor = Color.ForestGreen;
            }
        }

        /// <summary>
        /// Coloca una imagen de acuerdo a la cantidad de plantas en la lista
        /// </summary>
        /// <param name="lista"></param>
        private void MostrarImagen(List<PlantaMusgo> lista)
        {
            if (lista.Count <= 3)
            {
                pb1.Show();
                pb2.Hide();
                pb3.Hide();
                pb4.Hide();
                pb5.Hide();
            }
            else if (lista.Count >= 3 && lista.Count <= 5)
            {
                pb1.Show();
                pb2.Show();
                pb3.Hide();
                pb4.Hide();
                pb5.Hide();
            }
            else if (lista.Count > 5 && lista.Count <= 7)
            {
                pb1.Show();
                pb2.Show();
                pb3.Show();
                pb4.Hide();
                pb5.Hide();
            }
            else if (lista.Count > 7 && lista.Count <= 9)
            {
                pb1.Show();
                pb2.Show();
                pb3.Show();
                pb4.Show();
                pb5.Hide();
            }
            else
            {
                pb1.Show();
                pb2.Show();
                pb3.Show();
                pb4.Show();
                pb5.Show();
            }

        }

        #endregion


        /// <summary>
        /// Customiza el UI
        /// </summary>
        private void CustomUI()
        {
            btnAlta.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardarCambios.Enabled = false;
            btnGuardarXml.Enabled = false;
            btnLimpiar.Enabled = false;
            btnAlta.BackColor = Color.Gray;
            btnEditar.BackColor = Color.Gray;
            btnGuardar.BackColor = Color.Gray;
            btnEliminar.BackColor = Color.Gray;
            btnGuardarCambios.BackColor = Color.Gray;
            btnGuardarXml.BackColor = Color.Gray;
            btnLimpiar.BackColor = Color.Gray;
            btnActualizar.BackColor = Color.Coral;
            pb1.Hide();
            pb2.Hide();
            pb3.Hide();
            pb4.Hide();
            pb5.Hide();
            lblEvento.Hide();
        }




        /// <summary>
        /// Boton que dispara la tarea de actualizar el datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lblCargando.Text = "Cargando lista de Plantas";

            Task.Run(() => ActualizarDatagrid());
        }

        /// <summary>
        /// Tarea encargada de traer la lista de plantas de la base de datos y actualizar el datagridview
        /// </summary>
        private void ActualizarDatagrid()
        {
            List<PlantaMusgo> listaAux;
            listaAux = Conexion_DB.TraerPlantaMusgo();
            Thread.Sleep(1500);

            if (this.dgvMusgo.InvokeRequired)
            {
                this.dgvMusgo.BeginInvoke((MethodInvoker)delegate ()
                {
                    dgvMusgo.DataSource = null;
                    dgvMusgo.DataSource = listaAux;
                    btnAlta.Enabled = true;
                    btnEditar.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardarCambios.Enabled = true;
                    btnGuardarXml.Enabled = true;
                    btnLimpiar.Enabled = true;
                    btnAlta.BackColor = Color.FromArgb(181, 205, 163);
                    btnEditar.BackColor = Color.FromArgb(181, 205, 163);
                    btnGuardar.BackColor = Color.FromArgb(181, 205, 163);
                    btnEliminar.BackColor = Color.FromArgb(181, 205, 163);
                    btnGuardarCambios.BackColor = Color.FromArgb(181, 205, 163);
                    btnGuardarXml.BackColor = Color.FromArgb(181, 205, 163);
                    btnActualizar.BackColor = Color.LightGray;
                    btnLimpiar.BackColor = Color.FromArgb(181, 205, 163);
                    btnActualizar.Enabled = false;
                    lblEvento.Show();
                    plantaMusgo.ControlarLista(listaMusgo);
                    lblCargando.Text = " ";
                });
            }
            else
            {
                dgvMusgo.DataSource = null;
                dgvMusgo.DataSource = CargaDeDatos.RetornarListaSinFruto();
            }
        }
    }
}
