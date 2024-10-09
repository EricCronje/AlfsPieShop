﻿/*###############################################################################################################  
 *Version 2.0.0
 *###############################################################################################################
 *#1    -   Add -   Created the empty class                                          - TB10  - 20241009  - V1.0.0
 *              -   This is to mock the category data
 *#2    -   Add -   with property                                                    - TB10  - 20241009  - V2.0.0
 *              -   IEnumerable<Category> AllCategories { get; }
 *###############################################################################################################
 */
namespace AlfsPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        /// <summary>
        /// Mock the category data
        /// </summary>
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="All-fruity pies"},
                new Category{CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy all the way"},
                new Category{CategoryId=3, CategoryName="Seasonal pies", Description="Get in the mood for a seasonal pie"}
            }; //#2
    }
}
