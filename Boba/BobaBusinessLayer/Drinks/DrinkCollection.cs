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

            result.Add(new Drink { ID = 1, 
                Name = "blueberry", 
                Flavor = f.FlavorLookup.Where(fl => fl.Name.Equals("blueberry")).First(),
                DrinkCategories = new List<DrinkCategory>()
                    {DrinkCategory.FruitTea, 
                    DrinkCategory.Slush, 
                    DrinkCategory.Snow, 
                    DrinkCategory.Yogurt}
            });

            result.Add(new Drink
            {
                ID = 2,
                Name = "mango",
                Flavor = f.FlavorLookup.Where(fl => fl.Name.Equals("mango")).First(),
                DrinkCategories = new List<DrinkCategory>()
                    {DrinkCategory.FruitTea, 
                    DrinkCategory.BlendedMilkTea,
                    DrinkCategory.IcedMilkTea,
                    DrinkCategory.Slush, 
                    DrinkCategory.Snow, 
                    DrinkCategory.Yogurt}
            });
      

            //Populate Temporary Image
            foreach (var item in result)
            {
                item.ImageURL = "http://dummyimage.com/200x200/215/fff.jpg&text=" + item.Name;
                item.Description = string.Format("Fresh {0} blended with lemon vodka, lime juice, and Cointreau makes a refreshing drink.", item.Name);
            }

            return result;
        }
    }
}
