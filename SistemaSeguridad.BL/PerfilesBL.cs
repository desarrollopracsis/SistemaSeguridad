using SistemaSeguridad.BE;
using SistemaSeguridad.DA.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace SistemaSeguridad.BL
{
   public class PerfilesBL
    {
       PerfilesDA oPerfilesDA = new PerfilesDA();
       public List<PerfilesBE> ObtenerPerfiles()
       {
           return oPerfilesDA.ObtenerPerfiles();
       }
    }
}
