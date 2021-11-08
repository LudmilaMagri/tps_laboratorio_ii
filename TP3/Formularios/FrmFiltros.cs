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
    public partial class FrmFiltros : Form
    {
        List<PlantaConFruto> listaConFrutos;
        List<PlantaSinFruto> listaSinFrutos;
        List<PlantaMusgo> listaMusgos;
        static List<PlantaConFruto> listaFiltradaConFrutos;
        static List<PlantaSinFruto> listaFiltradaSinFruto;
        static List<PlantaMusgo> listaFiltradaMusgo;
        public FrmFiltros()
        {
            InitializeComponent();
            listaConFrutos = CargaDeDatos.RetornarListaConFruto();
            listaSinFrutos = CargaDeDatos.RetornarListaSinFruto();
            listaMusgos = CargaDeDatos.RetornarListaMusgo();
            listaFiltradaConFrutos = new List<PlantaConFruto>();
            listaFiltradaSinFruto = new List<PlantaSinFruto>();
            listaFiltradaMusgo = new List<PlantaMusgo>();
            dgvMostrarConFruto.DataSource = listaConFrutos;
            dgvSinFruto.DataSource = listaSinFrutos;
            dgvMusgos.DataSource = listaMusgos;

        }
        private void FrmFiltros_Load(object sender, EventArgs e)
        {

        }
        private void btnOrigen_Click(object sender, EventArgs e)
        {
            if(cmbOrigen.SelectedItem != null)
            {
                string origen = cmbOrigen.SelectedItem.ToString();

                listaFiltradaConFrutos = FiltrosGenericos.FiltrarPorOrigen(listaConFrutos, origen);
                listaFiltradaSinFruto = FiltrosGenericos.FiltrarPorOrigen(listaSinFrutos, origen);
                listaFiltradaMusgo = FiltrosGenericos.FiltrarPorOrigen(listaMusgos, origen);

                ActualizarDgvConFruto(listaFiltradaConFrutos);
                ActualizarDgvSinFruto(listaFiltradaSinFruto);
                ActualizarDgvMusgos(listaFiltradaMusgo);
            }
            else
            {
                lblMensaje.Text = "Seleccione un origen";
            }

        }
        private void btnExportOrigen_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbOrigen.SelectedItem !=null)
                {
                    if (listaFiltradaSinFruto != null || listaFiltradaConFrutos != null || listaFiltradaMusgo != null)
                    {
                        PlantaSinFruto.EscribirTxt(listaFiltradaSinFruto, "Filtrado_Origen_Plantas_SinFrutos");
                        PlantaConFruto.EscribirTxt(listaFiltradaConFrutos, "Filtrado_Origen_Plantas_ConFrutos");
                        PlantaMusgo.EscribirTxt(listaFiltradaMusgo, "Filtrado_Origen_Plantas_Musgos");
                        lblMensaje.Text = "Archivo de 'Filtrado Origen' generado correctamente";
                        this.ListasNulas();
                    }
                    else
                    {
                        lblMensaje.Text = "Error";
                    }
                }
                else
                {
                    lblMensaje.Text = "Seleccione un Origen";
                }
            }
            catch(EscribirTxtExceptionConFruto)
            {
                EscribirTxtExceptionConFruto ex = new EscribirTxtExceptionConFruto();
                lblMensaje.Text = ex.Message.ToString();
            }
            catch(EscribirTxtExceptionMusgo)
            {
                EscribirTxtExceptionMusgo ex = new EscribirTxtExceptionMusgo();
                lblMensaje.Text = ex.Message.ToString();
            }
            catch(EscribirTxtExceptionSinFruto)
            {
                EscribirTxtExceptionSinFruto ex = new EscribirTxtExceptionSinFruto();
                lblMensaje.Text = ex.Message.ToString();
            }
           
        }
        
        private void ActualizarDgvConFruto(List<PlantaConFruto> lista)
        {
            dgvMostrarConFruto.DataSource = null;
            dgvMostrarConFruto.DataSource = lista;
        }
        private void ActualizarDgvSinFruto(List<PlantaSinFruto> lista)
        {
            dgvSinFruto.DataSource = null;
            dgvSinFruto.DataSource = lista;
        }
        private void ActualizarDgvMusgos(List<PlantaMusgo> lista)
        {
            dgvMusgos.DataSource = null;
            dgvMusgos.DataSource = lista;
        }
       

        private void btnEsporas_Click(object sender, EventArgs e)
        {
            PlantaMusgo musgo = new PlantaMusgo();
            string nombreMusgo;
            nombreMusgo = PlantaMusgo.FiltrarCantidadEsporas(listaMusgos);
            listaFiltradaMusgo = musgo.BuscarPlantaPorNombre(nombreMusgo);
            ActualizarDgvMusgos(listaFiltradaMusgo);
        }
        private void btnExportEsporas_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaFiltradaMusgo != null)
                {
                    PlantaMusgo.EscribirTxt(listaFiltradaMusgo, "Filtrado_MaxEsporas_Plantas_Musgo");
                    lblMensaje.Text = "Archivo de 'Filtrado Max Esporas' generado correctamente";
                    this.ListasNulas();
                }
            }
            catch (EscribirTxtExceptionMusgo)
            {
                EscribirTxtExceptionMusgo ex = new EscribirTxtExceptionMusgo();
                lblMensaje.Text = ex.Message.ToString();
            }

        }

        private void btnFlor_Click(object sender, EventArgs e)
        {
            if(cmbFlor.SelectedItem != null)
            {
                string color = cmbFlor.SelectedItem.ToString();
                listaFiltradaConFrutos = PlantaConFruto.FiltrarColorFlor(listaConFrutos, color);
                ActualizarDgvConFruto(listaFiltradaConFrutos);
            }
            else
            {
                lblMensaje.Text = "Seleccione el color de la flor";
            }

            
        }
        private void btnExportColorFlor_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbFlor.SelectedItem != null)
                {
                    if (listaFiltradaConFrutos != null)
                    {
                        PlantaConFruto.EscribirTxt(listaFiltradaConFrutos, "Filtrado_ColorFlor_Plantas_ConFrutos");
                        lblMensaje.Text = "Archivo de 'Filtrado ColorFlor' generado correctamente";
                        this.ListasNulas();
                    }
                }
                else
                {
                    lblMensaje.Text = "Seleccione el color de la flor";
                }
            }
            catch (EscribirTxtExceptionConFruto)
            {
                EscribirTxtExceptionConFruto ex = new EscribirTxtExceptionConFruto();
                lblMensaje.Text = ex.Message.ToString();
            }
        }

        private void btnFruto_Click(object sender, EventArgs e)
        {
            if(cmbFruto.SelectedItem != null)
            {
                string fruto = cmbFruto.SelectedItem.ToString();
                listaFiltradaConFrutos = PlantaConFruto.FiltrarFruto(listaConFrutos, fruto);
                ActualizarDgvConFruto(listaFiltradaConFrutos);
            }
            else
            {
                lblMensaje.Text = "Seleccione un tipo de fruto";
            }
        }

        public void btnExportarFrutoTxt_Click(object sender, EventArgs e)
        {
            try
            { 
                if(cmbFruto.SelectedItem != null)
                {
                    if (listaFiltradaConFrutos != null)
                    {
                        PlantaConFruto.EscribirTxt(listaFiltradaConFrutos, "Filtrado_TipoFruto_Plantas_ConFrutos");
                        lblMensaje.Text = "Archivo de 'Filtrado TipoFruto' generado correctamente";

                        this.ListasNulas();
                    }
                }
                else
                {
                    lblMensaje.Text = "Seleccione un tipo de fruto";
                }
                
            }
            catch (EscribirTxtExceptionConFruto)
            {
                EscribirTxtExceptionConFruto ex = new EscribirTxtExceptionConFruto();
                lblMensaje.Text = ex.Message.ToString();
            }
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            PlantaConFruto conFruto = new PlantaConFruto();
            PlantaSinFruto sinFruto = new PlantaSinFruto();
            string nombreConFruto, nombreSinFruto;
            if(cmbAltura.SelectedItem != null)
            {
                switch (cmbAltura.SelectedItem.ToString())
                {
                    case "Con Fruto":
                        nombreConFruto = conFruto.AlturaMaxima();
                        listaFiltradaConFrutos = conFruto.BuscarPlantaPorNombre(nombreConFruto);
                        ActualizarDgvConFruto(listaFiltradaConFrutos);
                        break;

                    default:
                        nombreSinFruto = sinFruto.AlturaMaxima();
                        listaFiltradaSinFruto = sinFruto.BuscarPlantaPorNombre(nombreSinFruto);
                        ActualizarDgvSinFruto(listaFiltradaSinFruto);
                        break;
                }
            }
            else
            {
                lblMensaje.Text = "Seleccione un tipo de planta";
            }
            
        }
        private void btnExportAlturaMax_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbAltura.SelectedItem!= null)
                {
                    if (listaFiltradaConFrutos != null)
                    {
                        PlantaConFruto.EscribirTxt(listaFiltradaConFrutos, "Filtrado_AlturaMax_Plantas_ConFrutos");
                        lblMensaje.Text = "Archivo de 'Filtrado AlturaMax' generado correctamente";
                        this.ListasNulas();
                    }
                    if (listaFiltradaSinFruto != null)
                    {
                        PlantaSinFruto.EscribirTxt(listaFiltradaSinFruto, "Filtrado_AlturaMax_Plantas_SinFrutos");
                        lblMensaje.Text = "Archivo de 'Filtrado AlturaMax' generado correctamente";
                        this.ListasNulas();
                    }
                }
                else
                {
                    lblMensaje.Text = "Seleccione un tipo de planta";
                }
            }
            catch (EscribirTxtExceptionConFruto)
            {
                EscribirTxtExceptionConFruto ex = new EscribirTxtExceptionConFruto();
                lblMensaje.Text = ex.Message.ToString();
            }
            catch (EscribirTxtExceptionSinFruto)
            {
                EscribirTxtExceptionSinFruto ex = new EscribirTxtExceptionSinFruto();
                lblMensaje.Text = ex.Message.ToString();
            }
        }
        private void ListasNulas()
        {
            listaFiltradaConFrutos = null;
            listaFiltradaMusgo = null;
            listaFiltradaSinFruto = null;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
