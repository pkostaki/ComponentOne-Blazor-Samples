﻿using System.Drawing;
using System.Globalization;

namespace BlazorExplorer
{
    public class Store
    {
        public int ID { get; set; }
        public string City { get; set; }        
        public Point Location { get; set; }
        public string Country { get; set; }

        public static Store FromString(string s)
        {
            Store shop = null;
            if (!string.IsNullOrEmpty(s))
            {
                var record = s.Split('\t');
                if (record.Length == 4)
                {
                    shop = new Store
                    {
                        ID = int.Parse(record[0]),
                        City = record[1],
                        Location = PointFromString(record[2]),
                        Country = record[3]
                    };
                }
            }

            return shop;
        }

        private static Point PointFromString(string s)
        {
            var record = s.Split(',');
            return new Point((int)double.Parse(record[1], CultureInfo.InvariantCulture),
              (int)double.Parse(record[0], CultureInfo.InvariantCulture));
        }
    }
}
