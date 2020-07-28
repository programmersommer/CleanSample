# Clean architecture prototype on .NET Core platform (C#)  

Example is not completed and absolutely not perfect, but could clearly explain my view on how Clean Architecture flow could be implemented in .NET Core Application.   
  
I am using SignalR for sending message from Presenter to UI. It’s cross platform and helps to implement loosely coupled UI.

I can imagine that you will use Presenter for get operations and Controller for post/put create/update operations. This approach is also could be alternatively used, but I think that my prototype is more reactive.
