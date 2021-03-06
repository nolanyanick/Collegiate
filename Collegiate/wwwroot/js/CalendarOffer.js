﻿var date;
var listOfOffers = [];

// event handler to display data in modal content on modal open
$('#OffersModal').on('show.bs.modal', function (event) {

    // get and reset the text of the modal body
    $('#offersTable').find("#offersTableBody").text("");

    // get the date selected by the user
    date = $(event.relatedTarget).data('date');

    // reset list of offers to be displayed
    listOfOffers = [];

    // get all offers that correspond to the date selected by the user
    offers.forEach(getOffers);

    // display the offers
    listOfOffers.forEach(showOffer);
});

// function to get list of offers for a given day
function getOffers(item, index) {

    var dateInMiliseconds = Date.parse(date);
    var currentDate = new Date(dateInMiliseconds);

    if (item.toNMC == true) {
        var arrivalTimeMsec = Date.parse(item.arrivalTime);
        var currentArrivalTime = new Date(arrivalTimeMsec);

        currentDate.setHours(0, 0, 0, 0);
        currentArrivalTime.setHours(0, 0, 0, 0);

        if (currentArrivalTime.getTime() == currentDate.getTime()) {
            listOfOffers.push(item);
        }
    }
    else {
        var departureTimeMsec = Date.parse(item.departureTime);
        var currentDepartureTime = new Date(departureTimeMsec);

        currentDate.setHours(0, 0, 0, 0);
        currentDepartureTime.setHours(0, 0, 0, 0);

        if (currentDepartureTime.getTime() == currentDate.getTime()) {
            listOfOffers.push(item);
        }
    }
}

// function to display offer for a given day in modal content
function showOffer(item, index) {

    // get departure time hours and set AM or PM
    var departureHours = new Date(item.departureTime).getHours();
    var ampmDeparture = departureHours >= 12 ? 'PM' : 'AM';

    // convert to 12 hour format
    departureHours = (departureHours % 12) || 12

    // get departure time minutes and append zeros
    var departureMinutes = new Date(item.departureTime).getUTCMinutes();
    departureMinutes = addZeros(departureMinutes)

    // get arrival time hours and set AM or PM
    var arrivalHours = new Date(item.arrivalTime).getHours();
    var ampmArrival = arrivalHours >= 12 ? 'PM' : 'AM'

    // convert to 12 hour format
    arrivalHours = (arrivalHours % 12) || 12

    // get arrival time minutes and append zeros
    var arrivalMinutes = new Date(item.arrivalTime).getUTCMinutes();
    arrivalMinutes = addZeros(arrivalMinutes)

    // TODO: Edit which data gets displayed to users based on the 'toNMC' boolean,
    // for now users will see the same data regardless
    if (item.toNMC = true) {
        $('#offersTable').find('#offersTableBody').append(
            "<tr><td>" + item.address.city + "</td>" +
            "<td>" + item.campus + "</td>" +
            "<td>" + departureHours + ":" + departureMinutes + " " + ampmDeparture + "</td>" +
            "<td>" + arrivalHours + ":" + arrivalMinutes + " " + ampmArrival + "</td>" +
            "<td><a type='button' class='btn-success shadow-lg text-white p-1 rounded d-flex justify-content-center mx-auto'>Details</a></td>" +
            "</tr>");
    }
    else {
        $('#offersTable').find('#offersTableBody').append(
            "<tr><td>" + item.address.city + "</td>" +
            "<td>" + item.campus + "</td>" +
            "<td>" + departureHours + ":" + departureMinutes + " " + ampmDeparture + "</td>" +
            "<td>" + arrivalHours + ":" + arrivalMinutes + " " + ampmArrival + "</td>" +
            "<td><a type='button' class='btn-success shadow-lg text-white p-1 rounded d-flex justify-content-center mx-auto'>Details</a></td>" +
            "</tr>");
    }
}

// function to add extra zeros to time in dates to enhance their apperance
function addZeros(mins) {
    return (mins < 10 ? '0' : '') + mins;
}

// function to perform searches for addresses
function offersSearch() {
    // declare variables
    var input, filter, table, tr, td, i, txtValue, test;
    input = document.getElementById("offersSearchInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("offersTable");
    tr = table.getElementsByTagName("tr");

    // loop through all table rows, and hide those who don't match the search query
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];

        if (td) {
            txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}
