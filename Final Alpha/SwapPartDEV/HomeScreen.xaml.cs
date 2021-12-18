using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace SwapPartDEV
{
    public partial class HomeScreen : ContentPage
    {

        public ObservableCollection<Categories> AllCategory;

        public HomeScreen()
        {
            BackgroundImageSource = "https://i.ibb.co/61pDNkf/bgimg.jpg";

            InitializeComponent();
            this.AllCategory = new ObservableCollection<Categories>(CategoryData.Get());
            collectionView.SelectionMode = SelectionMode.Multiple;

            collectionView.SelectionChanged += CollectionView_SelectionChanged;
            logoutButton.Pressed += LogoutButton_Pressed;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = AllCategory;
        }

        void signOut_Pressed(System.Object sender, System.EventArgs e)
        {

            MainPage.ActiveUser = null; // Active user is null (no active user, signed out app state)

            Navigation.PushModalAsync(new MainPage());

        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigation.PushModalAsync(new ItemsView());

        }

        private void LogoutButton_Pressed(object sender, EventArgs e)
        {
            MainPage.ActiveUser = null; // Active user is null
            Navigation.PopModalAsync();
        }

    }
}
