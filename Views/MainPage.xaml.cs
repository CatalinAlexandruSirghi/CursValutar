using CursValutar.Models;
using CursValutar.Services;

namespace CursValutar.Views
{
    public partial class MainPage : ContentPage
    {
        private List<Curs> listaValute = new List<Curs>();

        public MainPage()
        {
            InitializeComponent();
            listaValute = CursBNRService.ObtineCurs("https://bnr.ro/nbrfxrates.xml");
            ListViewCurs.ItemsSource = listaValute;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }

}
