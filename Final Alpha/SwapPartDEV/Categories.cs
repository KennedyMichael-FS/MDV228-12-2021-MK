using System;
using System.Collections.Generic;

namespace SwapPartDEV
{
    public class Categories
    {
        public string CategoryImg = "https://i.ibb.co/qRYk4mY/Processor.png";
        public string Category { get; set; }

    }

    public class CategoryData
    {
        public static List<Categories> Get()
        {
            return new List<Categories>
            {
                new Categories(){Category="Processors"},
                new Categories(){Category="Graphics Cards"},
                new Categories(){Category="Displays"},
                new Categories(){Category="Storage"},
                new Categories(){Category="Networking"},
                new Categories(){Category="Peripherals"}

            };
        }
    }
}
