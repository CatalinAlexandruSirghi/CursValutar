using Microcharts;

namespace CursValutar.Views;

public partial class IstoricPage : ContentPage
{
    public IstoricPage()
    {
        InitializeComponent();

        List<ChartEntry> chartEntries = [];

        chartEntries.Add(new ChartEntry(10));
        chartEntries.Add(new ChartEntry(20));
        chartEntries.Add(new ChartEntry(30));
        ChartViewValuta.Chart = new LineChart()
        {
            Entries = chartEntries
        };
    }
}