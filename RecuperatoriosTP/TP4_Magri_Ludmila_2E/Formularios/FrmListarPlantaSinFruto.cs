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
    public partial class FrmListarPlantaSinFruto : Form
    {
        List<PlantaSinFruto> listaSinFruto;
        PlantaSinFruto plantaSinFruto;

        public FrmListarPlantaSinFruto()
        {
            InitializeComponent();
            listaSinFruto = CargaDeDatos.RetornarListaSinFruto();
            plantaSinFruto = new PlantaSinFruto();
            plantaSinFruto.MostrarPlantaSinFruto += MostrarColoresLista;
            plantaSinFruto.MostrarPlantaSinFruto += MostrarLista;
            plantaSinFruto.MostrarPlantaSinFruto += MostrarImagen;
            plantaSinFruto.ControlarLista(listaSinFruto);
        }

 
        private void FrmListarPlantaSinFruto_Load(object sender, EventArgs e)
        {
            cmbTipoPlanta.DataSource = Enum.GetValues(typeof(PlantaSinFruto.ETipoPlanta));
            CustomUI();

        }

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
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lblCargando.Text = "Cargando lista de Plantas";
            
            Task.Run(() => ActualizarDatagrid());
           
        }

        private void ActualizarDatagrid()
        {
            List<PlantaSinFruto> listaAux;
            listaAux = Conexion_DB.TraerPlantaSinFruto();
            Thread.Sleep(1500);

            if (this.dgvListarSinFruto.InvokeRequired)
            {
                this.dgvListarSinFruto.BeginInvoke((MethodInvoker)delegate ()
                {
                    dgvListarSinFruto.DataSource = null;
                    dgvListarSinFruto.DataSource = listaAux;
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
                    plantaSinFruto.ControlarLista(listaSinFruto);
                    lblCargando.Text = " ";
                });
            }
            else
            {
                dgvListarSinFruto.DataSource = null;
                dgvListarSinFruto.DataSource = CargaDeDatos.RetornarListaSinFruto();
            }

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
            PlantaSinFruto planta = new PlantaSinFruto();
            try
            {
                switch (cmbTipoPlanta.SelectedItem)
                {
                    case PlantaSinFruto.ETipoPlanta.Arbol:
                        planta = new PlantaSinFruto(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, PlantaSinFruto.ETipoPlanta.Arbol, alturaParse);
                        PlantaSinFruto.AltaSinFruto(planta);
                        Conexion_DB.AgregarPlantaSinFruto(planta);
                        break;
                    case PlantaSinFruto.ETipoPlanta.Arbusto:
                        planta = new PlantaSinFruto(txtNombre.Text, txtFamilia.Text, txtOrigen.Text, añosVidaParse, cantAguaParse, PlantaSinFruto.ETipoPlanta.Arbusto, alturaParse);
                        PlantaSinFruto.AltaSinFruto(planta);
                        Conexion_DB.AgregarPlantaSinFruto(planta);
                        break;
                }
                lblMensaje.Text = "Planta agregada exitosamente";
                ActualizarDgv();
                plantaSinFruto.ControlarLista(listaSinFruto);
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
                            Conexion_DB.GuardarPlantaSinFruto(item, item.Id);
                            lblMensaje.Text = "Modificacion Exitosa";
                        }
                    }
                    ActualizarDgv();
                    plantaSinFruto.ControlarLista(listaSinFruto);
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
                    Conexion_DB.EliminarPlantaSinFruto(idAux);
                    lblMensaje.Text = "Planta eliminada exitosamente";
                    ActualizarDgv();
                    plantaSinFruto.ControlarLista(listaSinFruto);
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


        #region Manejadores

        /// <summary>
        /// Muestra la cantidad de plantas que tiene la lista 
        /// </summary>
        /// <param name="lista">lista de plantas</param>
        private void MostrarLista(List<PlantaSinFruto> lista)
        {
            this.Refresh();
            lblEvento.Text = "Cantidad de plantas: " + lista.Count.ToString();
        }
        /// <summary>
        /// Colorea el texto segun la cantidad de plantas
        /// </summary>
        /// <param name="lista"></param>
        private void MostrarColoresLista(List<PlantaSinFruto> lista)
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
        private void MostrarImagen(List<PlantaSinFruto> lista)
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
