using CursValutar.Data;
using CursValutar.Services;

namespace CursValutar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CursDao cursDao = new();

            cursDao.StergeInregistrari();
            cursDao.AdaugaCurs(CursBNRService.ObtineCurs(Constante.URL_CURS_BNR_10_ZILE));

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}