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
                new Menu{Page=new Feed(), MenuTitle="Reservas", icon="cardtravel.png"},
                new Menu{Page=new Page404(), MenuTitle="Ofertas", icon="world.png"},
                new Menu{Page=new Page404(), MenuTitle="Listas", icon="like.png"},
                new Menu{Page=new Page404(), MenuTitle="Alquiler de coches", icon="car.png"},
                new Menu{Page=new Page404(), MenuTitle="My reviews", icon="review.png"},
                new Menu{Page=new Page404(), MenuTitle="Reservar taxi eropuerto", icon="plane.png"},
                new Menu{Page=new Page404(), MenuTitle="Comunidades de viajeros", icon="com.png"},
                new Menu{Page=new Page404(), MenuTitle="Articulos de viajes", icon="articles.png"},
                new Menu{Page=new Page404(), MenuTitle="Registra tu alojamiento", icon="plus.png"},
                new Menu{Page=new Page404(), MenuTitle="Invita a un amigo a ser anfitrion", icon="house.png"},
                new Menu{Page=new Page404(), MenuTitle="Mis códigos de descuento", icon="tag.png"}
            };
            ListMenu.ItemsSource = menus;


        }
        private void ItemSelectedListMenu(object sender, SelectedItemChangedEventArgs e)
        {
            Detail =((Menu)e.SelectedItem).Page;
        }
    }
}

