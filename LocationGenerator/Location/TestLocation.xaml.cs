using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MU.Location
{
    /// <summary>
    /// Interaction logic for TestLocation.xaml
    /// </summary>
    public partial class TestLocation : Window, INotifyPropertyChanged
    {
        List<DisplayValues> _countries;
        List<DisplayValues> _states;
        List<DisplayValues> _cities;
        LocationHandler handler = new LocationHandler();

        public event PropertyChangedEventHandler PropertyChanged;
        public TestLocation()
        {
            InitializeComponent();
            this.DataContext = this;
            CountryList = MakeVisible<Country>(handler.GetCountryList());
        }

        private List<DisplayValues> MakeVisible<T>(List<T> SourceList)
        {
            List<DisplayValues> list = new List<DisplayValues>();

            foreach (T item in SourceList)
            {
                DisplayValues temp = null;
                
                if (item is City)
                    temp = new DisplayValues { DisplayID = (item as City).Id, DisplayName = (item as City).Name };
                if (item is State)
                    temp = new DisplayValues { DisplayID = (item as State).Id, DisplayName = (item as State).Name };
                if (item is Country)
                    temp = new DisplayValues { DisplayID = (item as Country).Id, DisplayName = (item as Country).Name };

                list.Add(temp);
            }

            return list;
        }

        public List<DisplayValues> CountryList
        {
            get
            {
                return _countries;
            }
            set
            {
                _countries = value;
                NotifyPropertyChanged("CountryList");
            }
        }
        public List<DisplayValues> StateList
        {
            get
            {
                return _states;
            }
            set
            {
                _states = value;
                NotifyPropertyChanged("StateList");
            }
        }
        public List<DisplayValues> CityList
        {
            get
            {
                return _cities;
            }
            set
            {
                _cities = value;
                NotifyPropertyChanged("CityList");
            }
        }

        int cid;
        int sid;
        public int SelectedCountry{ get{return sid;} set{sid = value ;NotifyPropertyChanged("SelectedCountry");} }
        public int SelectedState{ get{return cid;} set{cid = value ;NotifyPropertyChanged("SelectedState");} }
        public void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void country_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StateList = MakeVisible<State>( handler.GetStateListByCountryID(SelectedCountry));
        }

        private void state_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CityList = MakeVisible<City>( handler.GetCityListByStateID(SelectedState));
        }

        
    }
    public class DisplayValues
    {
        public int DisplayID { get; set; }
        public string DisplayName { get; set; }
    }
}
