namespace CursValutar.Views;

public partial class ConvertorPage : ContentPage
{
    List<string> listaValute = [ "EUR", "RON"];
    public ConvertorPage()
    {
        InitializeComponent();
        PickerDestinatie.ItemsSource = listaValute;
        PickerSursa.ItemsSource = listaValute;
        
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