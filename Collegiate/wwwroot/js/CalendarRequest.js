//vars
var date;
var listOfRequests = [];

//requests.forEach(testing);

//function testing(item, index) {
//    console.log("Request:");
//    console.log(item);
//    console.log();
//}

//event handler to display data in modal content on modal open
$('#RequestsModal').on('show.bs.modal', function (event) {
    $('#requestsTable').find("#requestsTableBody").text("");
    date = $(event.relatedTarget).data('date');

    listOfRequests = [];
    requests.forEach(displayRequests);
    listOfRequests.forEach(requestDisplay);
});

//function to get list of requests for a given day
function displayRequests(item, index) {

    var miliseconds = Date.parse(date);
    var d = new Date(miliseconds);

    if (item.toNMC == true) {
        var mesc = Date.parse(item.arrivalTime);
        var dd = new Date(mesc);

        d.setHours(0, 0, 0, 0);
        dd.setHours(0, 0, 0, 0);

        if (dd.getTime() == d.getTime()) {
            listOfRequests.push(item);
        }
    }
    else {
        var mesc = Date.parse(item.departureTime);
        var dd = new Date(mesc);

        d.setHours(0, 0, 0, 0);
        dd.setHours(0, 0, 0, 0);

        if (dd.getTime() == d.getTime()) {
            listOfRequests.push(item);
        }
    }
}

//function to display requests for a given day in modal content
function requestDisplay(item, index) {

    var departureHours = new Date(item.departureTime).getHours();
    var ampmDeparture = departureHours >= 12 ? 'PM' : 'AM';
    departureHours = (departureHours % 12) || 12
    var departureMinutes = new Date(item.departureTime).getUTCMinutes();
    departureMinutes = addZeros(departureMinutes)

    var arrivalHours = new Date(item.arrivalTime).getHours();
    var ampmArrival = arrivalHours >= 12 ? 'PM' : 'AM'
    arrivalHours = (arrivalHours % 12) || 12
    var arrivalMinutes = new Date(item.arrivalTime).getUTCMinutes();
    arrivalMinutes = addZeros(arrivalMinutes)

    //TODO: Edit which data gets displayed to users based on the 'toNMC' boolean,
    //for now users will see the same data regardless
    if (item.toNMC == true) {
        $('#requestsTable').find('#requestsTableBody').append(
            "<tr><td>" + item.address.city + "</td>" +
            "<td>" + item.campus + "</td>" +
            "<td>" + departureHours + ":" + departureMinutes + " " + ampmDeparture + "</td>" +
            "<td>" + arrivalHours + ":" + arrivalMinutes + " " + ampmArrival + "</td>" +
            "<td><a type='button' class='btn-warning text-white p-1 rounded d-flex justify-content-center mx-auto'>Details</a></td>" +
            "</tr>");
    }
    else {
        $('#requestsTable').find('#requestsTableBody').append(
            "<tr><td>" + item.address.city + "</td>" +
            "<td>" + item.campus + "</td>" +
            "<td>" + departureHours + ":" + departureMinutes + " " + ampmDeparture + "</td>" +
            "<td>" + arrivalHours + ":" + arrivalMinutes + " " + ampmArrival + "</td>" +
            "<td><a type='button' class='btn-warning text-white p-1 rounded d-flex justify-content-center mx-auto'>Details</a></td>" +
            "</tr>");
    }
}

//function to add extra zeros to time in dates, increases readability
function addZeros(mins) {
    return (mins < 10 ? '0' : '') + mins;
}

//function to perform searches for addresses
function requestsSearch() {
    // Declare variables
    var input, filter, table, tr, td, i, txtValue, test;
    input = document.getElementById("requestsSearchInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("requestsTable");
    tr = table.getElementsByTagName("tr");

    // Loop through all table rows, and hide those who don't match the search query
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName("td")[0];
        console.log(td);
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
