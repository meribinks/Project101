using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boba.Models
{
    public class MainCategoryModel : List<MainCategory>
    {
        
    }

    public class MainCategory
    {

        public int ID { get; set; }
        public string Name { get; set; }
    }
}