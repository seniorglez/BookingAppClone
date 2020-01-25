using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace BookingAppClone
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyMenu();
        }
        
        public void MyMenu()
        {
            Detail = new Feed();
            List<Menu> menus = new List<Menu>
            {
                new Menu{Page=new Feed(), MenuTitle="Reservas", icon="magnifier.png"},
                new Menu{Page=new Feed(), MenuTitle="Ofertas", icon="magnifier.png"},
                new Menu{Page=new Feed(), MenuTitle="Listas", icon="magnifier.png"},
                new Menu{Page=new Feed(), MenuTitle="Alquiler de coches", icon="magnifier.png"},
                new Menu{Page=new Feed(), MenuTitle="My reviews", icon="magnifier.png"},
                new Menu{Page=new Feed(), MenuTitle="Reservar taxi eropuerto", icon="magnifier.png"},
                new Menu{Page=new Feed(), MenuTitle="Comunidades de viajeros", icon="magnifier.png"},
                new Menu{Page=new Feed(), MenuTitle="Articulos de viajes", icon="magnifier.png"},
                new Menu{Page=new Feed(), MenuTitle="Registra tu alojamiento", icon="magnifier.png"},
                new Menu{Page=new Feed(), MenuTitle="Invita a un amigo a ser anfitrion", icon="magnifier.png"},
                new Menu{Page=new Feed(), MenuTitle="Mis códigos de descuento", icon="magnifier.png"}
            };
            ListMenu.ItemsSource = menus;


        }
        private void ItemSelectedListMenu(object sender, SelectedItemChangedEventArgs e)
        {
            Detail =((Menu)e.SelectedItem).Page;
        }
    }
}

