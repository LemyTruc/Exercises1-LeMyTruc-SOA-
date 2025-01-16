using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorldServiceRef; // Đảm bảo namespace đúng

namespace WorldDatabaseClient
{
    public partial class Form1 : Form
    {
        WebService1SoapClient client = new WebService1SoapClient(WebService1SoapClient.EndpointConfiguration.WebService1Soap);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Có thể khởi tạo các thành phần hoặc cài đặt ở đây nếu cần
        }

        private void btnGetAllCountries_Click(object sender, EventArgs e)
        {
            try
            {
                var countries = client.GetAllCountries();
                listBoxCountries.Items.Clear();
                foreach (var country in countries)
                {
                    listBoxCountries.Items.Add(country);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnGetCountrybyCode_Click(object sender, EventArgs e)
        {
            string code = txtCountryCode.Text; // TextBox để nhập mã quốc gia
            try
            {
                string country = client.GetCountryByCode(code);
                MessageBox.Show(country);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnGetCitiesbyCountry_Click(object sender, EventArgs e)
        {
            string countryCode = txtCountryCode.Text; // TextBox để nhập mã quốc gia
            try
            {
                var cities = client.GetCitiesByCountry(countryCode);
                listBoxCities.Items.Clear();
                foreach (var city in cities)
                {
                    listBoxCities.Items.Add(city);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnGetCitybyName_Click(object sender, EventArgs e)
        {
            string cityName = txtCityName.Text; // TextBox để nhập tên thành phố
            try
            {
                string cityInfo = client.GetCityByName(cityName);
                MessageBox.Show(cityInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}