using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BookingAppClone
{
    public partial class Feed : ContentPage
    {
        public Feed()
        {
            InitializeComponent();
        }

        private async void SearchButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SearchResults());
        }
    }
}
