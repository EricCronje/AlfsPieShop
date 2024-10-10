/*###############################################################################################################
 * Program.cs
 *###############################################################################################################  
 *  Version 60.2.1
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
 *#32   -   Add -   added the final CSS to the layout file                          - TB10  - 20241009  - V31.0.1
 *#33   -   Add -   added the final CSS to the Pie - action list                    - TB10  - 20241009  - V32.0.1
 *#34   -   Add -   created the images folder in the WWWROOT folder                 - TB10  - 20241009  - V33.0.1
 *#35   -   Add -   created the CSS folder in the WWWROOT folder                    - TB10  - 20241009  - V34.0.1
 *#36   -   Add -   created the content under the image folder in the WWWROOT folder- TB10  - 20241009  - V35.0.1
 *#37   -   Add -   Added client side bootstrap                                     - TB10  - 20241009  - V36.0.1
 *#38   -   Add -   Added JQuery client side                                        - TB10  - 20241009  - V37.0.1
 *#39   -   Add -   NuGet packages Microsoft.EntityFrameworkCore.SQLServer          - TB10  - 20241010  - V38.0.1
 *#40   -   Add -   NuGet packages Microsoft.EntityFrameworkCore.Tools              - TB10  - 20241010  - V39.0.1
 *#41   -   Add -   DBContext                                                       - TB10  - 20241010  - V40.0.1
 *#42   -   Add -   Connection string AppSettings.json                              - TB10  - 20241010  - V41.0.1
 *#43   -   Add -   Added the builder.service in program.cs AddDBContext            - TB10  - 20241010  - V42.0.1
 *#44   -   Add -   PieRepository Class                                             - TB10  - 20241011  - V43.0.1
 *#45   -   Add -   CategoryRepository Class                                        - TB10  - 20241011  - V44.0.1
 *#46   -   Bug -   Fix the appSettings.json - MultiplwActiveResultSets             - TB10  - 20241011  - V45.0.1
 *              -   must be MultipleActiveResultSets                                -       -           -
 *#47   -   Mod -   Program.cs remove mock replace with real repository             - TB10  - 20241011  - V46.0.1
 *#48   -   Add -   Private DBcontext in Pie repository                             - TB10  - 20241011  - V47.0.1
 *#49   -   Add -   Create a constructor in Pie repository                          - TB10  - 20241011  - V48.0.1
 *#49   -   Add -   Use primary constructor syntax                                  - TB10  - 20241011  - V48.0.1
 *#50   -   Bug -   Fix the DBset properties to be public in the dbContext          - TB10  - 20241011  - V49.0.1
 *#51   -   War -   Fix the name in the Pie repository AlfPieShop remove the s      - TB10  - 20241011  - V50.0.1
 *#52   -   War -   Fix the name in the Category repository                         - TB10  - 20241011  - V51.0.1
 *#53   -   Add -   Private DBcontext in Category repository AlfPieShop remove the s- TB10  - 20241011  - V52.0.1
 *#54   -   Add -   Logic to the all category part in category repository           - TB10  - 20241011  - V53.0.1
 *#55   -   War -   Used the primary constructor syntax                             - TB10  - 20241011  - V54.0.1
 *#56   -   Def -   ran the link https://localhost:7251/pie/list                    - TB10  - 20241011  - V55.0.1
 *              -   received error SqlException: Cannot open database "...Pie..."   -       -           -
 *              -   requested by the login. The login failed. Login failed for      -       -           -
 *              -   user '...\...'                                                  -       -           -
 *              -   see the {D2086ECD-3549-4C7F-A542-25E53FD0F9D1}.pdf              -       -           -
 *              -   located in \Docs\Defects                                        -       -           -
 *              -   (This is understandable - there is not database yet)            -       -           -
 *#57   -   Add -   Initial migration                                               - TB10  - 20241011  - V56.0.1              
 *#58   -   Add -   DBInitializr to seed the data                                   - TB10  - 20241011  - V58.0.1              
 *#59   -   Add -   DBInitializr to program.cs                                      - TB10  - 20241011  - V59.0.1              
 *#60   -   Bug -   Fix spelling mistake Pistachio                                  - TB10  - 20241011  - V59.1.1              
 *#60   -   War -   Fix 3000 warning on the price for Pie POCO added decimal(18,2)  - TB10  - 20241011  - V59.2.1              
 *#60   -   Out -   See the output in the documents of the page so far              - TB10  - 20241011  - V60.2.1              
 *              -   {11D216C2-5962-48BF-949C-F9048FE548F3}.pdf                      -       -           -
 *###############################################################################################################
 */
using AlfPieShop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();//#13 #47
builder.Services.AddScoped<IPieRepository, PieRepository>();//#14 #47
builder.Services.AddDbContext<AlfPieShopDBContext>(Options => { Options.UseSqlServer(builder.Configuration["ConnectionStrings:AlfPieShopDbContextConnection"]); }); //#39
builder.Services.AddControllersWithViews(); //#3

var app = builder.Build();

app.UseStaticFiles(); //#4

if (app.Environment.IsDevelopment()) //#5
{
    app.UseDeveloperExceptionPage(); //#6
}

app.MapDefaultControllerRoute(); //#7

DBInitializer.Seed(app);

app.Run();
