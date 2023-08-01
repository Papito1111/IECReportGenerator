using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IECReportGenerator.Models;
using IECReportGenerator.Infrastructure;

namespace IECReportGenerator.Models
{
    public class WindModel
    {
        public string WindClass { get; set; }
        public int Height { get; set; }
        public int Power { get; set; }
        public int BladeLenght { get; set; }
    }
}
