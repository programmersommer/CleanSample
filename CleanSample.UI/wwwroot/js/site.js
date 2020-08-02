"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/todoHub").build();

connection.on("ToDoResult", function (model) {

    if (model.items != null && model.items.length > 0) {

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
        }).catch(err => console.error(err.toString()));

}).catch(function (err) {
    return console.error(err.toString());
});
