require.config({
    paths: {
        angular: 'vendor/angular.min',
        domReady: 'vendor/domReady',
        // uiBootstrap: 'vendor/ui-bootstrap-tpls-0.13.0.min'
        //datetimepicker: 'vendor/datetimepicker'
    },
    priority: ['angular'],
    shim: {
        angular: {
            deps: [],
            exports: 'angular'
        },

    },
    //'uiBootstrap': {
    //    deps: ['angular']
    //},
});

require([
  'angular',
  'app',
  'domReady',
  'services/perfilService',
  'controllers/perfilController',
  'services/aplicacionService',
  'controllers/aplicacionController',
  'services/usuariosServices',
  'controllers/usuariosController',
],
function (angular, app, domReady) {
    'use strict';
    domReady(function () {
        angular.bootstrap(document, ['seguridaddtv']);
        $('html').addClass('ng-app: seguridaddtv');
    });
}
);
