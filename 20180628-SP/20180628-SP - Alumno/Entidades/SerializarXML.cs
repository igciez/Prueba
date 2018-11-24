using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;


namespace Entidades
{
    public class SerializarXML<T>:IArchivos<T>
    {
        #region Metodos

        public T Leer(string rutaArchivo)
        {
            T aux;
            XmlTextReader reader = null ;   //Objeto que leerá XML.
            XmlSerializer ser;      //Objeto que Deserializará.

            try
            {
                //Se indica ubicación del archivo XML.
                reader = new XmlTextReader(rutaArchivo);
                //Se indica el tipo de objeto ha serializar.
                ser = new XmlSerializer(typeof(T));
                //Deserializa el archivo contenido en reader, lo guarda en aux.
                aux = (T)ser.Deserialize(reader);
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException(e);
            }
            finally
            {
                if(!(reader is null))
                {
                    //Se cierra el objeto reader.
                    reader.Close();
                }                
            }
            return aux;
        }

        public bool Guardar(string rutaArchivo, T objeto)
        {
            
            XmlTextWriter writer=null;  //Objeto que escribirá en XML.
            XmlSerializer ser;     //Objeto que serializará.
            

            try
            {
                //Se indica ubicación del archivo XML y su codificación.
                writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                //Se indica el tipo de objeto ha serializar.
                ser = new XmlSerializer(typeof(T));
                //Serializa el objeto p en el archivo contenido en writer.
                ser.Serialize(writer, objeto);
                //Se cierra la conexión al archivo                
            }
            catch (Exception e)
            {
                throw new ErrorArchivoException(e);
            }
            finally
            {
                if (!(writer is null))
                {
                    writer.Close();
                }
            }
            return true;
        }

        #endregion
    }
}
