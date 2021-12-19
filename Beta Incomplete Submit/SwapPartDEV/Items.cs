using System;
using System.Collections.Generic;

namespace SwapPartDEV
{
    public class Items
    {
        public string ItemImg = "https://i.ibb.co/qRYk4mY/Processor.png"; // Default item image (in case of an internal category issue)
        public string ItemName { get; set; }

    }

    public class ItemData
    {
        public static List<Items> Get()
        {

            if (ItemsView.CategoryNum == 1) // Processors
            {
                return new List<Items>
                {
                new Items(){ItemName="AMD Ryzen 3"},
                new Items(){ItemName="Intel Core i3"},
                new Items(){ItemName="Intel Core i9"},
                new Items(){ItemName="AMD Athlon II"},
                new Items(){ItemName="AMD Threadripper"},
                new Items(){ItemName="Intel Xeon"}

                };
            }
            if (ItemsView.CategoryNum == 2) // GPU
            {
                return new List<Items>
                {
                new Items(){ItemName="AMD Radeon 5600"},
                new Items(){ItemName="NVIDIA GeForce 2080Ti"},
                new Items(){ItemName="NVIDIA GeForce 1650Ti"},

                };
            }
            if (ItemsView.CategoryNum == 3) // Storage
            {
                return new List<Items>
                {
                new Items(){ItemName="Item 1"},
                new Items(){ItemName="Item 2"},
                new Items(){ItemName="Item 3"},
                new Items(){ItemName="Item 4"},

                };
            }
            if (ItemsView.CategoryNum == 4) // Displays
            {
                return new List<Items>
                {
                new Items(){ItemName="Item 1"},
                new Items(){ItemName="Item 2"},
                new Items(){ItemName="Item 3"},
                new Items(){ItemName="Item 4"},
                new Items(){ItemName="Item 5"},

                };
            }
            if (ItemsView.CategoryNum == 5) // Networking
            {
                return new List<Items>
                {
                new Items(){ItemName="Item 1"},
                new Items(){ItemName="Item 2"},
                new Items(){ItemName="Item 3"},

                };
            }
            if (ItemsView.CategoryNum == 6) // Peripherals
            {
                return new List<Items>
                {
                new Items(){ItemName="Item 1"},
                new Items(){ItemName="Item 2"},
                new Items(){ItemName="Item 3"},
                new Items(){ItemName="Item 4"},
                new Items(){ItemName="Item 5"},
                new Items(){ItemName="Item 6"},
                new Items(){ItemName="Item 7"}

                };
            }
            return new List<Items> // Only here to satisfy 'not all code paths return' error. Should NEVER reach this point, but avoids an app crash if it does.
            {
                new Items(){ItemName="Internal Error!"},

            };
        }
    }
}