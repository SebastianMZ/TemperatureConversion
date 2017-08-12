using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TemperatureConversion
{
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ConvertToCsButton.Clicked += ConvertToCsButton_Clicked;
            ConvertToFhButton.Clicked += ConvertToFhButton_Clicked;

        }

        void ConvertToCsButton_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty((DegreesEntry.Text)))
            {
                DisplayAlert("Error", "You must enter a value in Fahrenheit degrees..", "Accept");
                return;
            }

            decimal degrees = 0;
            if (!decimal.TryParse(DegreesEntry.Text, out degrees))
            {
                DisplayAlert("Error", "You must enter a value numeric in degrees of temperature..", "Accept");
                DegreesEntry.Text = null;
                return;
            }
            var celsius = (degrees - 32) / 1.8M;
            CelsiusEntry.Text = string.Format("{0:C2}", celsius);

        }

        void ConvertToFhButton_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty((DegreesEntry.Text)))
            {
                DisplayAlert("Error", "You must enter a value in Celsius degrees..", "Accept");
                return;
            }

            double degrees = 0;
            if (!double.TryParse(DegreesEntry.Text, out degrees))
            {
                DisplayAlert("Error", "You must enter a value numeric in degrees of temperature..", "Accept");
                DegreesEntry.Text = null;
                return;
            }
            double fahrenheit = (degrees * 1.8) + 32D;
            FahrenheitEntry.Text = string.Format("{0:C2}", fahrenheit);

        }
    }
}