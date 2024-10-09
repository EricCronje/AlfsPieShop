/*##############################################################################################################
 * Program.cs
 *##############################################################################################################  
 *  Version 6.0.1
 *##############################################################################################################
 *#1    -   Cre -   Created the empty dot net cor appliaction                       - TB10  - 20241009  - V1.0.0
 *#2    -   Mod -   Removed the middle ware app.MapGet("/", () => "Hello World!");  - TB10  - 20241009  - V1.0.1
 *#3    -   Add -   builder.Services.AddControllersWithViews();                     - TB10  - 20241009  - V2.0.1
 *#4    -   Add -   Middleware to add the static files.                             - TB10  - 20241009  - V3.0.1
 *#5    -   Add -   test if development - must only sho dev pages then              - TB10  - 20241009  - V4.0.1
 *#6    -   Add -   Middleware to show the dev exception pages                      - TB10  - 20241009  - V5.0.1
 *#7    -   Add -   Middleware to for the controller routing                        - TB10  - 20241009  - V6.0.1
 *##############################################################################################################
 */
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //#3

var app = builder.Build();

app.UseStaticFiles(); //#4

if (app.Environment.IsDevelopment()) //#5
{
    app.UseDeveloperExceptionPage(); //#6
}

app.MapDefaultControllerRoute(); //#7

app.Run();
