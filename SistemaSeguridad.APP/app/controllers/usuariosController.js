define(['controllers/controllers', 'services/usuariosServices'],
    function (controllers) {
        controllers.controller('usuariosController', ['$window', '$scope', '$location', 'usuariosServices',
        function ($window, $scope, $location, usuariosServices) {
            $scope.Usuarios = [];
            $scope.Cargos = [];
            console.log("CC");
            $scope.init = function () {
                
                function Tabla() {
                    $('#dataTables-example').dataTable();
                }
               
                ObtenerUsuarios();
            };


            $scope.NuevoUsuario = function () {
                window.location.assign("/Usuarios/Registro");
            };


            $scope.regresar = function () {
                //$('#dialog-Registro').modal();
                console.log("Entro");
                window.location.assign("/Usuarios/Index");
            };

            function ObtenerUsuarios() {
               
                //block('content-respuesta', 'Cargando Respuestas...');
                var response = usuariosServices.ObtenerUsuarios();
                response.then(
                    function (pl) {
                        $scope.Usuarios = pl.data.Usuarios;
                        $scope.Cargos = pl.data.Cargos;

                        //$.each($scope.Perfiles, function (index, item) {
                        //    $scope.Perfiles.push({
                        //        CodAplicacion: item.CodAplicacion,
                        //        CodPerfil: item.CodPerfil,
                        //        Nombre: item.Nombre
                        //    });
                        //});

                        //$('#content-respuesta').unblock();
                        console.log($scope.Usuarios, "$scope.Aplicaciones");
                    },
                    function (errorPl) {
                        //  $('#content-respuesta').unblock();

                    });
            };
        }]);
    });
