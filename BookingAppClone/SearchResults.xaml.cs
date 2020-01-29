using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BookingAppClone
{
    public partial class SearchResults : ContentPage
    {
        public SearchResults()
        {
            InitializeComponent();
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HotelView());
        }
    }
}
