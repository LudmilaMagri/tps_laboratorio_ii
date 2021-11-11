using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class Conexion_DB
    {
        //static SqlConnection conexion; // se conecta a la instancia sql
        //static SqlCommand comando; // llevar la consulta
        //static SqlDataReader leer; // devuelve datos

        //static Conexion_DB()
        //{
        // //   conexion = new SqlConnection("Server=PC-LUDMILA\SQLEXPRESS;Database=NOMBRE DE LA BASE DE DATOS;Trusted_Connection=True;"); //abre conexion y a que server ir
        //    comando = new SqlCommand();
        //    comando.CommandType = System.Data.CommandType.Text;
        //    comando.Connection = conexion; // el comando va a esa conexion

        //}

        //public static List<string> TraerDatos()
        //{
        //    //me trae ingo de la tabla de datos
        //    try
        //    {
        //        List<string> auxLista = new List<string>();
        //        comando.CommandText = "Select nombre from dbo.table where id < 100"; // POR EJEMPLO. y ahi me hago los filtros
        //        if (conexion.State != System.Data.ConnectionState.Open)
        //        {
        //            conexion.Open();
        //        }
        //        leer = comando.ExecuteReader();
              

        //        while (leer.Read())
        //        {
        //            //va leyendo uno por uno
        //            auxLista.Add(leer[0].ToString());
        //            // 0    1       2       3
        //            // id   dirc    nombre  apellido
        //        }
        //        //  conexion.Close();
        //        return auxLista;
        //    }
        //    catch(Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
           
        //}
        ////  comando.EndExecuteNonQuery --> no nos trae info, es para insertar
        //public static void Insertar( string nombre, string direccion)
        //{
        //    try
        //    {
        //        List<string> auxLista = new List<string>();
        //        comando.CommandText = $"Insert into Usuarios values (@Nombre, @Direccion)";
        //        comando.Parameters.Clear();
        //        comando.Parameters.AddWithValue("@Nombre", nombre);
        //        comando.Parameters.AddWithValue("@Direccion", direccion);

        //        if (conexion.State != System.Data.ConnectionState.Open)
        //        {
        //            conexion.Open();
        //        }

        //        comando.ExecuteNonQuery();


        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
        //}


    }
}
