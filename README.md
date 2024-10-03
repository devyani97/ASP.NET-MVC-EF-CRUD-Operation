# ASP.NET MVC EF CRUD Operation

-**What I utilize**:- Visual Studio 2022, Asp .NET Web application(.NET framework),C# language, SQL server management Studio

-**What is CRUD operation** :- Basic opertion used to manage data in database. We can CREATE, READ, UPDATE, DELETE the data.

-**Talk about project** :
  MVC  project contains MODEL, CONTROLLER, VIEW file. And it also contains two WEB.CONFIG file 
  one is for whole project and another one is situated in the VIEW FOLDER it manages the view of the output.

-**Employee.cs file**:- This is Created in MODEL folder. I made in this various properties for creating text boxes for input and output purpose.
  I am using code 1st approach here so I need to show that database primary key here. but for declaring it I need to use two Libraries
  1)Component.dataAnnotation
  2)Component.model these I am using for showing primary key and showing [Required field](Required field: showing validation)

-**Services file**:- this is created in Model folder. it work as a Middalware for the frontend and backend.

-**Controller**:-
  It is a mediator between User request, model,view
  It takes user input request, intract with model for logic & data, selecting appropriate view to display
  In this I created VIEW for each button.
  At the time of creating VIEW  it's Scaffolding basically it generating necessary code to interact with database. it mainly use fo CRUD operation
  At the time of creating VIEW it uses RAZOR VIEW . IT will create layout page cshtml i.e. C# HTML its a combination both languages
  It will intracting with both of them .It work like an engine. It differentiate both code and also merge them and compile.

**I have added short video of the project**
