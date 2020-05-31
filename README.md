# Clean architecture prototype on .NET Core platform (C#)  

Example is not completed and absolutely not perfect, but could clearly explain my view on how clean architecture flow could be implemented in .NET Core Application.   
  
I am using SignalR for sending message from Presenter to UI. It’s cross platform and helps to implement loosely coupled UI.
As alternative you can try to use WebSockets, SSE (Server-Sent Events), Long polling, message brokers (like RabbitMQ, Kafka etc.) or third-party service (FireBase, Pusher etc.)  
