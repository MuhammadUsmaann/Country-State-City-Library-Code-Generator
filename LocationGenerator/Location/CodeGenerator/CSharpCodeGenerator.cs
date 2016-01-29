using System.Collections.Generic;
using System.Text;

namespace MU.Location
{
    public class CSharpCodeGenerator : ICodeGenerator
    {
        public string GeneratorCode()
        {
            DBHandler _db = new DBHandler();

            IEnumerable<Country> countryList = _db.GetCountryList();
            IEnumerable<State> stateList = _db.GetStateList();
            IEnumerable<City> cityList = _db.GetCityList();

            StringBuilder sb = new StringBuilder();



            sb.Append("\nusing System;");
            sb.Append("\nusing System.Collections.Generic;");

            sb.Append("\n\n namespace MU.Location" );
            sb.Append("\n {");
            sb.Append("\n\tpublic partial class LocationHandler");
            sb.Append("\n\t{");
            sb.Append("\n\t\tDictionary<int, Country> _countries;");
            sb.Append("\n\t\tDictionary<int, State> _states;");
            sb.Append("\n\t\tDictionary<int, City> _cities;");


            #region Country Region

            sb.Append("\n\n\t\t#region Country Region");

            sb.Append("\n\n\t\t public List<Country> GetCountryList(){");
            sb.Append("\n\t\t\tList<Country> list = new List<Country>();");
            sb.Append("\n\t\t\tforeach (var item in CountryList){");
            sb.Append("\n\t\t\t\tlist.Add(item.Value);");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn list;");
            sb.Append("\n\t\t}");


            sb.Append("\n\n\t\tpublic Country GetCountryByID(int id){");
            sb.Append("\n\t\t\tforeach (var item in CountryList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.Id == id){");
            sb.Append("\n\t\t\t\t\treturn item.Value;");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn null;");
            sb.Append("\n\t\t}");


            sb.Append("\n\n\t\tpublic Country GetCountryByName(string name){");
            sb.Append("\n\t\t\tforeach (var item in CountryList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.Name == name){");
            sb.Append("\n\t\t\t\t\treturn item.Value;");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn null;");
            sb.Append("\n\t\t}");

            sb.Append("\n\n\t\tpublic List<Country> GetCountryByNameMatch(string name){");
            sb.Append("\n\t\t\tList<Country> SelectedValue = new List<Country>();");
            sb.Append("\n\t\t\tforeach (var item in CountryList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.Name.Contains(name)){");
            sb.Append("\n\t\t\t\t\t SelectedValue.Add(item.Value);");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn SelectedValue.Count > 0 ? SelectedValue : null;");
            sb.Append("\n\t\t}");

            sb.Append("\n\n\t\tpublic Country GetCountryBySortName(string code){");
            sb.Append("\n\t\t\tforeach (var item in CountryList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.SortName == code){");
            sb.Append("\n\t\t\t\t\treturn item.Value;");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn null;");
            sb.Append("\n\t\t}");

            sb.Append("\n\t\t#endregion");

            #endregion

            #region State Region

            sb.Append("\n\n\t\t#region State Region");

            sb.Append("\n\n\t\tpublic State GetStateByID(int id){");
            sb.Append("\n\t\t\tforeach (var item in StateList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.Id == id){");
            sb.Append("\n\t\t\t\t\treturn item.Value;");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn null;");
            sb.Append("\n\t\t}");



            sb.Append("\n\n\t\tpublic State GetStateByName(string name){");
            sb.Append("\n\t\t\tforeach (var item in StateList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.Name == name){");
            sb.Append("\n\t\t\t\t\treturn item.Value;");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn null;");
            sb.Append("\n\t\t}");

            sb.Append("\n\n\t\tpublic List<State> GetStateByNameMatch(string name){");
            sb.Append("\n\t\t\tList<State> SelectedValue = new List<State>();");
            sb.Append("\n\t\t\tforeach (var item in StateList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.Name.Contains(name)){");
            sb.Append("\n\t\t\t\t\t SelectedValue.Add(item.Value);");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn SelectedValue.Count > 0 ? SelectedValue : null;");
            sb.Append("\n\t\t}");


            sb.Append("\n\n\t\tpublic List<State> GetStateListByCountryID(int id){");
            sb.Append("\n\t\t\tList<State> SelectedValue = new List<State>();");
            sb.Append("\n\t\t\tforeach (var item in StateList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.CountryID == id){");
            sb.Append("\n\t\t\t\t\t SelectedValue.Add(item.Value);");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn SelectedValue.Count > 0 ? SelectedValue : null;");
            sb.Append("\n\t\t}");

            sb.Append("\n\t\t#endregion");

            #endregion

            #region City Region

            sb.Append("\n\n\t\t#region City Region");

            sb.Append("\n\n\t\tpublic City GetCityByID(int id){");
            sb.Append("\n\t\t\tforeach (var item in CityList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.Id == id){");
            sb.Append("\n\t\t\t\t\treturn item.Value;");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn null;");
            sb.Append("\n\t\t}");



            sb.Append("\n\n\t\tpublic City GetCityByName(string name){");
            sb.Append("\n\t\t\tforeach (var item in CityList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.Name == name){");
            sb.Append("\n\t\t\t\t\treturn item.Value;");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn null;");
            sb.Append("\n\t\t}");

            sb.Append("\n\n\t\tpublic List<City> GetCityByNameMatch(string name){");
            sb.Append("\n\t\t\tList<City> SelectedValue = new List<City>();");
            sb.Append("\n\t\t\tforeach (var item in CityList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.Name.Contains(name)){");
            sb.Append("\n\t\t\t\t\t SelectedValue.Add(item.Value);");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn SelectedValue.Count > 0 ? SelectedValue : null;");
            sb.Append("\n\t\t}");

            sb.Append("\n\n\t\tpublic List<City> GetCityListByStateID(int id){");
            sb.Append("\n\t\t\tList<City> SelectedValue = new List<City>();");
            sb.Append("\n\t\t\tforeach (var item in CityList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.StateID == id){");
            sb.Append("\n\t\t\t\t\t SelectedValue.Add(item.Value);");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn SelectedValue.Count > 0 ? SelectedValue : null;");
            sb.Append("\n\t\t}");

            sb.Append("\n\n\t\tpublic List<City> GetCityListByCountryID(int id){");
            sb.Append("\n\t\t\tList<City> SelectedValue = new List<City>();");
            sb.Append("\n\t\t\tforeach (var item in CityList){");
            sb.Append("\n\t\t\t\tif (item.Value != null && item.Value.CountryID == id){");
            sb.Append("\n\t\t\t\t\t SelectedValue.Add(item.Value);");
            sb.Append("\n\t\t\t\t}");
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn SelectedValue.Count > 0 ? SelectedValue : null;");
            sb.Append("\n\t\t}");

            sb.Append("\n\t\t#endregion");

            #endregion

            #region Country List Generator

            sb.Append("\n\n\t\t#region Country List Generator");

            sb.Append("\n\t\tpublic Dictionary<int, Country> CountryList{");
            sb.Append("\n\t\t\tget{");
            sb.Append("\n\t\t\tif (_countries == null){");
            sb.Append("\n\t\t\t\t_countries = new Dictionary<int, Country>();");

            foreach (var country in countryList)
            {
                sb.Append("\n\t\t\t\t_countries.Add(" + country.Id + ", new Country { Id = " + country.Id + ", Name = \"" + country.Name + "\" , SortName = \"" + country.SortName + "\"});");
            }
            
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn _countries;");
            sb.Append("\n\t\t}");
            sb.Append("\n\t}");

            sb.Append("\n\t#endregion");

            #endregion

            #region State List Generator
            sb.Append("\n\n\t\t#region State List Generator");

            sb.Append("\n\n\t\tpublic Dictionary<int, State> StateList{");
            sb.Append("\n\t\t\tget{");
            sb.Append("\n\t\t\tif (_states == null){");
            sb.Append("\n\t\t\t\t_states = new Dictionary<int, State>();");
            
            foreach (var state in stateList)
            {
                sb.Append("\n\t\t\t\t_states.Add(" + state.Id + ", new State { Id = " + state.Id + ", Name = \"" + state.Name + "\", CountryID = " + state.CountryID + " });");
            }
            
            
            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn _states;");
            sb.Append("\n\t\t}");
            sb.Append("\n\t}");

            sb.Append("\n\t\t#endregion");
            #endregion

            #region City List Generator
            sb.Append("\n\n\t\t#region City List Generator");

            sb.Append("\n\n\t\tpublic Dictionary<int, City> CityList{");
            sb.Append("\n\t\t\tget{");
            sb.Append("\n\t\t\tif (_cities == null){");
            sb.Append("\n\t\t\t_cities = new Dictionary<int, City>();");

            foreach (var city in cityList)
            {
                sb.Append("\n\t\t\t_cities.Add(" + city.Id + ", new City { Id = " + city.Id + ", Name = \"" + city.Name + "\", CountryID = " + city.CountryID + ", StateID = " + city.StateID + " });");
            }


            sb.Append("\n\t\t\t}");
            sb.Append("\n\t\t\treturn _cities;");
            sb.Append("\n\t\t}");
            sb.Append("\n\t}");

            sb.Append("\n\t\t#endregion");
            #endregion
            

            
            sb.Append("\n\t}");
            sb.Append("\n }");

            return sb.ToString();
        }
    }
}
