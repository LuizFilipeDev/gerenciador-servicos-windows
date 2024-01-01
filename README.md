# Windows Services Manager

Application developed for those who work creating and modifying Windows services or need to manipulate Windows services, facilitating installation and removal through an interface, among other things that I will describe each function below.

Note: To make life easier and the program's usability, it is not necessary to use any command line through the interface, much less open the native Windows service manager to check the status of the service, start and stop it. You will be able to manage the entire process through this application.

## Interface

The list of services and processes in the application updates with each user interaction with the application, unlike the official Windows service manager that forces you to click on the update button every time you manipulate the services, this interface in addition to bringing the services (Also the status) also shows the processes that are running (With the PID).

![image](https://user-images.githubusercontent.com/74942532/129638288-1e8ebb11-bf44-41f5-bd5b-702591815238.png)

## What are the functions?

I will describe the functions below separating them by the boxes as in the print above, in the application we have the Project, Services and Processes in execution box (Taskkill).

`?`: All boxes in the application contain a question mark button that superficially explains what that box does.

### Project
#
This box is responsible for installing and uninstalling Windows services by locating the compiled executable of the service you want to manipulate.

Note: Remembering that before carrying out the build/rebuild, if you have previously installed the services using the same project through which you are going to install the updated services again, first uninstall the services with the old version of the build/rebuild, then do the build/rebuild and install the new version of the services to avoid malfunctioning problems with the services that will be installed.

`...`: Button that opens the Windows file explorer to locate the executable compiled with the services. (inside your project folder with services, locate the "Bin" folder and inside this folder you should find the "Debug" and "Release" folders, just open the folder for which you chose to build/rebuild in Visual Studio and inside you should find the executable (.exe) with the name of the Visual Studio solution, just select the executable and perform the procedure you want below)

`Instalar`: Button that executes the installation of the services selected by the executable found with the file explorer button.

`Desinstalar`: Button that uninstalls the services selected by the executable found with the file explorer button.

### Services
#
This box is responsible for managing the listed services (the names of the listed services are from the "ServiceName" property of the services), and can:

`Iniciar`: This button executes the command for the selected services to run.

`Parar`: This button executes the command for the selected services to stop.

`Remover`: This button executes the command that removes the selected services, this method is used if you uninstall the service through the project box and it still remains listed (Recurring Windows problem), so it is as if you forced it to stop and run the automatic unchristening function afterwards.

### Running processes - TaskKill
#
This box is responsible for managing the listed processes (the names of the listed processes are from the processes' "ProcessName" property), and can:

`Parar`: This button executes the command for the selected processes to stop. However, this method is used if the services do not stop running through the service box (recurring Windows problem), thus functioning as a "TaskKill" for the process with the services, generally the process name is the name of the executable you selected At the time of installation, it will be listed in the box mentioned if the services are running.

## About

Application developed using the following technologies: Visual Studio, Windows Forms and .NET Framework.
