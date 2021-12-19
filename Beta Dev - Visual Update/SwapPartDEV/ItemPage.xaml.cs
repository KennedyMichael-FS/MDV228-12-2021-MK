using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwapPartDEV
{
    public partial class ItemPage : ContentPage
    {
        public ItemPage()
        {
            BackgroundImageSource = "https://i.ibb.co/61pDNkf/bgimg.jpg";

            InitializeComponent();
            backButton.Pressed += BackButton_Pressed;

        }

        private void BackButton_Pressed(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
