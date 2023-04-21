
2023-03-03
1545
Started the Assignment 2 on the lab computer.
Set up the ASP>NET MVC w/ core 3.1 (out-of-support)
HTTP enablead, individual account  authentication
Reviewed the Areas folder,Controller, Model,view 

1613-n Startup.cs online 33
removed options for default identity:
options=> options.SignIn.RequireConfirmedAccount = true

1615
Tested app..ran it good..Tested links
Action Items:
-Modify the navigation
-update the copyright.. from 'static' to 'dynamic'

1624
Modified the default welcome message tested..
reveiew the rounte pattern in Satartup.cs

1631
creat README.md file in the github and pull it in the visual Studio.



2023-03-09
1433
Edited the bootstrap_bk.css for backup purpose..
after that selected theme from bootwatch
added bootstraps.min.css folder

1448
added code to the bootstraps/css/bootstraps.min.cs...
then try to run the app..
 
2023-03-10
1130
The nav class has changed from navbar-light to navbar-dark and bg-white to bg-primary in _Layout.cshtml in views folder.
Remove text-dark from line 23 in _Layout.cshtml.
Then added aditional properties to the footer class.
Remove the text-dark in _LoginPartial.cshtml file and then run the app.
Added additional stylesheets and scripts from the css_js.txt file in _Layout.cshtml file.

1146
Added dropdown to the navbar and change the dropdown name to content Management.

Added 3 new .Net core class library projects to the application.
1- ManishsBooks.DataAccess
2- ManishsBooks.Models
3- ManishsBooks.Utility

14-04-2023
0809

The Data folder should then be copied and pasted into the ManishsBooks.
Additionally lost from the original code was the DataAccess project.

Install Microsoft.Core EntityFramework.Core and Relational.Packages for SQL Packages.
Additionally, the Migration folder was deleted.

ApplicationDbContext.cs's namespace was changed, and the class1.cs file was deleted from all projects.
Manish's Books.Models is now located in the Models folder.

In the.DataAccess and.Models project, a project reference was added.
Namespace changes to.Models.ViewModels and renaming the Models folder to ViewModels are also recommended.

Run the programme after making changes to the Startup.cs file and check for eroors. 
Error.cshtml now refers to.Models instead of.Models.test the application using ViewModels.ErrorViewModels.
Additional Identity.Nuget package for entities
after which successfully build the project.

ManishsBooks.Utility SD.cs class was created.
project references for the Utility and Models in Manish's Books projects were added. the project named DataAccess.
I converted the class in the SD.CS file to a public static class.
I updated the Areas file with Customer.

In ScaffoldingReadMe.txt, modify the routes as well.
Next, transfer HomeController.cs from controller to area controller.
the home folder into the views folder after that.
ran the programme after that, but there is a problem.

The two files _Viewmports.cshtml and _ViewStart.cshtml from views should be copied and pasted to the customer folder in Area.
Running the programme after making the necessary changes to the route in the _ViewStart.cshtml file results in no problems.

Admin area has been added to Areas.
removed the folder containing the Data, Models, and Controllers files and added the view files.

The application was successfully built with no problems.
the appsettings.json file's database name should be changed.

14-04-2023
1019

Using the Nuget Package Manager Console to add migration, and after selecting, add migration
once more.DataAccess project is practically acceptable.
Run the programme after reviewing the revised database in the SQL Server Object Explorer.
Change the project to.DataAccess, then enter the command in the PM console once again to make it function.

the ApplicationDbContext.cs file has been updated.
Run add-migration again to perform another migration AddCategoryToDb. 
Write the following migration command in the PM console along with the update-database 
command to obtain the Category table in the SQl SOE.

Create an IRepository folder and a Repository folder in your.DataAccess project.
then make the necessary changes to Irepository.cs as instructed by the provided code to enable us to do all CRUD operations.
After that, modify the provided code and add it to the IRepository.

then included utilising Manish's Books.DataAccess.Repository.Implement IRepository and an interface.
Once that is done, add the provided code to the existing code to add constructors and dependency injection.

utilising ManishsBookStore, added.Utilising Microsoft.EntityFrameworkCore and DataAccess.Data
two files, ICategoryRepository.cs interface and CategoryRepository.cs interface, 
were generated in the IRepository and Repository folders, respectively.

Then I made the appropriate adjustments in CategoryRepository.cs.
Afterwards, ICategoryRepository.cs was changed.
Implementing the interface for updating in CategoryRepository.cs after which the CategoryRepository.cs file was updated.

Create the app, and it functions well.
After that, ISP_Call.cs was updated and a new interface for the IRepository was developed.
Updated is the ISP_Call.cs file.

SP_Call.cs file was added to the Repository folder.
and changed SP_Call.cs. 
Modify the provided code and paste it into SP_Call.cs.

The Irepository folder now contains the UnitOfWork.cs interface.
Changed UnitOfWork.cs was integrated into the repository folder along with modified UnitOfWork.cs.
In the startup.cs code, UnitOfWork and IUnitOfWork were introduced.

Part-3
Created CategoryController.cs in the controller folder as well as the Controller folder in the admin.
then add the provided code to CategoryController.cs.To Views, add the Category folder.

In the Category folder, create an index.cshtml file, and then paste the provided code from the View.txt folder.
Run the app after updating _Layout.cshtml.

The dropdown in _Layout.cshtml then changes.
I changed Index.cshtml.
category.js file was added to the JS folder.

To enable the edit and remove buttons, the CategoryController.cs file
contains code that calls the category.js upsert action in the Index.cshtml.

20-04-2023

create and back to list button (_CreateAndListButton.cshtml)
A second partial view (_EditAndBackToListButton.cshtml) was made.
Upsert.cshtml file has been updated.

furthermore include asp-action in the index.cshtml.
Change Upsert.cshtml, then launch the application.
the Upsert.cshtml should then contain @section.
IUnitOfWork's void Save() function has been added.

Delete _db.CategoryRepository.cs's modified CategoryController.cs file contains the SaveChanges() function.
To category.js, add the delete(url) function code.
IRepository's ICoverTypeRepository and Repositoryfolder's CoverTypeRepository have been created.

ICoverTypeRepository and CoverTypeRepository have been updated.
IUnitOfWork.cs and UnitOfWork.cs have also been updated.
created the CoverType.cs model file.
Additionally, the CoverType model has ID,NAme.

completed a migration process using the PM console and added CoverTypes
to ApplicationDbContext.cs in a manner similar to adding categories.
In a SQL database table, CoverType can be found.
CovertypeController.cs was added to the ManishsBookStore's Controller folder.
created a CoverType folder inside the Views folder.

Added CoverType.js to js as well.
Launch the programme.














