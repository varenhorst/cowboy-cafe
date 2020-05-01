using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Drinks
        /// </summary>
        public IEnumerable<IOrderItem> Drinks { get; set; }
        public IEnumerable<IOrderItem> Entrees { get; set; }
        public IEnumerable<IOrderItem> Sides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";
        /// <summary>
        /// The type of the order
        /// </summary>
        [BindProperty]
        public string[] OrderTypes { get; set; }
        /// <summary>
        /// the min calorie filter
        /// </summary>
        public uint? MinCalorie { get; set; }
        /// <summary>
        /// max calorie filter
        /// </summary>
        public uint? MaxCalorie { get; set; }
        /// <summary>
        /// max price filter
        /// </summary>
        public uint? MaxPrice { get; set; }
        /// <summary>
        /// min price filter
        /// </summary>
        public uint? MinPrice { get; set; }





        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Sides = Menu.Sides;
            Entrees = Menu.Drinks;
            Drinks = Menu.Entrees;
        }


        public void OnPost()
        {
            Entrees = Menu.Search(Menu.Entrees, SearchTerms);
            Entrees = Menu.FilterByCategory(Entrees, OrderTypes);
            Entrees = Menu.FilterByPrice(Entrees, MaxPrice, MinPrice);
            Entrees = Menu.FilterByCalories(Entrees, MaxCalorie,MinCalorie);

            Drinks = Menu.Search(Menu.Drinks, SearchTerms);
            Drinks = Menu.FilterByCategory(Drinks, OrderTypes);
            Drinks = Menu.FilterByPrice(Drinks, MaxPrice, MinPrice);
            Drinks = Menu.FilterByCalories(Drinks, MaxCalorie, MinCalorie);

            Sides = Menu.Search(Menu.Sides, SearchTerms);
            Sides = Menu.FilterByCategory(Sides, OrderTypes);
            Sides = Menu.FilterByPrice(Sides, MaxPrice, MinPrice);
            Sides = Menu.FilterByCalories(Sides, MaxCalorie, MinCalorie);
        }
    }
}
