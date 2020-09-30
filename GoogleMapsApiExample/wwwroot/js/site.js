// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function initMap() {
    var centerLoc = { lat: 52.489471, lng: -1.898575 }; // Birmingham UK
    var map = new google.maps.Map(document.getElementById("map"), {
        zoom: 6,
        center: centerLoc
    });    

    if (typeof mapLocations !== "undefined") {
        var infowindow = new google.maps.InfoWindow();

        var marker, i;

        for (i = 0; i < mapLocations.length; i++) {
            marker = new google.maps.Marker({
                position: new google.maps.LatLng(mapLocations[i][1], mapLocations[i][2]),
                map: map
            });

            google.maps.event.addListener(marker, 'click', (function (marker, i) {
                return function () {
                    infowindow.setContent(mapLocations[i][0]);
                    infowindow.open(map, marker);
                }
            })(marker, i));
        }
    }
}