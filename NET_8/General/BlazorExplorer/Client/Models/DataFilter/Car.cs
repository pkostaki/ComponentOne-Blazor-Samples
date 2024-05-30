﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorExplorer
{
    public class Car
    {
        public Car()
        {
            Random gen = new Random();
            int range = 25 * 365;
            DateProductionLine = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, gen.Next(24), gen.Next(60), 0, gen.NextDouble() > .5 ? DateTimeKind.Utc : DateTimeKind.Local).AddDays(-gen.Next(range));
            ManufactureDate = DateOnly.FromDateTime(DateProductionLine.AddDays(-gen.Next(10)));
            PresentationDate = new DateTimeOffset(DateProductionLine.AddDays(gen.Next(10)));
            FuelConsumption = TimeOnly.FromTimeSpan(TimeSpan.FromMinutes(240 + gen.Next(200)));
            Acceleration = TimeSpan.FromSeconds(5 + gen.Next(12));

            IsSportVersion = gen.NextDouble() > 0.5;
            IsLimitedSeries = gen.NextDouble() > 0.5 ? true : gen.NextDouble() > 0.5 ? false : null;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string TransmissSpeedCount { get; set; }
        public string TransmissAutomatic { get; set; }
        public DateTime DateProductionLine { get; set; }
        public DateOnly ManufactureDate { get; set; }
        public TimeOnly FuelConsumption { get; set; }
        public TimeSpan Acceleration { get; set; }
        public DateTimeOffset PresentationDate { get; set; }
        public bool IsSportVersion { get; set; }
        public bool? IsLimitedSeries { get; set; }

        [Browsable(false)]
        public int ID { get; set; }
        [Browsable(false)]
        public Int16 HP { get; set; }
        [Browsable(false)]
        public double Liter { get; set; }
        [Browsable(false)]
        public Int16 Cyl { get; set; }
        [Browsable(false)]
        public Int16 MPG_City { get; set; }
        [Browsable(false)]
        public Int16 MPG_Highway { get; set; }
        [Browsable(false)]
        public string Description { get; set; }
        [Browsable(false)]
        public string Hyperlink { get; set; }
        [Browsable(false)]
#if BLAZOR
        public Lazy<string> Picture { get; set; }
#else
        public byte[] Picture { get; set; }
#endif
    }
}