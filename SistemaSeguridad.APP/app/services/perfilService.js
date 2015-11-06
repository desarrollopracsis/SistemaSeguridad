define(['services/services'],
  function (services) {
      services.factory('perfilService', function ($http) {
          return {
              obtenerPerfiles: function () {
                  return $http.get("/Perfiles/ObtenerPerfiles");
              }
           
          };
      });
  });

