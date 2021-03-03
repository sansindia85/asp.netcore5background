# asp.netcore5background

In ASP.NET Core, background tasks can be implemented as hosted services. A hosted service is a class with background task logic that implements the IHostedService interface.

HostedServiceTimer:
A timed background task makes use of the System.Threading.Timer class. The timer triggers the task's DoWork method. 
The timer is disabled on StopAsync and disposed when the service container is disposed on Dispose.

HostedServiceScoped:
Hosted service that activates a scoped service. The scoped service can use dependency injection (DI).