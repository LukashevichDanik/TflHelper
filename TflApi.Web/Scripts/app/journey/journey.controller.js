/**
 * Created by Даник on 02.09.2016.
 */
(function () {
    "use strict"
    angular.module("journey")
        .controller("JourneyCtrl", ["$http", "$scope", JourneyCtrl]);

    function JourneyCtrl($http, $scope) {
        var map = new google.maps.Map(document.getElementById('map'), {
            zoom: 16,
            center: { lat: 51.49514, lng: -0.1016 }
        });
        var vm = this;
        var markers = [];
        var points = [];
        var poliLine = [];
        

        $scope.work = false;
        
        vm.array = {};
        vm.clearMap = function () {
            for (var i = 0; i < markers.length; i++) {
                markers[i].setMap(null);
            }
            for (var j = 0; j < poliLine.length; j++)
                poliLine[j].setMap(null);
            markers = [];
            points = [];
            poliLine = [];
        }
        vm.getResult = function () {
            if (points.length == 2)
                get(points[0], points[1]);
            else
                alert("Please add one more point.")
        };

        map.addListener('click', addLatLng);
        function addLatLng(event) {
            var string = event.latLng.lat() + ',' + event.latLng.lng();
            if (points.length >= 2) {
                points.pop();
                var m = markers.pop();
                m.setMap(null);
                var marker = new google.maps.Marker({
                    position: event.latLng
                });
                points.push(string);
                markers.push(marker);
                marker.setMap(map);
            }
            else {
                var marker = new google.maps.Marker({
                    position: event.latLng,
                    map: map
                });
                points.push(string);
                markers.push(marker);
                marker.setMap(map);
            }
        };
        
        var get = function (from, to) {
            $scope.work = true;
            $http.post('api/journey', {
                from: from,
                to: to
            }).success(function (response) {
                vm.array = response;
                if (vm.array) {
                    for (var j = 0; j < poliLine.length; j++)
                        poliLine[j].setMap(null);
                    poliLine = [];
                    for (var i = 0; i < vm.array.Journeys.length; i++) {
                        var model = vm.array.Journeys[i];
                        for (var i1 = 0; i1 < model.Legs.length; i1++) {
                            var string = model.Legs[i1].Path.LineString || "";
                            var parsedJSON = JSON.parse(string);
                            var polyOptions = {
                                strokeColor: "red",
                                strokeOpacity: 0.8,
                                strokeWeight: 5,
                                icons: [{
                                    offset: '10%',
                                    repeat: '200px'
                                }]
                            };
                            var poly = new google.maps.Polyline(polyOptions);
                            poly.setMap(map);
                            poliLine.push(poly);
                            var path = poly.getPath();
                            for (var i2 = 0; i2 < parsedJSON.length; i2++) {
                                path.push(new google.maps.LatLng(parsedJSON[i2][0], parsedJSON[i2][1]));
                            }
                        }
                    }
                }
                else {
                    alert("Impossible to build a route.");
                }
                $scope.work = false;
            })
              .error(function (response) {
                    alert("Server errror.");
                    $scope.work = false;
                });
        };
    }
})();
