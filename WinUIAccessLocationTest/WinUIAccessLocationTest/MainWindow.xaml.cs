using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Windows.Devices.Geolocation;

// The Blank Window item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WinUIAccessLocationTest
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            var access = await Geolocator.RequestAccessAsync();
            if (access == GeolocationAccessStatus.Allowed)
            {
                var locator = new Geolocator();
                var location = await locator.GetGeopositionAsync();
                myText.Text = location.Coordinate.ToString();
            }
            myButton.Content = "Clicked";
        }
    }
}
