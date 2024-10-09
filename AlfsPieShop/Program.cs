/*###############################################################################################################
 * Program.cs
 *###############################################################################################################  
 *  Version 37.0.1
 *###############################################################################################################
 *#1    -   Add -   Created the empty dot net core application                      - TB10  - 20241009  - V1.0.0
 *#2    -   Mod -   Removed the middle ware app.MapGet("/", () => "Hello World!");  - TB10  - 20241009  - V1.0.1
 *#3    -   Add -   builder.Services.AddControllersWithViews();                     - TB10  - 20241009  - V2.0.1
 *#4    -   Add -   Middle ware to add the static files.                            - TB10  - 20241009  - V3.0.1
 *#5    -   Add -   test if development - must only show developer pages then       - TB10  - 20241009  - V4.0.1
 *#6    -   Add -   Middle ware to show the dev exception pages                     - TB10  - 20241009  - V5.0.1
 *#7    -   Add -   Middle ware to for the controller routing                       - TB10  - 20241009  - V6.0.1
 *#8    -   Add -   Folder called Models                                            - TB10  - 20241009  - V7.0.1
 *#9    -   Add -   the class Pie - with properties                                 - TB10  - 20241009  - V8.0.1
 *#10   -   Add -   the class Category - with properties                            - TB10  - 20241009  - V9.0.1
 *#11   -   Add -   the interface IPieRepository - with properties                  - TB10  - 20241009  - V10.0.1
 *#12   -   Add -   the interface ICategoryRepository - with properties             - TB10  - 20241009  - V11.0.1
 *#13   -   Add -   AddScoped<ICategoryRepository, MockCategoryRepository>()        - TB10  - 20241009  - V12.0.1
 *#14   -   Add -   AddScoped<IPieRepository, MockPieRepository>()                  - TB10  - 20241009  - V13.0.1
 *#15   -   Add -   Add Controllers folder                                          - TB10  - 20241009  - V14.0.1
 *#16   -   Add -   Add Controller PieController                                    - TB10  - 20241009  - V15.0.1
 *
 *#17   -   Add -   Add Folder View                                                 - TB10  - 20241009  - V16.0.1
 *#18   -   Add -   Add Folder Pie                                                  - TB10  - 20241009  - V17.0.1
 *#19   -   Add -   Add Action result List in the Pie Controller                    - TB10  - 20241009  - V18.0.1
 *              -   IActionResult List()
 *#20   -   Add -   Add the View and test static html                               - TB10  - 20241009  - V19.0.1
 *#21   -   Add -   The folder ViewModels                                           - TB10  - 20241009  - V20.0.1
 *#22   -   Add -   The file PieListViewModel                                       - TB10  - 20241009  - V21.0.1
 *#23   -   Mod -   Pie Controller to use the PieListViewModel class                - TB10  - 20241009  - V22.0.1
 *#24   -   Mod -   View  for list to use the PieListViewModel class                - TB10  - 20241009  - V23.0.1
 *#25   -   Add -   Added the constructor to the PieListViewModel                   - TB10  - 20241009  - V24.0.1
 *#26   -   Add -   Create the shared folder in the views folder                    - TB10  - 20241009  - V25.0.1
 *#27   -   Add -   _Layout.cshtml in the shared folder                             - TB10  - 20241009  - V26.0.1
 *#28   -   Mod -   Mod the List action view page - move code to the layout         - TB10  - 20241009  - V27.0.1
 *#29   -   Add -   Create the _ViewStart.cshtml file in Views                      - TB10  - 20241009  - V28.0.1
 *#30   -   Add -   Create the _ViewImport.cshtml file in View                      - TB10  - 20241009  - V29.0.1
 *#31   -   Add -   add the using in the import file                                - TB10  - 20241009  - V30.0.1
 *#32   -   Add -   added the final css to the layout file                          - TB10  - 20241009  - V31.0.1
 *#33   -   Add -   added the final css to the Pie - action list                    - TB10  - 20241009  - V32.0.1
 *#34   -   Add -   created the images folder in the wwwroot folder                 - TB10  - 20241009  - V33.0.1
 *#35   -   Add -   created the css folder in the wwwroot folder                    - TB10  - 20241009  - V34.0.1
 *#36   -   Add -   created the content under the image folder in the wwwroot folder- TB10  - 20241009  - V35.0.1
 *#37   -   Add -   Added client side bootstrap                                     - TB10  - 20241009  - V36.0.1
 *#37   -   Add -   Added jquery client side                                        - TB10  - 20241009  - V37.0.1
 *###############################################################################################################
 */
using AlfsPieShop.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();//#13
builder.Services.AddScoped<IPieRepository, MockPieRepository>();//#14

builder.Services.AddControllersWithViews(); //#3

var app = builder.Build();

app.UseStaticFiles(); //#4

if (app.Environment.IsDevelopment()) //#5
{
    app.UseDeveloperExceptionPage(); //#6
}

app.MapDefaultControllerRoute(); //#7

app.Run();
