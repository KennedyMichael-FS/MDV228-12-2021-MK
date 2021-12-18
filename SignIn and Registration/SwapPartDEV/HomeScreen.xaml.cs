using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SwapPartDEV
{
    public partial class HomeScreen : ContentPage
    {
        public HomeScreen()
        {
            InitializeComponent();

            personalizedWelcome.Text = $"Welcome, {MainPage.ActiveUser.FirstName}! ({MainPage.ActiveUser.Username})"; // Personalized message with active user's information.
        }

        void signOut_Pressed(System.Object sender, System.EventArgs e)
        {

            MainPage.ActiveUser = null; // Active user is null (no active user, signed out app state)

            Navigation.PushModalAsync(new MainPage());

        }
    }
}
