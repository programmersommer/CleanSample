"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/todoHub").build();

connection.on("ToDoResult", function (model) {

    if (model.items != null) {

        var events = [];

        model.items.map(function (item) {
            events.push({
                "title": item.description,
                "start": item.eventDateTime
            });
        });

        var calendarEl = document.getElementById('calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            initialView: 'dayGridMonth',
            events: events
        });
        calendar.render();

        return;
    }

    alert(model.message);
});

connection.start().then(function () {

    connection.invoke('getConnectionId')
        .then(function (connectionId) {
            sessionStorage.setItem('conectionId', connectionId);

            var data = {
                'User': connectionId
            };

            $.ajax({
                url: 'home/ToDo/GetToDoItems',
                type: 'POST',
                data: data,
                headers: {
                    "RequestVerificationToken": document.getElementById('site-script').getAttribute("data-token")
                },
                success: function (data) {
                    $("#SubmitButton").prop('disabled', false);
                },
                error: function (request, error) {

                }
            });

        }).catch(err => console.error(err.toString()));

}).catch(function (err) {
    return console.error(err.toString());
});
