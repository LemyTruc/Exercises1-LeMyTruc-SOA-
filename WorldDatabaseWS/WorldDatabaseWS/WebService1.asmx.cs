using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Services;

namespace WorldDatabaseWS
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1 : WebService
    {
        private readonly string connectionString = "Server=MSI\\SQLEXPRESS01;Database=world;Integrated Security=True;";

        [WebMethod]
        public List<string> GetAllCountries()
        {
            List<string> countries = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Name FROM country", connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            countries.Add(reader["Name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi lấy danh sách quốc gia: " + ex.Message);
            }
            return countries;
        }

        [WebMethod]
        public string GetCountryByCode(string code)
        {
            string countryName = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Name FROM country WHERE Code = @Code", connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                countryName = reader["Name"].ToString();
                            }
                            else
                            {
                                countryName = "Quốc gia không tồn tại!";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi tìm quốc gia: " + ex.Message);
            }
            return countryName;
        }

        [WebMethod]
        public List<string> GetCitiesByCountry(string countryCode)
        {
            List<string> cities = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Name FROM city WHERE CountryCode = @CountryCode", connection))
                    {
                        command.Parameters.AddWithValue("@CountryCode", countryCode);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cities.Add(reader["Name"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi lấy danh sách thành phố: " + ex.Message);
            }
            return cities;
        }

        [WebMethod]
        public string GetCityByName(string cityName)
        {
            string cityInfo = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Name, District, Population FROM city WHERE Name = @Name", connection))
                    {
                        command.Parameters.AddWithValue("@Name", cityName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cityInfo = $"{reader["Name"]}, {reader["District"]}, Dân số: {reader["Population"]}";
                            }
                            else
                            {
                                cityInfo = "Thành phố không tồn tại!";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi tìm thành phố: " + ex.Message);
            }
            return cityInfo;
        }
    }
}