/*###############################################################################################################  
 *Version 4.0.0
 *PieController.cs
 *###############################################################################################################
 *#1    -   Add -   Created the empty class                                          - TB10  - 20241009  - V1.0.0
 *              -   This is for the Pie view model data
 *              -   To simplify the code.
 *#2    -   Add -   IEnumerable<Pie> Pies { get; } property                          - TB10  - 20241009  - V2.0.0
 *#3    -   Add -   string? CurrentCategory { get; }                                 - TB10  - 20241009  - V3.0.0
 *              -   To be used in the controller and the view.
 *#4    -   Add -   Created the constructor to initialize Pies and CurrentCategory   - TB10  - 20241009  - V4.0.0
 *###############################################################################################################
 */
using AlfsPieShop.Models;

namespace AlfsPieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; } //#2
        public string? CurrentCategory { get; } //#3

        public PieListViewModel (IEnumerable<Pie> pies, string? currentCategory) //#4
        {
            Pies = pies;
            CurrentCategory = currentCategory;
        }
    }
}
