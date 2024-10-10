/*###############################################################################################################  
 *Version 2.0.0
 *###############################################################################################################
 *#1    -   Add -   Created the empty class                                          - TB10  - 20241009  - V1.0.0
 *#2    -   Add -   the class Category - with properties                             - TB10  - 20241009  - V2.0.0
 *              -   int CategoryId
 *              -   string CategoryName     Default Empty string
 *              -   string? Description
 *              -   List<Pie>? Pies
 *###############################################################################################################
 */
namespace AlfPieShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; } //#2
        public string CategoryName { get; set; } = string.Empty;//#2
        public string? Description { get; set; }//#2
        public List<Pie>? Pies { get; set; }//#2
    }
}
