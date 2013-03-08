using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BobaBusinessLayer;

namespace BobaBusinessLayer
{
	public class Drink
	{
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Flavor Flavor { get; set; }
        public string ImageURL { get; set; }
        public List<DrinkCategory> DrinkCategories { get; set; }
        //TODO: Add ingredients
	}
}
