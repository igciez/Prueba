using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class Dao :IArchivos<Votacion> 
    {
        #region Metodos

        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException("Error Not Implemented Exception");
        }

        public bool Guardar(string rutaArchivo, Votacion objeto)
        {
            String connectionStr = "Data Source=[USER-HP/SQLEXPRESS];" +
                "Initial Catalog =[votacion-sp-2018]; Integrated Security = True";
            String consulta;
            SqlConnection conexion=null;
            SqlCommand comando;

            try
            {
                conexion = new SqlConnection(connectionStr);
                comando = new SqlCommand();

                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;

                consulta = string.Format("INSERT INTO Votaciones (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno)  " +
                    "VALUES('{0}','{1}','{2}','{3}','{4}')", objeto.NombreLey, objeto.ContadorAfirmativo, objeto.ContadorNegativo, objeto.ContadorAbstencion, objeto.Senadores);

                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                if (!(conexion is null))
                {
                    conexion.Close();
                }                
            }
            return true;         
        }

        #endregion
    }
}
