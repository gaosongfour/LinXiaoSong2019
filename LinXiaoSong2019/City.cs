using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinXiaoSong2019
{
    public class City
    {
        public Guid CityId { get; set; }
        public string CityName { get; set; }
        public string ChinestCityName { get; set; }
        public int Population { get; set; }
        public int Surface { get; set; }

        public int PublicTransportIndex { get; set; }
        public int AirQualityIndex { get; set; }
        public int SalaryIndex { get; set; }

    }
}
