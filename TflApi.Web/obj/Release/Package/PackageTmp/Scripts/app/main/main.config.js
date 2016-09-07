/**
 * Created by Даник on 02.09.2016.
 */
(function () {
    "use strict"
    angular
        .module("app")
        .config(['$routeProvider', "$locationProvider", function ($routeProvider, $locationProvider) {
            $routeProvider
                .otherwise({
                    redirectTo: '/index'
                });
            $locationProvider.html5Mode({
                enabled: true,
                requireBase: false
            });
        }])
})();
