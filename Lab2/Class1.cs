using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PostalAddress
    {
        public static List<string> Countries { get; set; }
        public static List<string> Cities { get; set; }
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        private string savedIndex;
        private string savedCountry;
        private string savedCity;
        private string savedStreet;
        private string savedHouse;
        private string savedApartment;

        public PostalAddress()
        {
            savedIndex = "";
            savedCountry = "";
            savedCity = "";
            savedStreet = "";
            savedHouse = "";
            savedApartment = "";
        }

        public PostalAddress(string index, string country, string city, string street, string house, string apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        public PostalAddress(PostalAddress otherAddress)
        {
            savedIndex = otherAddress.index;
            savedCountry = otherAddress.country;
            savedCity = otherAddress.city;
            savedStreet = otherAddress.street;
            savedHouse = otherAddress.house;
            savedApartment = otherAddress.apartment;
        }

        public string Index
        {
            get { return index; }
            set { index = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Поштовий індекс: {index}");
            sb.AppendLine($"Країна: {country}");
            sb.AppendLine($"Місто: {city}");
            sb.AppendLine($"Вулиця: {street}");
            sb.AppendLine($"Будинок: {house}");
            sb.AppendLine($"Квартира: {apartment}");
            return sb.ToString();
        }
    }
}

