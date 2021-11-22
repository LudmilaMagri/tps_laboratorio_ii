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
        static SqlConnection conexion; 
        static SqlCommand comando; 
        static SqlDataReader reader; 

        static Conexion_DB()
        {
            conexion = new SqlConnection(Archivos<string>.LeerXmlSqlConnection("SqlConnection")); 
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text; 
            comando.Connection = conexion; 
        }

        /// <summary>
        /// Selecciona todas las plantas de la tabla y las retorna en una lista
        /// </summary>
        /// <returns></returns>
        public static List<PlantaConFruto> TraerPlantaConFruto()
        {
            try
            {
                List<PlantaConFruto> auxLista = new List<PlantaConFruto>();
                comando.CommandText = "Select * from dbo.Planta_Con_Fruto";
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    PlantaConFruto p = new PlantaConFruto(reader["Nombre"].ToString(),
                            reader["Familia"].ToString(),
                            reader["Origen"].ToString(),
                            int.Parse(reader["Anios_De_Vida"].ToString()),
                            float.Parse(reader["Cantidad_De_Agua"].ToString()),
                            reader["Fruto"].ToString(),
                            float.Parse(reader["Altura"].ToString()));
                            
                    p.Id = int.Parse(reader["Id"].ToString());

                    if (int.Parse(reader["Color_Flor"].ToString()) == 0)
                    {
                        p.ColorFlor = PlantaConFruto.EColorFlor.roja;
                    }
                    else if (int.Parse(reader["Color_Flor"].ToString()) == 1)
                    {
                        p.ColorFlor = PlantaConFruto.EColorFlor.amarilla;
                    }
                    else if (int.Parse(reader["Color_Flor"].ToString()) == 2)
                    {
                        p.ColorFlor = PlantaConFruto.EColorFlor.rosa;
                    }
                    auxLista.Add(p);
                }
                return auxLista;
            }
            catch (Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }

        /// <summary>
        /// Inserta en la tabla la planta pasada por parametro
        /// </summary>
        /// <param name="planta"></param>
        public static void AgregarPlantaConFruto(PlantaConFruto planta)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = $"INSERT INTO dbo.Planta_Con_Fruto " +
                    $"VALUES(@Nombre, @Familia, @Origen, @Anios_De_Vida, @Cantidad_De_Agua, @Color_Flor, @Fruto, @Altura)";
                
                comando.Parameters.AddWithValue("@Nombre", planta.Nombre);
                comando.Parameters.AddWithValue("@Familia", planta.Familia);
                comando.Parameters.AddWithValue("@Origen", planta.Origen);
                comando.Parameters.AddWithValue("@Anios_De_Vida", planta.AniosVida);
                comando.Parameters.AddWithValue("@Cantidad_De_Agua", planta.CantidadAgua);
                comando.Parameters.AddWithValue("@Color_Flor", planta.ColorFlor);
                comando.Parameters.AddWithValue("@Fruto", planta.Fruto);
                comando.Parameters.AddWithValue("@Altura", planta.Altura);

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }

        /// <summary>
        /// Actualiza una fila de la tabla mediante el id pasado por parametro
        /// </summary>
        /// <param name="planta"></param>
        /// <param name="id"></param>
        public static void GuardarPlantaConFruto(PlantaConFruto planta, int id)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = $"UPDATE dbo.Planta_Con_Fruto SET Nombre = @Nombre, Familia = @Familia, Origen= @Origen, Anios_De_Vida = @Anios_De_Vida, Cantidad_De_Agua = @Cantidad_De_Agua, Color_Flor = @Color_Flor, Fruto = @Fruto, Altura = @Altura WHERE Id = @Id";

                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@Nombre", planta.Nombre);
                comando.Parameters.AddWithValue("@Familia", planta.Familia);
                comando.Parameters.AddWithValue("@Origen", planta.Origen);
                comando.Parameters.AddWithValue("@Anios_De_Vida", planta.AniosVida);
                comando.Parameters.AddWithValue("@Cantidad_De_Agua", planta.CantidadAgua);
                comando.Parameters.AddWithValue("@Color_Flor", planta.ColorFlor);
                comando.Parameters.AddWithValue("@Fruto", planta.Fruto);
                comando.Parameters.AddWithValue("@Altura", planta.Altura);
                

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }

        /// <summary>
        /// Elimina una fila de la tabla mediante el id pasado por parametro
        /// </summary>
        /// <param name="id"></param>
        public static void EliminarPlantaConFruto(int id)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = $"DELETE FROM dbo.Planta_Con_Fruto WHERE Id = @Id";
                comando.Parameters.AddWithValue("@Id", id);

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }

        /// <summary>
        /// Selecciona todas las plantas de la tabla y las retorna en una lista
        /// </summary>
        /// <returns></returns>
        public static List<PlantaSinFruto> TraerPlantaSinFruto()
        {
            try
            {
                List<PlantaSinFruto> auxLista = new List<PlantaSinFruto>();
                comando.CommandText = "Select * from dbo.Planta_Sin_Fruto";
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    PlantaSinFruto p = new PlantaSinFruto(reader["Nombre"].ToString(),
                                        reader["Familia"].ToString(),
                                        reader["Origen"].ToString(),
                                        int.Parse(reader["Anios_De_Vida"].ToString()),
                                        float.Parse(reader["Cantidad_De_Agua"].ToString()),
                                        float.Parse(reader["Altura"].ToString()));

                    p.Id = int.Parse(reader["Id"].ToString());

                    if (int.Parse(reader["Tipo_De_Planta"].ToString()) == 0)
                    {
                        p.TipoPlanta = PlantaSinFruto.ETipoPlanta.Arbol;
                    }
                    else if (int.Parse(reader["Tipo_De_Planta"].ToString()) == 1)
                    {
                        p.TipoPlanta = PlantaSinFruto.ETipoPlanta.Arbusto;
                    }

                    auxLista.Add(p);
                }
                return auxLista;
            }
            catch (Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }

        /// <summary>
        /// Inserta en la tabla la planta pasada por parametro
        /// </summary>
        /// <param name="planta"></param>
        public static void AgregarPlantaSinFruto(PlantaSinFruto planta)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = $"INSERT INTO dbo.Planta_Sin_Fruto " +
                    $"VALUES(@Nombre, @Familia, @Origen, @Anios_De_Vida, @Cantidad_De_Agua, @Tipo_De_Planta, @Altura)";

                comando.Parameters.AddWithValue("@Nombre", planta.Nombre);
                comando.Parameters.AddWithValue("@Familia", planta.Familia);
                comando.Parameters.AddWithValue("@Origen", planta.Origen);
                comando.Parameters.AddWithValue("@Anios_De_Vida", planta.AniosVida);
                comando.Parameters.AddWithValue("@Cantidad_De_Agua", planta.CantidadAgua);
                comando.Parameters.AddWithValue("@Tipo_De_Planta", planta.TipoPlanta);
                comando.Parameters.AddWithValue("@Altura", planta.Altura);

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }

        /// <summary>
        /// Actualiza una fila de la tabla mediante el id pasado por parametro
        /// </summary>
        /// <param name="planta"></param>
        /// <param name="id"></param>
        public static void GuardarPlantaSinFruto(PlantaSinFruto planta, int id)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = $"UPDATE dbo.Planta_Sin_Fruto SET Nombre = @Nombre, Familia = @Familia, Origen= @Origen, Anios_De_Vida = @Anios_De_Vida, Cantidad_De_Agua = @Cantidad_De_Agua, Tipo_De_Planta = @Tipo_De_Planta, Altura = @Altura WHERE Id = @Id";

                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@Nombre", planta.Nombre);
                comando.Parameters.AddWithValue("@Familia", planta.Familia);
                comando.Parameters.AddWithValue("@Origen", planta.Origen);
                comando.Parameters.AddWithValue("@Anios_De_Vida", planta.AniosVida);
                comando.Parameters.AddWithValue("@Cantidad_De_Agua", planta.CantidadAgua);
                comando.Parameters.AddWithValue("@Tipo_De_Planta", planta.TipoPlanta);
                comando.Parameters.AddWithValue("@Altura", planta.Altura);

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }


        /// <summary>
        /// Elimina una fila de la tabla mediante el id pasado por parametro
        /// </summary>
        /// <param name="id"></param>
        public static void EliminarPlantaSinFruto(int id)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = $"DELETE FROM dbo.Planta_Sin_Fruto WHERE Id = @Id";
                comando.Parameters.AddWithValue("@Id", id);

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }

        /// <summary>
        /// Selecciona todas las plantas de la tabla y las retorna en una lista
        /// </summary>
        /// <returns></returns>
        public static List<PlantaMusgo> TraerPlantaMusgo()
        {
            try
            {
                List<PlantaMusgo> auxLista = new List<PlantaMusgo>();
                comando.CommandText = "Select * from dbo.Planta_Musgo";
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    PlantaMusgo p = new PlantaMusgo(reader["Nombre"].ToString(),
                                    reader["Familia"].ToString(),
                                    reader["Origen"].ToString(),
                                    int.Parse(reader["Anios_De_Vida"].ToString()),
                                    float.Parse(reader["Cantidad_De_Agua"].ToString()));

                    p.Id = int.Parse(reader["Id"].ToString());
                    p.CantidadEsporas = int.Parse(reader["Cantidad_De_Esporas"].ToString());
                    auxLista.Add(p);
                }
                return auxLista;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
            finally { conexion.Close(); }
        }

        /// <summary>
        /// Inserta en la tabla la planta pasada por parametro
        /// </summary>
        /// <param name="planta"></param>
        public static void AgregarPlantaMusgo(PlantaMusgo planta)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = $"INSERT INTO dbo.Planta_Musgo " +
                    $"VALUES(@Nombre, @Familia, @Origen, @Anios_De_Vida, @Cantidad_De_Agua, @Cantidad_De_Esporas)";

                comando.Parameters.AddWithValue("@Nombre", planta.Nombre);
                comando.Parameters.AddWithValue("@Familia", planta.Familia);
                comando.Parameters.AddWithValue("@Origen", planta.Origen);
                comando.Parameters.AddWithValue("@Anios_De_Vida", planta.AniosVida);
                comando.Parameters.AddWithValue("@Cantidad_De_Agua", planta.CantidadAgua);
                comando.Parameters.AddWithValue("@Cantidad_De_Esporas", planta.CantidadEsporas);

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }

        /// <summary>
        /// Actualiza una fila de la tabla mediante el id pasado por parametro
        /// </summary>
        /// <param name="planta"></param>
        /// <param name="id"></param>
        public static void GuardarPlantaMusgo(PlantaMusgo planta, int id)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = $"UPDATE dbo.Planta_Musgo SET Nombre = @Nombre, Familia = @Familia, Origen= @Origen, Anios_De_Vida = @Anios_De_Vida, Cantidad_De_Agua = @Cantidad_De_Agua, Cantidad_De_Esporas = @Cantidad_De_Esporas WHERE Id = @Id";

                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@Nombre", planta.Nombre);
                comando.Parameters.AddWithValue("@Familia", planta.Familia);
                comando.Parameters.AddWithValue("@Origen", planta.Origen);
                comando.Parameters.AddWithValue("@Anios_De_Vida", planta.AniosVida);
                comando.Parameters.AddWithValue("@Cantidad_De_Agua", planta.CantidadAgua);
                comando.Parameters.AddWithValue("@Cantidad_De_Esporas", planta.CantidadEsporas);

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }


        /// <summary>
        /// Elimina una fila de la tabla mediante el id pasado por parametro
        /// </summary>
        /// <param name="id"></param>
        public static void EliminarPlantaMusgo(int id)
        {
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = $"DELETE FROM dbo.Planta_Musgo WHERE Id = @Id";
                comando.Parameters.AddWithValue("@Id", id);

                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conexion.Close(); }
        }

    }
}
