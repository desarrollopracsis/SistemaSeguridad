define(['services/services'],
  function (services) {
      services.factory('usuariosServices', function ($http) {
          return {
              ObtenerUsuarios: function () {
                  return $http.get("/Usuarios/ObtenerUsuarios");
              }

          };
      });
  });

