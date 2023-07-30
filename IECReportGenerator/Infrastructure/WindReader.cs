using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IECReportGenerator.Models;
using Newtonsoft.Json;

namespace IECReportGenerator.Infrastructure
{
    internal class WindReader
    {
        public IEnumerable<WindModel> ReadWindModels(string inputFile)
        {
            var jsontext = File.ReadAllText(inputFile);
            var windModels = JsonConvert.DeserializeObject<IEnumerable<WindModel>>(jsontext);
            return windModels;
        }
    }
}
