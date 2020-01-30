using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BookingAppClone
{
    public partial class SearchTab : ContentPage
    {
        public SearchTab()
        {
            InitializeComponent();
        }

        private async void SearchButton_Clicked(System.Object sender, System.EventArgs e)
        {
            SearchModel sm = new SearchModel
            {
                City = CityEntry.Text,
                Date1 = DatePikerA.Date.ToShortDateString(),
                Date2 = DatePikerB.Date.ToShortDateString()
            };
            SearchResults sr = new SearchResults();
            sr.BindingContext = sm;
            await Navigation.PushAsync(sr);
        }
    }
    internal class SearchModel
    {
        public String City { get; set; }
        public String Date1 { get; set; }
        public String Date2 { get; set; }
        public String Habitaciones { get; set; }
    }
}
