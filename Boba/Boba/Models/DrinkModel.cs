using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using BobaBusinessLayer;

namespace Boba.Models
{
    public class DrinksModel : List<DrinkModel>
    {
        
    }

    public class DrinkModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Flavor Flavor { get; set; }
        public string ImageURL { get; set; }
        public List<DrinkCategory> DrinkCategories { get; set; }
    }
}