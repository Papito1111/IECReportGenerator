﻿using IECReportGenerator.Infrastructure;
using IECReportGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IECReportGenerator
{
    public class IECReportGenerator1
    {
        WindReader _reader;
        IECWriter _writer;

        public IECReportGenerator1(WindReader reader, IECWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }

        public void GeneratorReport(string inputFile, string outputFile)
        {
            var windModels = _reader.ReadWindModels(inputFile);

            var iecModels = new List<IECModel>();

            foreach (var windModel in windModels)
            {
                var decimalHeight = decimal.Parse(windModel.Height.ToString());

                var iecModel = new IECModel()
                {
                    Class = windModel.WindClass,
                    Height = decimal.Round(decimalHeight, 1),
                    Power = windModel.Power + "MW",
                    RotorDiameter = windModel.BladeLenght * 2
                };

                iecModels.Add(iecModel);
            }
            _writer.SaveIECModels(outputFile, iecModels);
        }
        public IEnumerable<IECModel> GeneratorReport(string inputFile)
        {
            var windModels = _reader.ReadWindModels(inputFile);

            var iecModels = new List<IECModel>();

            foreach (var windModel in windModels)
            {
                var decimalHeight = decimal.Parse(windModel.Height.ToString());

                var iecModel = new IECModel()
                {
                    Class = windModel.WindClass,
                    Height = decimal.Round(decimalHeight, 1),
                    Power = windModel.Power + "MW",
                    RotorDiameter = windModel.BladeLenght * 2
                };

                iecModels.Add(iecModel);
            }
            return iecModels;

        }
    }

}
