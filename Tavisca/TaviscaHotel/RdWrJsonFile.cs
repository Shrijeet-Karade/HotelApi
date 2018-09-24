using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TaviscaHotel
{
    public class RdWrJsonFile
    {
        public List<HotelStaticData> GetAllHotels()
        {
            List<HotelStaticData> hotels = new List<HotelStaticData>();
            string filepath = "C:/Users/skarade/source/repos/Tavisca/TaviscaHotel/StaticData.json";  // change file name
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                List<HotelStaticData> items = JsonConvert.DeserializeObject<List<HotelStaticData>>(json);
                for (var index = 0; index < items.Count; index++)
                {
                    HotelStaticData hotel = new HotelStaticData();
                    hotel.HotelId = items[index].HotelId;
                    hotel.HotelName = items[index].HotelName;
                    hotel.HotelAmenities = items[index].HotelAmenities;
                    hotel.Location = items[index].Location;
                    hotel.ImgURL = items[index].ImgURL;
                    hotel.HotelDescription = items[index].HotelDescription;
                    hotel.HotelNo = items[index].HotelNo;
                    hotel.CityName = items[index].CityName;
                    hotels.Add(hotel);
                }

            }
            return hotels;
            
        }
    }
}