/*###############################################################################################################  
 *Version 2.0.0
 *###############################################################################################################
 *#1    -   Add -   Created the interface                                            - TB10  - 20241009  - V1.0.0
 *#2    -   Add -   properties                                                       - TB10  - 20241009  - V2.0.0
 *              -   IEnumerable<Pie> AllPies { get; }
 *              -   IEnumerable<Pie> PiesOfTheWeek { get; }
 *              -   Pie? GetPieById(int pieId);
 *###############################################################################################################
 */
namespace AlfPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; } //#2
        IEnumerable<Pie> PiesOfTheWeek { get; } //#2
        Pie? GetPieById(int pieId); //#2
    }
}
