using IECReportGenerator;
using IECReportGenerator.Infrastructure;


var generator = new IECReportGenerator1(new WindReader(),
                                       new IECWriter());
generator.GeneratorReport("data.json", "iec.json");
