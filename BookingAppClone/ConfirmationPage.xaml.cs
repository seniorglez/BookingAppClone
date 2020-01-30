using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BookingAppClone
{
    public partial class ConfirmationPage : ContentPage
    {
        public ConfirmationPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Hey", "Acabas de confirmar tu reserva, muchas gracias","ok") ;
        }
    }
}
