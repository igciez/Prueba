using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorArchivoException:Exception
    {
        #region Constructores

        public ErrorArchivoException(Exception e):base("Error en el Archivo",e){ }

        #endregion
    }
}
