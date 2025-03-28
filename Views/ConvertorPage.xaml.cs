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
        var cursSursa = PickerSursa.SelectedItem as Curs;
        var cursDestinatie = PickerDestinatie.SelectedItem as Curs;

        var suma = Convert.ToDouble(EntrySuma.Text);
        EntryRezultat.Text = ((cursSursa?.Valoare * suma) / cursDestinatie?.Valoare)?.ToString("N5");
    }
}