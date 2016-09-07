(function () {
    "use strict"
    angular
        .module("index")
        .config(['$routeProvider', function ($routeProvider) {
            $routeProvider.when('/index', {
                templateUrl: 'Scripts/app/index/index.html',
                controller: 'IndexCtrl'
            });
        }])
})()
