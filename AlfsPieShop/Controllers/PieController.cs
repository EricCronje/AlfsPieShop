/*###############################################################################################################  
 *Version 5.0.0
 *PieController.cs
 *###############################################################################################################
 *#1    -   Add -   Created the empty controller                                     - TB10  - 20241009  - V1.0.0
 *              -   This is to mock the pie data
 *#2    -   Add -   private readonly ICategoryRepository                             - TB10  - 20241009  - V2.0.0
 *#3    -   Add -   private readonly IPieRepository                                  - TB10  - 20241009  - V3.0.0
 *#4    -   Add -   Controller - PieController to initialize                         - TB10  - 20241009  - V4.0.0
 *              -   _categoryRepository and _pieRepository
 *#5    -   Add -   Action List                                                      - TB10  - 20241009  - V5.0.0              
 *###############################################################################################################
 */

using AlfPieShop.Models;
using AlfPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AlfPieShop.Controllers
{
    public class PieController(IPieRepository pieRepository) : Controller
    {
        private readonly IPieRepository _pieRepository = pieRepository; //#2

        public IActionResult List() //#5
        {
            //ViewBag.CurrentCategory = "Cheese Pie"; //#5
            //return View(_pieRepository.AllPies); //#5
            PieListViewModel pieListModelView = new
                (_pieRepository.AllPies, "Cheese Pie"); //#5
            return View(pieListModelView);//#5
        }
    }
}
