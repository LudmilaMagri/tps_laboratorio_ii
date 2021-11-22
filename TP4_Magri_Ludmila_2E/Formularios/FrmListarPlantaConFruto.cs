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
    public partial class FrmListarPlantaConFruto : Form
    {
        List<PlantaConFruto> listaConFruto;
        PlantaConFruto plantaConFruto;


        public FrmListarPlantaConFruto()
        {
            InitializeComponent();
            listaConFruto = CargaDeDatos.RetornarListaConFruto();
            plantaConFruto = new PlantaConFruto();
            plantaConFruto.MostrarPlantaConFruto += MostrarLista;
            plantaConFruto.MostrarPlantaConFruto += MostrarColoresLista;
            plantaConFruto.MostrarPlantaConFruto += MostrarImagen;
            plantaConFruto.ControlarLista(listaConFruto);
        }
       
        private void FrmListarPlantaConFruto_Load(object sender, EventArgs e)
        {
            cmbColorFlor.DataSource = Enum.GetValues(typeof(PlantaConFruto.EColorFlor));
            CustomUI();
        }

        
        private void btnAlta_Click(object sender, EventArgs e)
        {
            PlantaConFruto planta;
            int.TryParse(txtCicloVida.Text, out int añosVidaParse);
            float.TryParse(txtCantidadAgua.Text, out float cantAguaParse);
            float.TryParse(txtAltura.Text, out float alturaParse);
            
            try
            {
                switch (cmbColorFlor.SelectedItem)
                {

                    case PlantaConFruto.EColorFlor.roja:
                        planta = new PlantaConFruto(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, PlantaConFruto.EColorFlor.roja, txtTipoFruto.Text, alturaParse);
                        PlantaConFruto.AltaConFruto(planta);
                        Conexion_DB.AgregarPlantaConFruto(planta);
                        break;
                    case PlantaConFruto.EColorFlor.rosa:
                        planta = new PlantaConFruto(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, PlantaConFruto.EColorFlor.rosa, txtTipoFruto.Text, alturaParse);
                        PlantaConFruto.AltaConFruto(planta);
                        Conexion_DB.AgregarPlantaConFruto(planta);
                        break;
                    case PlantaConFruto.EColorFlor.amarilla:
                        planta = new PlantaConFruto(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, PlantaConFruto.EColorFlor.amarilla, txtTipoFruto.Text, alturaParse);
                        PlantaConFruto.AltaConFruto(planta);
                        Conexion_DB.AgregarPlantaConFruto(planta);
                        break;
                }
                  lblMensaje.Text = "Planta agregada exitosamente";
                  ActualizarDgv();
                plantaConFruto.ControlarLista(listaConFruto);
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
                            Conexion_DB.GuardarPlantaConFruto(item, item.Id);
                            lblMensaje.Text = "Modificacion Exitosa";
                        }
                    }
                    ActualizarDgv();
                    plantaConFruto.ControlarLista(listaConFruto);
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
                    Conexion_DB.EliminarPlantaConFruto(idAux);
                    lblMensaje.Text = "Planta eliminada exitosamente";
                    ActualizarDgv();
                    plantaConFruto.ControlarLista(listaConFruto);

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
            txtTipoFruto.Clear();
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

        #region Manejadores

        /// <summary>
        /// Muestra la cantidad de plantas que tiene la lista 
        /// </summary>
        /// <param name="lista">lista de plantas</param>
        private void MostrarLista(List<PlantaConFruto> lista)
        {
            this.Refresh();
            lblEvento.Text = "Cantidad de plantas: " + lista.Count.ToString();
        }
        /// <summary>
        /// Colorea el texto segun la cantidad de plantas
        /// </summary>
        /// <param name="lista"></param>
        private void MostrarColoresLista(List<PlantaConFruto> lista)
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
        private void MostrarImagen(List<PlantaConFruto> lista)
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
            btnGuardarEdit.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardarCambios.Enabled = false;
            btnGuardarXml.Enabled = false;
            btnLimpiar.Enabled = false;
            btnAlta.BackColor = Color.Gray;
            btnEditar.BackColor = Color.Gray;
            btnGuardarEdit.BackColor = Color.Gray;
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
            List<PlantaConFruto> listaAux;
            listaAux = Conexion_DB.TraerPlantaConFruto();
            Thread.Sleep(1500);
            
            if (this.dgvConFruto.InvokeRequired)
            {
                this.dgvConFruto.BeginInvoke((MethodInvoker)delegate ()
                {
                    dgvConFruto.DataSource = null;
                    dgvConFruto.DataSource = listaAux;
                    btnAlta.Enabled = true;
                    btnEditar.Enabled = true;
                    btnGuardarEdit.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardarCambios.Enabled = true;
                    btnGuardarXml.Enabled = true;
                    btnLimpiar.Enabled = true;
                    btnAlta.BackColor = Color.FromArgb(181, 205, 163);
                    btnEditar.BackColor = Color.FromArgb(181, 205, 163);
                    btnGuardarEdit.BackColor = Color.FromArgb(181, 205, 163);
                    btnEliminar.BackColor = Color.FromArgb(181, 205, 163);
                    btnGuardarCambios.BackColor = Color.FromArgb(181, 205, 163);
                    btnGuardarXml.BackColor = Color.FromArgb(181, 205, 163);
                    btnActualizar.BackColor = Color.LightGray;
                    btnLimpiar.BackColor = Color.FromArgb(181, 205, 163);
                    btnActualizar.Enabled = false;
                    lblEvento.Show();
                    plantaConFruto.ControlarLista(listaConFruto);
                    lblCargando.Text = " ";
                });
            }
            else
            {
                dgvConFruto.DataSource = null;
                dgvConFruto.DataSource = CargaDeDatos.RetornarListaSinFruto();
            }
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
    }

}
