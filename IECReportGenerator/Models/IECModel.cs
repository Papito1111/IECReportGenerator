using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace IECReportGenerator.Models
{
    public class IECModel
    {
        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("height")]
        public decimal Height { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("rotorDiameter")]
        public int RotorDiameter { get; set; }
    }
}
