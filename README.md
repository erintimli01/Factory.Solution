# _Dr.Sillystringz's Factory_

#### By _Erin Timlin_

#### _A C# web application that Dr. Sillystringz can use to keep track of machine repairs. Here, they will be able to add engineer and machine details. They can add a machine to an engineer to keep track of which engineer is working on what machine._

## Technologies Used

* _.Net 6_
* _ASP.NET Core MVC 6_
* _C#_
* _MySQLWorkBench_
* _EF Core_
* _LINQ_

## Description

_As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines._
_As the factory manager, I need to be able to select a engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it._
_As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed._
_I should not be able to create an engineer or a machine if the form's fields are empty or contain invalid values._
_As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed._
_As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine._
_I should not be able to add a machine to an engineer if there are no machines. Likewise I should not be able to add an engineer to a machine if there are no engineers._
_When I access the application, I should see a splash page that lists all engineers and machines._

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
* _In the command line, run the command `dotnet restore` to install all dependencies including EF Core. Then, run `dotnet ef database update` to allow MySQL to auto-create the required database for this project._
* _Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher._

## Known Bugs

* _No Known Bugs!_



## License
_Please reach out with any questions or concerns! Also feel free to make any contributions!_

Copyright [MIT](license.txt) (c) _March 2023_ _Erin Timlin_