(function () {
    "use strict"
    angular
        .module("stops")
        .config(['$routeProvider', function ($routeProvider) {
            $routeProvider.when('/stops/:lineId', {
                templateUrl: 'Scripts/app/stops/stops.html',
                controller: 'StopsCtrl'
            });
        }])
})()
