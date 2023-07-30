using IECReportGenerator;
using IECReportGenerator.Infrastructure;
using IECReportGenerator.Models;

var generator = new IECReportGenerator1(new WindReader(),
                                       new IECWriter());
generator.GeneratorReport("data.json", "iec.jsno");
