using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

namespace SwapPartDEV
{
    public partial class MainPage : ContentPage
    {

        // Set to false if signing up, set to true if signing in.
        public bool Login = false;

        public static List<User> Users = new List<User> { };

        public static User ActiveUser { get; set; }

        public MainPage()
        {

            BackgroundImageSource = "https://i.ibb.co/61pDNkf/bgimg.jpg";

            InitializeComponent();

            signInButton.Pressed += signInButton_Pressed;

            signUpButton.Pressed += signUpButton_Pressed;

            submitButton.Pressed += submitButton_Pressed;

            forgotPassword.Pressed += forgotPassword_Pressed;

        }

        void signUpButton_Pressed(System.Object sender, System.EventArgs e)
        {
            Login = false;

            signUpButton.TextColor = Color.FromHex("#FF8A00");
            signInButton.TextColor = Color.Black;

            splashText.Text = "Join SwapPart today to start trading!";

            firstName.IsVisible = true;
            lastName.IsVisible = true;
            retypePass.IsVisible = true;
            email.IsVisible = true;
        }

        void signInButton_Pressed(System.Object sender, System.EventArgs e)
        {
            Login = true;

            signInButton.TextColor = Color.FromHex("#FF8A00");
            signUpButton.TextColor = Color.Black;

            splashText.Text = "Welcome back to SwapPart!";

            firstName.IsVisible = false;
            lastName.IsVisible = false;
            retypePass.IsVisible = false;
            email.IsVisible = false;
        }

        async void submitButton_Pressed(System.Object sender, System.EventArgs e)
        {
            if (Login)
            {
                if (username.Text == null || password.Text == null)
                {
                    await DisplayAlert("Error", "One or more fields are empty. Please enter data in each field.", "OK");
                    return;
                }
                else
                {
                    if (AttemptLogin() == true)
                    {
                        Navigation.PushModalAsync(new HomeScreen());
                    }
                    else
                    {
                        await DisplayAlert("Error", "The username or password you have entered is incorrect. Please try again.", "OK");
                        return;
                    }
                }
            }
            if (Login == false)
            {
                if (firstName.Text == null || lastName.Text == null || email.Text == null || username.Text == null || password.Text == null || retypePass == null )
                {
                    await DisplayAlert("Error", "One or more fields are empty. Please enter data in each field.", "OK");
                    return;
                }
                if (password.Text != retypePass.Text)
                {
                    await DisplayAlert("Error", "The passwords you have entered do not match. Please re-enter your password in both fields.", "OK");
                    return;
                }
                if (!email.Text.Contains("@"))
                {
                    await DisplayAlert("Error", "The Email Address you have entered is invalid. Please try again.", "OK");
                    return;
                }

                CreateAccount();

                
                Navigation.PushModalAsync(new HomeScreen());

            }
        }

        public bool AttemptLogin()
        {
            foreach (User user in Users)
            {
                if (user.Username == username.Text)
                {
                    if (user.Password == password.Text)
                    {
                        ActiveUser = user;
                        return true;
                    }
                }
            }

            return false;
        }

        public void CreateAccount()
        {
            User newUser = new User();

            newUser.Username = username.Text;
            newUser.FirstName = firstName.Text;
            newUser.LastName = lastName.Text;
            newUser.Email = email.Text;
            newUser.Password = password.Text;

            Users.Add(newUser);

            ActiveUser = newUser;

            RefreshUserDatabase();

        }

        public void RefreshUserDatabase()
        {

            foreach (User user in Users)
            {
                using (StreamWriter sw = new StreamWriter(File.Create(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + "logindatabase.txt"))) // Creates new writer object
                {

                    // String below is what is written to the text file.
                    string toWrite = $"{user.Username} | {user.Email} | {user.Password} | {user.FirstName} | {user.LastName}";

                    // Write.
                    sw.WriteLine(toWrite);

                    return;
                }
            }

        }

        void forgotPassword_Pressed(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Forgot Password", "Password Hint: Hint", "OK");
        }
    }
}
