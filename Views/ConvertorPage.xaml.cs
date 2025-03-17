using CursValutar.Models;
using CursValutar.Services;

namespace CursValutar.Views;

public partial class ConvertorPage : ContentPage
{
    List<Curs> listaValute;
    public ConvertorPage()
    {
        InitializeComponent();

        listaValute = CursBNRService.ObtineCurs("https://bnr.ro/nbrfxrates.xml");
        listaValute.Add(new Curs
        {
            Valuta = "RON",
            Valoare = 1,
            Multiplicator = 1
        });
        PickerDestinatie.ItemsSource = listaValute;
        PickerSursa.ItemsSource = listaValute;
        PickerSursa.SelectedIndex = 0;
        PickerDestinatie.SelectedIndex = 0;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //TODO preluare valuta sursa (EUR -> 4.97 RON)
        //Preluare valuta destinatie
        //Preluare suma de convertit
        //Efectuare conversie
        //Afisare rezultat

    }
}