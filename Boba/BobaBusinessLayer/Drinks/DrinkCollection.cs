using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;

namespace BobaBusinessLayer
{
    public class  DrinkCollection
    {
        public static List<Drink> GetDrinks()
        {
            var result = new List<Drink>();

            Flavors f = new Flavors();
            f.FlavorLookup = f.GetFlavors();


            //TODO: Access from database

            result.Add(new Drink { ID = 0, 
                Name = "blueberry", 
                Flavor = f.FlavorLookup.Where(fl => fl.Name.Equals("blueberry")).First(),
                ImageURL = "http://dummyimage.com/200x200/001eff/fff.jpg&text=" + "blueberry", 
                DrinkCategories = new List<DrinkCategory>()
                    {DrinkCategory.FruitTea, 
                    DrinkCategory.Slush, 
                    DrinkCategory.Snow, 
                    DrinkCategory.Yogurt}
            });

            result.Add(new Drink
            {
                ID = 1,
                Name = "mango",
                Flavor = f.FlavorLookup.Where(fl => fl.Name.Equals("mango")).First(),
                ImageURL = "http://dummyimage.com/200x200/ffff0/fff.jpg&text=" + "mango",                
                DrinkCategories = new List<DrinkCategory>()
                    {DrinkCategory.FruitTea, 
                    DrinkCategory.BlendedMilkTea,
                    DrinkCategory.IcedMilkTea,
                    DrinkCategory.Slush, 
                    DrinkCategory.Snow, 
                    DrinkCategory.Yogurt}
            });

            result.Add(new Drink
            {
                ID = 2,
                Name = "grape",
                Flavor = f.FlavorLookup.Where(fl => fl.Name.Equals("grape")).First(),
                ImageURL = "http://dummyimage.com/200x200/6e3c99/fff.jpg&text=" + "grape",
                DrinkCategories = new List<DrinkCategory>()
                    {DrinkCategory.FruitTea, 
                    DrinkCategory.BlendedMilkTea,
                    DrinkCategory.IcedMilkTea,
                    DrinkCategory.Slush, 
                    DrinkCategory.Snow}
            });

            //Populate Temporary Image
            foreach (var item in result)
            {
                item.Description = string.Format("Fresh {0} blended with lemon vodka, lime juice, and Cointreau makes a refreshing drink.", item.Name);
            }

            return result;
        }
    }
}
