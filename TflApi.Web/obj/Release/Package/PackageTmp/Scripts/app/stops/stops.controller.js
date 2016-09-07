(function () {
    "use strict"
    angular.module("stops")
        .controller("StopsCtrl", ["$http", "$routeParams", "$scope", StopsCtrl]);

    function StopsCtrl($http, $routeParams, $scope) {
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 16,
            center: { lat: 51.49514, lng: -0.1016 }
        });
        var vm = this;

        $scope.work = false;
        $scope.currentPage = 0;
        $scope.currentCount = 50;
        $scope.routeNumber = $routeParams.lineId;
        $scope.countPage = [];
      
        vm.array = {};
        vm.pageArray = [];
        vm.changeArray = function (from) {
            $scope.currentPage = from;
        }

        var getArray = function () {
            var array = [];
            if (vm.array.length > $scope.currentPage * $scope.currentCount + $scope.currentCount)
                for (var i = $scope.currentPage * $scope.currentCount; i < $scope.currentPage * $scope.currentCount + $scope.currentCount; i++) {
                    array.push(vm.array[i]);
                }
            else
                for (var i = $scope.currentPage * $scope.currentCount; i < vm.array.length; i++) {
                    array.push(vm.array[i]);
                }
            return array;
        }
        var get = function () {
            $scope.work = true;
            $http({
                method: 'GET',
                url: '/api/stops/' + $routeParams.lineId
            })
                .success(function (response) {
                    vm.array = response;
                    vm.pageArray = getArray();
                    if(vm.array.length>0)
                        map.setCenter(new google.maps.LatLng(vm.array[0].lat, vm.array[0].lon));
                    for (var i = 0; i < vm.array.length; i++) {
                        var marker = new google.maps.Marker({
                            position: new google.maps.LatLng(vm.array[i].lat, vm.array[i].lon),
                            icon: {
                                path: google.maps.SymbolPath.CIRCLE,
                                scale: 5,
                                fillColor: "red"
                            },
                            map: map,
                            title: vm.array[i].commonName
                        });
                    }
                    $scope.work = false;
                })
                .error(function (response) {
                    alert("Server error.");
                    $scope.work = false;
                });
        };
        
        $scope.$watch(function () { return $scope.currentPage }, function () {
            vm.pageArray = getArray();
        })
        $scope.$watch(function () { return vm.array.length }, function () {
            if (vm.array.length > 0) {
                if (vm.array.length % $scope.currentCount != 0)
                    $scope.countPage = new Array(parseInt(vm.array.length / $scope.currentCount + 1));
                else
                    $scope.countPage = new Array(parseInt(vm.array.length / $scope.currentCount));
            }
        });

        get();
    }
})();
