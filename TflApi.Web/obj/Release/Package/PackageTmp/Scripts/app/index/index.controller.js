/**
 * Created by Даник on 02.09.2016.
 */
(function () {
    "use strict"
    angular.module("index")
        .controller("IndexCtrl", ["$http", "$scope", IndexCtrl]);

    function IndexCtrl($http, $scope) {
        var vm = this;
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
            $scope.works = true;
            $http({
                method: 'GET',
                url: '/api/index'
            })
                .success(function (response) {
                    vm.array = response;
                    vm.pageArray = getArray();
                    $scope.works = false;
                })
                .error(function (response) {
                    alert("Server error.");
                    $scope.works = false;
                });
        };


        $scope.works = false;
        $scope.currentPage = 0;
        $scope.currentCount = 50;
        $scope.countPage = [];


        vm.array = {};
        vm.pageArray = [];
        vm.changeArray = function (from) {
            $scope.currentPage = from;
        }
            
   
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
        })


        get();
    }
})();
