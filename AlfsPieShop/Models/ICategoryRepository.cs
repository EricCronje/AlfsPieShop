/*###############################################################################################################  
 *Version 2.0.0
 *###############################################################################################################
 *#1    -   Add -   Created the empty interface                                      - TB10  - 20241009  - V1.0.0
 *#2    -   Add -   with property                                                    - TB10  - 20241009  - V2.0.0
 *              -   IEnumerable<Category> AllCategories { get; }
 *###############################################################################################################
 */
namespace AlfsPieShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
