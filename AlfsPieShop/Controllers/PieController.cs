/*###############################################################################################################  
 *Version 4.0.0
 *PieController.cs
 *###############################################################################################################
 *#1    -   Add -   Created the empty controller                                     - TB10  - 20241009  - V1.0.0
 *              -   This is to mock the pie data
 *#2    -   Add -   private readonly ICategoryRepository                             - TB10  - 20241009  - V2.0.0
 *#3    -   Add -   private readonly IPieRepository                                  - TB10  - 20241009  - V3.0.0
 *#4    -   Add -   Controller - PieController to initialize                         - TB10  - 20241009  - V4.0.0
 *              -   _categoryRepository and _pieRepository
 *###############################################################################################################
 */

using AlfsPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlfsPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly ICategoryRepository _categoryRepository; //#1
        private readonly IPieRepository _pieRepository; //#2

        public PieController (ICategoryRepository categoryRepository, IPieRepository pieRepository) //#3
        {
            _categoryRepository = categoryRepository; //#4
            _pieRepository = pieRepository; //#4
        }
    }
}
