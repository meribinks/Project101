using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BobaBusinessLayer;
using Boba.Models;

namespace Boba.Controllers
{
    public class DrinkMenuController : Controller
    {
        private List<Drink> _drinks = DrinkCollection.GetDrinks();

        public ActionResult Index()
        {
            MainCategoryModel model = new MainCategoryModel();

            Array enumCategories = Enum.GetValues(typeof(DrinkCategory));

            for (int i = 0; i < enumCategories.Length; i++)
                model.Add(new MainCategory { ID = i, Name = enumCategories.GetValue(i).ToString() });
            
            return View(model);
        }

        public ActionResult DrinkSelection(string drinkID)
        {
            DrinksModel model = new DrinksModel();
            
            foreach (var item in _drinks)
	        {
                model.Add(new DrinkModel{ID = item.ID, 
                    Description = item.Description, 
                    Flavor = item.Flavor, 
                    ImageURL = item.ImageURL, 
                    Name= item.Name});
            }

            return View(model);
        }

    }
}
