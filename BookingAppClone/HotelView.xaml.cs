using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BookingAppClone
{
    public partial class HotelView : ContentPage
    {
        public HotelView()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RoomPage());
        }
    }
}
