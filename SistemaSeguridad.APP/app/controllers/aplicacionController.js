define(['controllers/controllers', 'services/aplicacionService'],
    function (controllers) {
        controllers.controller('aplicacionController', ['$window', '$scope', '$location', 'aplicacionService',
        function ($window, $scope, $location, aplicacionService) {
            $scope.Aplicaciones = [];
            $scope.TiposAplicaciones = [];
            $scope.TipoAplicacion = $scope.TiposAplicaciones[1];
            $scope.codigo = "";
            $scope.criterioBusqueda = "";

            $scope.Aplicacion = {
                CodAplicacion: 0,
                Nombre: '',
                FechaCreacion: '',
                FechaImplementacion: '',
                CodTipoAplicacion: 0
            }




            $scope.init = function () {

                ObtenerAplicaciones();

                $('#FechaCreacion').datepicker({
                    format: 'dd/mm/yyyy',
                    startDate: '-3d'
                })

                $('#FechaImplementacion').datepicker({
                    format: 'dd/mm/yyyy',
                    startDate: '-3d'
                })

            };

            $scope.Buscar = function () {
                ObtenerAplicaciones();
            }

            $scope.Refrescar = function () {
                ObtenerAplicaciones();
            };

            $scope.InsertarModificarAplicacion = function () {
                InsertarModificarAplicacion();
            };

            $scope.LimpiarModal = function () {
                LimpiarModal();
            };



            $scope.CargarParaEditar = function (CodTipoAplicacion) {
                var response = aplicacionService.ObtenerAplicacionPorCod(CodTipoAplicacion);
                response.then(
                    function (ap) {
                        $scope.Aplicacion = ap.data.Aplicacion;
                    }
                );

                $('#ModalAplicacion').modal('show');

            };

            $scope.EliminarAplicacion = function (aplicacion) {
                var response = aplicacionService.EliminarAplicacion(aplicacion);
                response.then(
                    function (a){
                        if (a.data.Estado) {
                            alert(a.data.Mensaje);
                            ObtenerAplicaciones();
                        }
                        else {
                            alert(a.data.Mensaje + " Error: "+a.data.Mensaje);
                        }
                    }
                );
            };


            function ObtenerAplicaciones() {

                //block('content-respuesta', 'Cargando Respuestas...');
                var response = aplicacionService.ObtenerAplicaciones($scope.criterioBusqueda);
                response.then(
                    function (pl) {
                        $scope.Aplicaciones = pl.data.Aplicaciones;
                        $scope.TiposAplicaciones = pl.data.TiposAplicaciones;

                        //$('#content-respuesta').unblock();
                    },
                    function (errorPl) {
                        //  $('#content-respuesta').unblock();

                    });
            };


            function InsertarModificarAplicacion() {

                console.log($scope.Aplicacion.CodAplicacion);

                if ($scope.Aplicacion.CodAplicacion === undefined || $scope.Aplicacion.CodAplicacion == 0) {
                    var response = aplicacionService.InsertarAplicacion($scope.Aplicacion);
                    response.then(
                        function (pl) {

                            if (pl.data.Estado) {
                                //mostrarMensaje(pl.data.Mensaje, 'success
                                alert(pl.data.Mensaje);
                                $scope.Aplicacion.CodAplicacion = pl.data.Codigo;
                                //t.Visible = false;
                                $('#ModalAplicacion').modal('hide');
                                ObtenerAplicaciones();
                                LimpiarModal();

                            } else {
                                // mostrarMensaje(pl.data.Mensaje, 'error');
                                alert(pl.data.Mensaje + " Error: " + pl.data.Mensaje);
                            }

                        }
                    )
                }
                else {
                    var response = aplicacionService.ModificarAplicacion($scope.Aplicacion);
                    response.then(
                        function (pl) {

                            if (pl.data.Estado) {
                                alert(pl.data.Mensaje);
                                $scope.Aplicacion.CodAplicacion = pl.data.Codigo;
                                //t.Visible = false;
                                $('#ModalAplicacion').modal('hide');
                                ObtenerAplicaciones();
                                LimpiarModal();

                            } else {
                                // mostrarMensaje(pl.data.Mensaje, 'error');
                                alert(pl.data.Mensaje + " Error: " + pl.data.Mensaje);
                            }

                        }
                    )
                }

            };


            function LimpiarModal() {
                $scope.Aplicacion.CodAplicacion = '',
                $scope.Aplicacion.Nombre = '',
                $scope.Aplicacion.FechaCreacion = '',
                $scope.Aplicacion.FechaImplementacion = '',
                $scope.Aplicacion.CodTipoAplicacion = 0

            }



        }]);

    });
