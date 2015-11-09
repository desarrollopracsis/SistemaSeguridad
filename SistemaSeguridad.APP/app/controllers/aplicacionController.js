define(['controllers/controllers', 'services/aplicacionService'],
    function (controllers) {
        controllers.controller('aplicacionController', ['$window', '$scope', '$location', 'aplicacionService',
        function ($window, $scope, $location, aplicacionService) {
            $scope.Aplicaciones = [];
            $scope.init = function () {
                
                obtenerAplicaciones();
            };
            
            function obtenerAplicaciones() {
                
                //block('content-respuesta', 'Cargando Respuestas...');
                var response = aplicacionService.obtenerAplicaciones();
                response.then(
                    function (pl) {
                        $scope.Aplicaciones = pl.data.Aplicaciones;

                        //$.each($scope.Perfiles, function (index, item) {
                        //    $scope.Perfiles.push({
                        //        CodAplicacion: item.CodAplicacion,
                        //        CodPerfil: item.CodPerfil,
                        //        Nombre: item.Nombre
                        //    });
                        //});
                    
                        //$('#content-respuesta').unblock();
                        console.log($scope.Aplicaciones, "$scope.Aplicaciones");
                    },
                    function (errorPl) {
                        //  $('#content-respuesta').unblock();
                       
                    });
            };
        }]);
    });
