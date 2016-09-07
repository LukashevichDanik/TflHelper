(function () {
    "use strict"
    angular
        .module("journey")
        .config(['$routeProvider', function ($routeProvider) {
            $routeProvider.when('/journey', {
                templateUrl: 'Scripts/app/journey/journey.html',
                controller: 'JourneyCtrl'
            });
        }])
})()
