using System;
using System.Collections.Generic;

namespace SwapPartDEV
{
    public class Categories
    {
        public string CategoryImg = "https://i.ibb.co/qRYk4mY/Processor.png";
        public string Category { get; set; }
        public int CategoryNum { get; set; }

    }

    public class CategoryData
    {
        public static List<Categories> Get()
        {
            return new List<Categories>
            {
                new Categories(){Category="Processors", CategoryNum=1},
                new Categories(){Category="Graphics Cards", CategoryNum=2},
                new Categories(){Category="Displays", CategoryNum=4},
                new Categories(){Category="Storage", CategoryNum=3},
                new Categories(){Category="Networking", CategoryNum=5},
                new Categories(){Category="Peripherals", CategoryNum=6}

            };
        }
    }
}
