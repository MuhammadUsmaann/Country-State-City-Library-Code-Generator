using Dapper;
using MU.Location;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace MU.Location
{
   
    public class DBHandler
    {
        private IDbConnection _connection;

        public IEnumerable<Country> GetCountryList()
        {
            string query = " select * from countries ";
            return Query<Country>(query);
        }

        public IEnumerable<State> GetStateList()
        {
            string query = "select states.name as Name, states.id as id,countries.id as CountryID from states "
                           + " join countries on countries.id = states.country_id ";

            return Query<State>(query);
        }

        public IEnumerable<City> GetCityList()
        {
            string query = "select cities.id as Id, cities.name as Name, cities.state_id as StateID,countries.id as CountryID from cities "
                           + " join states on states.id = cities.state_id "
                           + " join countries on countries.id = states.country_id ";

            return Query<City>(query);
        }

        private void OpenConnection()
        {
            try
            {
                var ConnectionString = @"Data Source=USMAN;Initial Catalog=CityDatabase;User ID=admin;Pwd=bitf10m030;Connect Timeout=15";
                _connection = new SqlConnection(ConnectionString);

                _connection.Open();
            }
            catch { }
        }
        private void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch { }
        }
        public IEnumerable<T> Query<T>(string sql)
        {
            try
            {
                OpenConnection();
                return SqlMapper.Query<T>(_connection, sql);
            }
            catch { }
            finally
            {
                OpenConnection();
            }
            return null;
        }
    }
}
