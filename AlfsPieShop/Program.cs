/*###############################################################################################################
 * Program.cs
 *###############################################################################################################  
 *  Version 13.0.1
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
