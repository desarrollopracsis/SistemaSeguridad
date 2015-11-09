define(['services/services'],
  function (services) {
      services.factory('aplicacionService', function ($http) {
          return {
              obtenerAplicaciones: function () {
                  return $http.get("/Aplicaciones/ObtenerAplicaciones");
              }
           
          };
      });
  });

