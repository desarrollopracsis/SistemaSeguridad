define(['controllers/controllers', 'services/perfilService'],
    function (controllers) {
        controllers.controller('perfilController', ['$window', '$scope', '$location', 'perfilService',
        function ($window, $scope, $location, perfilService) {
            $scope.Perfiles = [];
            $scope.init = function () {
                
                obtenerPerfiles();
            };
            
            function obtenerPerfiles() {
                
                //block('content-respuesta', 'Cargando Respuestas...');
                var response = perfilService.obtenerPerfiles();
                response.then(
                    function (pl) {
                        $scope.Perfiles = pl.data.Perfiles;

                        //$.each($scope.Perfiles, function (index, item) {
                        //    $scope.Perfiles.push({
                        //        CodAplicacion: item.CodAplicacion,
                        //        CodPerfil: item.CodPerfil,
                        //        Nombre: item.Nombre
                        //    });
                        //});
                    
                        //$('#content-respuesta').unblock();
                        console.log($scope.Perfiles, "$scope.Perfiles");
                    },
                    function (errorPl) {
                        //  $('#content-respuesta').unblock();
                       
                    });
            };
        }]);
    });
