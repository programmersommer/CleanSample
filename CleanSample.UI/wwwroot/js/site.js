﻿"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/todoHub").build();

connection.on("ToDoResult", function (result) {
    if (result)
        alert("ToDo was saved");
    else
        alert("ToDo was not saved");
});

connection.start().then(function () {

    connection.invoke('getConnectionId')
        .then(function (connectionId) {
            sessionStorage.setItem('conectionId', connectionId);
        }).catch(err => console.error(err.toString()));

}).catch(function (err) {
    return console.error(err.toString());
});
