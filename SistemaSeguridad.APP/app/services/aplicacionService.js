define(['services/services'],
  function (services) {
      services.factory('aplicacionService', function ($http) {
          return {
              ObtenerAplicaciones: function (criterioBusqueda) {
                  return $http.get("/Aplicaciones/ObtenerAplicaciones?criterioBusqueda=" + criterioBusqueda);
              },
              ObtenerAplicacionPorCod: function (CodAplicacion) {
                  return $http.get("/Aplicaciones/ObtenerAplicacionPorCod?nCodAplicacion=" + CodAplicacion);
              },
              InsertarAplicacion: function (aplicacion) {
                  return $http.post("/Aplicaciones/InsertarAplicacion/", {AplicacionesBE : aplicacion});
              },
              ModificarAplicacion: function (aplicacion) {
                  return $http.post("/Aplicaciones/ModificarAplicacion" , {AplicacionesBE : aplicacion} );
              },
              EliminarAplicacion: function (aplicacion) {
                  return $http.post("/Aplicaciones/EliminarAplicacion", { AplicacionesBE: aplicacion });
          }
          };
      });
  });

