/*###############################################################################################################
 * Pie.cs
 *###############################################################################################################  
 *  Version 2.0.0
 *###############################################################################################################
 *#1    -   Add -   Created the empty class                                          - TB10  - 20241009  - V1.0.0
 *#2    -   Add -   the class Pie - with properties                                  - TB10  - 20241009  - V2.0.0
 *      _   int PieId
 *      _   string Name
 *      _   string? ShortDescription
 *      -   string? LongDescription
 *      -   string? AllergyInformation
 *      -   decimal Price
 *      -   string? ImageUrl      
 *      -   string? ImageThumbnailUrl
 *      -   bool IsPieOfTheWeek
 *      -   bool InStock
 *      -   int CategoryId
 *      -   Category Category       Cannot be null default!
 *###############################################################################################################
 */
using System.ComponentModel.DataAnnotations.Schema;

namespace AlfPieShop.Models
{
    public class Pie
    {
        public int PieId { get; set; } //#2
        public string Name { get; set; } = string.Empty;//#2
        public string? ShortDescription { get; set; }//#2
        public string? LongDescription { get; set; }//#2
        public string? AllergyInformation { get; set; }//#2
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }//#2
        public string? ImageUrl { get; set; }//#2
        public string? ImageThumbnailUrl { get; set; }//#2
        public bool IsPieOfTheWeek { get; set; }//#2
        public bool InStock { get; set; }//#2
        public int CategoryId { get; set; }//#2
        public Category Category { get; set; } = default!;//#2
    }
}
