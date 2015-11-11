using SistemaSeguridad.BE;
using SistemaSeguridad.DA.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.BL
{
   public class CargosBL
    {
       CargoDA oCargosDA = new CargoDA();
       public List<CargosBE> ObtenerCargos()
        {
            return oCargosDA.ObtenerCargos();
        }
    }
}
