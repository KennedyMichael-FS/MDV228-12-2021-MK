using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Threading;

namespace SwapPartAPITest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();

        }

        public void convertPressed_Clicked(Object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(toConvert.Text);

            API api = new API();

            api.GetConversion(amount);

            result.Text = (Currency.Rate * amount).ToString();

        }


    }
}
