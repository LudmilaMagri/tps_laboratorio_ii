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
            this.ListasNulas();
        }

        private void btnOrigen_Click(object sender, EventArgs e)
        {
            if(cmbOrigen.SelectedItem != null)
            {
                string origen = cmbOrigen.SelectedItem.ToString();

                listaFiltradaConFrutos = FiltrosGenericos.FiltrarPorOrigen(listaConFrutos, origen);
                listaFiltradaSinFruto = FiltrosGenericos.FiltrarPorOrigen(listaSinFrutos, origen);
                listaFiltradaMusgo = FiltrosGenericos.FiltrarPorOrigen(listaMusgos, origen);
                float porcentaje = FiltrosGenericos.PorcentajeOrigen(listaConFrutos, listaSinFrutos, listaMusgos, cmbOrigen.Text);
                lblMensaje.Text = "El porcentaje de Plantas con origen de " + cmbOrigen.Text + " es: " + porcentaje + "%";

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
                        float porcentaje = FiltrosGenericos.PorcentajeOrigen(listaConFrutos, listaSinFrutos, listaMusgos, cmbOrigen.Text);

                        PlantaSinFruto.EscribirTxtPorcentaje(listaFiltradaSinFruto, "Filtrado_Origen_Plantas_SinFrutos", porcentaje);
                        PlantaConFruto.EscribirTxtPorcentaje(listaFiltradaConFrutos, "Filtrado_Origen_Plantas_ConFrutos", porcentaje);
                        PlantaMusgo.EscribirTxTPorcentaje(listaFiltradaMusgo, "Filtrado_Origen_Plantas_Musgos", porcentaje);

                        lblMensaje.Text = "Archivo de 'Filtrado Origen' generado correctamente";
                        this.ListasNulas();
                    }
                    else
                    {
                        lblMensaje.Text = "Haga click en 'Filtrar' para generar los resultados";
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
       
       

        private void btnEsporas_Click(object sender, EventArgs e)
        {
            PlantaMusgo musgo = new PlantaMusgo();
            string nombreMusgo;
            nombreMusgo = listaMusgos.FiltrarCantidadEsporas();
            listaFiltradaMusgo = musgo.BuscarPlantaPorNombre(nombreMusgo);
            lblMensaje.Text = "La planta con mas esporas es : " + nombreMusgo;
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
                else
                    lblMensaje.Text = "Haga click en 'Max Esporas' para generar los resultados";
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
                float porcentaje = PlantaConFruto.PorcentajeDeFLor(listaFiltradaConFrutos, listaConFrutos, color);
                lblMensaje.Text = "El porcentaje de flores con color " + color.ToString() + " es: " + porcentaje + "%";
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
                        float porcentaje = PlantaConFruto.PorcentajeDeFLor(listaFiltradaConFrutos, listaConFrutos, cmbFlor.Text);

                        PlantaConFruto.EscribirTxtPorcentaje(listaFiltradaConFrutos, "Filtrado_ColorFlor_Plantas_ConFrutos", porcentaje);
                        lblMensaje.Text = "Archivo de 'Filtrado ColorFlor' generado correctamente";
                        this.ListasNulas();
                    }
                    else
                        lblMensaje.Text = "Haga click en 'Filtrar' para generar los resultados";
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
                float resultado = PlantaConFruto.PorcentajeDeFrutos(listaFiltradaConFrutos, listaConFrutos, fruto);
                lblMensaje.Text = "El porcentaje de plantas con fruto " + fruto + " es: " + resultado + "%";
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
                        float porcentaje = PlantaConFruto.PorcentajeDeFrutos(listaFiltradaConFrutos, listaConFrutos, cmbFruto.Text);
                        PlantaConFruto.EscribirTxtPorcentaje(listaFiltradaConFrutos, "Filtrado_TipoFruto_Plantas_ConFrutos", porcentaje);
                        lblMensaje.Text = "Archivo de 'Filtrado TipoFruto' generado correctamente";

                        this.ListasNulas();
                    }
                    else
                        lblMensaje.Text = "Haga click en 'Filtrar' para generar los resultados";
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
                        lblMensaje.Text = "La planta mas alta es: " + nombreConFruto; 
                        ActualizarDgvConFruto(listaFiltradaConFrutos);
                        break;

                    default:
                        nombreSinFruto = sinFruto.AlturaMaxima();
                        listaFiltradaSinFruto = sinFruto.BuscarPlantaPorNombre(nombreSinFruto);
                        lblMensaje.Text = "La planta mas alta es: " + nombreSinFruto;
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
                    else
                        lblMensaje.Text = "Haga click en 'Filtrar' para generar los resultados";

                    if (listaFiltradaSinFruto != null)
                    {
                        PlantaSinFruto.EscribirTxt(listaFiltradaSinFruto, "Filtrado_AlturaMax_Plantas_SinFrutos");
                        lblMensaje.Text = "Archivo de 'Filtrado AlturaMax' generado correctamente";
                        this.ListasNulas();
                    }
                    else
                        lblMensaje.Text = "Haga click en 'Filtrar' para generar los resultados";
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

        private void btnPorcentajeTipoPlanta_Click(object sender, EventArgs e)
        {
            float resultado = 0;
            if (cmbTipoPlanta.SelectedItem != null)
            {
                resultado = FiltrosGenericos.PorcentajeDeTipoPlanta(listaConFrutos, listaSinFrutos, listaMusgos, cmbTipoPlanta.Text);
                lblMensaje.Text = "El porcentaje de Plantas " + cmbTipoPlanta.SelectedItem.ToString() + " es: " + resultado + "%";
            }
            else
            {
                lblMensaje.Text = "Seleccione un tipo de planta";
            }
        }

        private void btnExportPorcentaje_Click(object sender, EventArgs e)
        {
            float resultado = 0;
            try
            {
                if (cmbTipoPlanta != null)
                {
                        resultado = FiltrosGenericos.PorcentajeDeTipoPlanta(listaConFrutos, listaSinFrutos, listaMusgos, cmbTipoPlanta.Text);
                        switch (cmbTipoPlanta.SelectedItem)
                        {
                            case "Con Fruto":
                                PlantaConFruto.EscribirTxtPorcentaje(listaConFrutos, "Porcentaje_PlantaConFruto", resultado);
                                lblMensaje.Text = "Archivo de 'Porcentaje_PlantaConFruto' generado correctamente";
                                break;

                            case "Sin Fruto":
                                PlantaSinFruto.EscribirTxtPorcentaje(listaSinFrutos, "Porcentaje_PlantaSinFruto", resultado);
                                lblMensaje.Text = "Archivo de 'Porcentaje_PlantaSinFruto' generado correctamente";
                                break;
                            case "Musgo":
                                PlantaMusgo.EscribirTxTPorcentaje(listaMusgos, "Porcentaje_PlantaMusgo", resultado);
                                lblMensaje.Text = "Archivo de 'Porcentaje_PlantaMusgo' generado correctamente";
                                break;
                        }
                }
                else
                {
                    lblMensaje.Text = "Seleccione un tipo de planta";
                }
            }
            catch(EscribirTxtExceptionConFruto)
            {
                EscribirTxtExceptionConFruto ex = new EscribirTxtExceptionConFruto();
                lblMensaje.Text = ex.Message.ToString();
            }
            catch(EscribirTxtExceptionSinFruto)
            {
                EscribirTxtExceptionSinFruto ex = new EscribirTxtExceptionSinFruto();
                lblMensaje.Text = ex.Message.ToString();
            }
            catch(EscribirTxtExceptionMusgo)
            {
                EscribirTxtExceptionMusgo ex = new EscribirTxtExceptionMusgo();
                lblMensaje.Text = ex.Message.ToString();
            }

        }

        /// <summary>
        /// Limpia la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvMostrarConFruto.DataSource = null;
            dgvSinFruto.DataSource = null;
            dgvMusgos.DataSource = null;
            dgvMostrarConFruto.DataSource = listaConFrutos;
            dgvSinFruto.DataSource = listaSinFrutos;
            dgvMusgos.DataSource = listaMusgos;
            lblMensaje.Text = " ";
        }

        /// <summary>
        /// Actualiza el datagridview
        /// </summary>
        /// <param name="lista"></param>
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
        /// <summary>
        /// Pone nulas las listas de filtrado para seguir utilizando
        /// </summary>
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

        
        private void btnReporteFruto_Click(object sender, EventArgs e)
        {
            if(cmbReporteFruto != null && txtAltura.Text != null && Validar.EsNumericaInt(txtAltura.Text))
            {
                // filtro frutos con seleccion
                listaFiltradaConFrutos = PlantaConFruto.FiltrarFruto(listaConFrutos, cmbReporteFruto.Text); 

                //saco el porcentaje de ese fruto por el total
                float porcentajeDeFrutos = PlantaConFruto.PorcentajeDeFrutos(listaFiltradaConFrutos, listaConFrutos, cmbReporteFruto.Text);

                //saco porcentaje de ese fruto con altura seleccionada
                float resultado = PlantaConFruto.PorcentajeReporteFrutoConAltura(listaConFrutos, cmbReporteFruto.Text, float.Parse(txtAltura.Text));

                //retorno la lista de esos frutos con altura
                List<PlantaConFruto> auxLista = PlantaConFruto.ReporteFrutoConAltura(listaConFrutos, cmbReporteFruto.Text, float.Parse(txtAltura.Text));

                if(auxLista is not null && auxLista.Count> 0)
                {
                    int contadorAmerica = 0;
                    int contadorAsia = 0;
                    int contadorEuropa = 0;
                    int contadorNativa = 0;
                    foreach (PlantaConFruto item in auxLista)
                    {
                        switch (item.Origen)
                        {
                            case "America":
                                contadorAmerica++;
                                break;
                            case "Asia":
                                contadorAsia++;
                                break;
                            case "Europa":
                                contadorEuropa++;
                                break;
                            case "Nativa":
                                contadorNativa++;
                                break;
                        }
                    }
                    float porcentajeAmerica = (contadorAmerica * 100) / auxLista.Count();
                    float porcentajeAsia = (contadorAsia * 100) / auxLista.Count();
                    float porcentajeEuropa = (contadorEuropa * 100) / auxLista.Count();
                    float porcentajeNativa = (contadorNativa * 100) / auxLista.Count();

                    lblMensaje.Text = "El " + porcentajeDeFrutos + "% de las plantas posee un tipo de fruto " + cmbReporteFruto.Text + "\n y el " + resultado +
                        "% de esas plantas tiene una altura mayor o igual a " + txtAltura.Text + "m\n" +
                        "El " + porcentajeAmerica + "% son de America.\n" +
                        "El " + porcentajeAsia + "% son de Asia.\n" +
                        "El " + porcentajeEuropa + "% son de Europa.\n" +
                        "El " + porcentajeNativa + "% son Nativas.\n";
                    PlantaConFruto.EscribirTxtReporte(auxLista, "Reporte_Fruto", porcentajeDeFrutos, resultado, porcentajeAmerica, porcentajeAsia, porcentajeNativa, porcentajeEuropa, cmbReporteFruto.Text, float.Parse(txtAltura.Text));
                }
                else
                {
                    lblMensaje.Text = "No se registraron plantas con esos datos";
                }
               

            }
            else
            {
                lblMensaje.Text = "Complete todos los campos por favor";
            }
        }

        private void btnReporteColor_Click(object sender, EventArgs e)
        {
            if (cmbReporteColor != null && txtAgua.Text != null && Validar.EsNumericaInt(txtAgua.Text))
            {

                float resultado = PlantaConFruto.PorcentajeReporteColorAgua(listaConFrutos, cmbReporteColor.Text, float.Parse(txtAgua.Text));

                listaFiltradaConFrutos = PlantaConFruto.FiltrarColorFlor(listaConFrutos, cmbReporteColor.Text);

                float porcentajeDeColorFlor = PlantaConFruto.PorcentajeDeFLor(listaFiltradaConFrutos, listaConFrutos, cmbReporteColor.Text);

                List<PlantaConFruto> auxLista = PlantaConFruto.ReporteColorConAgua(listaConFrutos, cmbReporteColor.Text, float.Parse(txtAgua.Text));

                if (auxLista is not null && auxLista.Count > 0)
                {
                    int contadorAmerica = 0;
                    int contadorAsia = 0;
                    int contadorEuropa = 0;
                    int contadorNativa = 0;
                    foreach (PlantaConFruto item in auxLista)
                    {
                        switch (item.Origen)
                        {
                            case "America":
                                contadorAmerica++;
                                break;
                            case "Asia":
                                contadorAsia++;
                                break;
                            case "Europa":
                                contadorEuropa++;
                                break;
                            case "Nativa":
                                contadorNativa++;
                                break;
                        }
                    }
                    float porcentajeAmerica = (contadorAmerica * 100) / auxLista.Count();
                    float porcentajeAsia = (contadorAsia * 100) / auxLista.Count();
                    float porcentajeEuropa = (contadorEuropa * 100) / auxLista.Count();
                    float porcentajeNativa = (contadorNativa * 100) / auxLista.Count();

                    lblMensaje.Text = "El " + porcentajeDeColorFlor + "% de las plantas poseen flores con color " + cmbReporteColor.Text + "\n y el " + resultado +
                        "% de esas plantas necesita una cantidad de agua mayor o igual a " + txtAgua.Text + "lt.\n" +
                        "El " + porcentajeAmerica + "% son de America.\n" +
                        "El " + porcentajeAsia + "% son de Asia.\n" +
                        "El " + porcentajeEuropa + "% son de Europa.\n" +
                        "El " + porcentajeNativa + "% son Nativas.\n"; ;
                    PlantaConFruto.EscribirTxtReporte(auxLista, "Reporte_Color_Flor", porcentajeDeColorFlor, resultado, porcentajeAmerica, porcentajeAsia, porcentajeNativa, porcentajeEuropa, cmbReporteColor.Text, float.Parse(txtAgua.Text));
                }
            }
            else
            {
                lblMensaje.Text = "Complete todos los campos por favor";
            }
        }
    }
}
