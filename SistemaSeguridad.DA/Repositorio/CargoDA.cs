using SistemaSeguridad.BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaSeguridad.DA.Repositorio
{
   public class CargoDA
    {
        bdSecurityEntities obdSecurityEntities = new bdSecurityEntities();
        public List<CargosBE> ObtenerCargos()
        {

            var consulta = from t1 in obdSecurityEntities.tbCargos
                           select new
                           {
                               t1.CodCargo,
                               t1.Nombre
                           };
            return consulta.Select(i => new CargosBE()
            {
                CodCargo = i.CodCargo,
                Nombre = i.Nombre
            }).ToList();
        }

    }
}
