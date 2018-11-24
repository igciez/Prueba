using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Entidades;

namespace TestExamen
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCompruebaError_Votacion()
        {
            // 10.1.Realizar un test que compruebe que si hay un error
            //al querer serializar un objeto del tipo Votacion lance la excepción ErrorArchivoException.

            SerializarXML<Votacion> serializar;
            Votacion votacion;
            

            votacion = new Votacion();
            
            serializar = new SerializarXML<Votacion>();
            serializar.Guardar("Votacion.xml", votacion);

           // Assert.(serializar,ErrorArchivoException);


        }
    }
}
