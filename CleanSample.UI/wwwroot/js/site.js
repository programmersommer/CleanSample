"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/todoHub").build();

connection.on("ToDoResult", function (model) {
    if (model.result)
        alert("ToDo was saved");
    else
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
