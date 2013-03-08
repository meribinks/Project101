using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BobaBusinessLayer
{
    public class Flavors
    {
        public List<Flavor> FlavorLookup { get; set; }

        public List<Flavor> GetFlavors()
        {
            var result = new List<Flavor>();

            //TODO: Go to database
            result.Add(new Flavor { ID = 1, Name = "blueberry" });
            result.Add(new Flavor { ID = 2, Name = "grape" });
            result.Add(new Flavor { ID = 3, Name = "green apple" });
            result.Add(new Flavor { ID = 4, Name = "honeydew" });
            result.Add(new Flavor { ID = 5, Name = "kiwi" });
            result.Add(new Flavor { ID = 6, Name = "lavander" });
            result.Add(new Flavor { ID = 7, Name = "lemon" });
            result.Add(new Flavor { ID = 8, Name = "lychee" });
            result.Add(new Flavor { ID = 9, Name = "mango" });
            result.Add(new Flavor { ID = 10, Name = "orange" });
            result.Add(new Flavor { ID = 11, Name = "passion fruit" });
            result.Add(new Flavor { ID = 12, Name = "peach" });
            result.Add(new Flavor { ID = 13, Name = "plum" });
            result.Add(new Flavor { ID = 14, Name = "rose" });
            result.Add(new Flavor { ID = 15, Name = "strawberry" });
            result.Add(new Flavor { ID = 16, Name = "watermelon" });
            result.Add(new Flavor { ID = 17, Name = "pineapple" });
            result.Add(new Flavor { ID = 18, Name = "raspberry" });
            result.Add(new Flavor { ID = 19, Name = "papaya" });


            return result;
        }
    }
}
