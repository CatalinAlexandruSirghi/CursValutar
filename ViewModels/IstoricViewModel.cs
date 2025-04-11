using CursValutar.Data;
using CursValutar.Models;
using Microcharts;
using Microcharts.Maui;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CursValutar.ViewModels
{
    public class IstoricViewModel : INotifyPropertyChanged
    {
        private CursDao _cursDao;
        private Chart _chartIstoric;

        public List<string> Valute { get; set; }
        public string ValutaCurenta { get; set; }
        public Chart ChartIstoric
        {
            get { return _chartIstoric; }
            set
            {
                _chartIstoric = value;
                OnPropertyChanged(nameof(ChartIstoric));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public IstoricViewModel(CursDao cursDao)
        {
            Valute = cursDao.ObtineValute();
            _cursDao = cursDao;
        }

        public void AfiseazaGrafic()
        {
            List<ChartEntry> date = [];

            List<Curs> listaCurs = _cursDao.ObtineCursValuta(ValutaCurenta);

            date.AddRange(listaCurs.Select(c => new ChartEntry((float)c.Valoare) { Label = c.Data, ValueLabel = c.Valoare.ToString() }).ToList());

            ChartIstoric = new LineChart() { Entries = date };
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
