using IECReportGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace IECReportGenerator.Infrastructure
{
    internal class IECWriter
    {
        public void SaveIECModels(string outputFile, IEnumerable<IECModel> models)
        {
            File.WriteAllText(outputFile, JsonConvert.SerializeObject(models));
        }
    }
}
