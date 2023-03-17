# _Dr.Sillystringz's Factory_

#### By _Erin Timlin_

#### _{Brief description of application}_

## Technologies Used

* _.Net 6_
* _ASP.NET Core MVC 6_
* _C#_
* _MySQLWorkBench_
* _EF Core_
* _LINQ_

## Description

_{This is a detailed description of your application. Give as much detail as needed to explain what the application does as well as any other information you want users or other developers to have.}_

## Setup/Installation Requirements

* _Clone this repo_
* _Open the terminal and navigate to this project's production directory called "Factory.Solution"_
* _Within the production directory "Factory", create a new file called `appsettings.json`_
* _In `appsettings.json`, insert the following code:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* _Be sure to change [YOUR-USERNAME-HERE] to your username for MySQLWorkbench and [YOUR-PASSWORD-HERE] to your password for MySQLWorkbench, leaving out the square brackets_
* _Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher._

_{Leave nothing to chance! You want it to be easy for potential users, employers and collaborators to run your app. Do I need to run a server? How should I set up my databases? Is there other code this application depends on? We recommend deleting the project from your desktop, re-cloning the project from GitHub, and writing down all the steps necessary to get the project working again.}_

## Known Bugs

* _It's broke_


## License

_{Let people know what to do if they run into any issues or have questions, ideas or concerns.  Encourage them to contact you or make a contribution to the code.}_

Copyright MIT (c) _March 2023_ _Erin Timlin_