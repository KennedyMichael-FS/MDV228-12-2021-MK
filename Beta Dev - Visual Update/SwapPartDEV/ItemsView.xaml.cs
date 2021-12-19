using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace SwapPartDEV
{
    public partial class ItemsView : ContentPage
    {
        public static int CategoryNum;
        public ObservableCollection<Items> AllItems;

        public ItemsView(int categorynum)
        {

            CategoryNum = categorynum;
            BackgroundImageSource = "https://i.ibb.co/61pDNkf/bgimg.jpg";

            InitializeComponent();
            this.AllItems = new ObservableCollection<Items>(ItemData.Get());
            collectionView.SelectionMode = SelectionMode.Single;

            collectionView.SelectionChanged += CollectionView_SelectionChanged;
            backButton.Pressed += BackButton_Pressed;

        }

        private void BackButton_Pressed(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = AllItems;
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            Navigation.PushModalAsync(new ItemPage());
        }
    }
}
