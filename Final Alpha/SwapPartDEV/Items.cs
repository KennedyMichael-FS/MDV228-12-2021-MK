using System;
using System.Collections.Generic;

namespace SwapPartDEV
{
    public class Items
    {
        public string ItemImg = "https://i.ibb.co/qRYk4mY/Processor.png";
        public string ItemName { get; set; }

    }

    public class ItemData
    {
        public static List<Items> Get()
        {
            return new List<Items>
            {
                new Items(){ItemName="Item 1"},
                new Items(){ItemName="Item 2"},
                new Items(){ItemName="Item 3"},
                new Items(){ItemName="Item 4"},
                new Items(){ItemName="Item 5"},
                new Items(){ItemName="Item 6"}

            };
        }
    }
}