using CursValutar.ViewModels;
using Microcharts;

namespace CursValutar.Views;

public partial class IstoricPage : ContentPage
{
    private IstoricViewModel _viewModel;
    public IstoricPage(IstoricViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;

        if(PickerValute.Items.Count > 0)
        {
            PickerValute.SelectedIndex = 0;
        }
    }

    private void PickerValute_SelectedIndexChanged(object sender, EventArgs e)
    {
        _viewModel.AfiseazaGrafic();
    }
}