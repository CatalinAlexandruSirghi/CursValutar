using CursValutar.Data;
using CursValutar.Models;
using CursValutar.Services;

namespace CursValutar.Views
{
    public partial class MainPage : ContentPage
    {
        private List<Curs> listaValute = new List<Curs>();
        private CursDao cursDao = new CursDao();
        public MainPage()
        {
            InitializeComponent();

            //TODO adjsut date to take the fxrate right
            listaValute = cursDao.ObtineCursDinData(DateTime.Now.ToString("yyyy-MM-dd"));

            if (listaValute.Count == 0)
            {
                listaValute = CursBNRService.ObtineCurs(Constante.URL_CURS_BNR);
                cursDao.AdaugaCurs(listaValute);
            }
            
            
            if (listaValute.Count > 0)
            {
                BindingContext = listaValute[0];
            }

            ListViewCurs.ItemsSource = listaValute;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }

}
