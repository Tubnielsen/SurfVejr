using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Surfvejr.Models;

namespace Surfvejr.Data
{
    public class DbInitializer
    {
        public static void Initialize(SurfsUpContext context)
        {
            context.Database.EnsureCreated();

            //Check if data already has been initialized.
            if (context.SurfSpots.Any())
            {
                return;
            }
            var SpotData = new SpotData[]
            {
                new SpotData { TimeOfData = DateTime.Parse("2020-03-20 12:11:05"), WaveHeight = 1.7, WavePeriod =  TimeSpan.Parse("0:0:3"), WindSpeed = 15.1, SeaTemp = 16.7},
                new SpotData { TimeOfData = DateTime.Parse("2020-03-21 12:47:11"), WaveHeight = 0.3, WavePeriod =  TimeSpan.Parse("0:0:2"), WindSpeed = 11.5, SeaTemp = 16.8},
                new SpotData { TimeOfData = DateTime.Parse("2020-03-21 12:09:33"), WaveHeight = 1.1, WavePeriod =  TimeSpan.Parse("0:0:7"), WindSpeed = 7.9, SeaTemp = 17.2},
                new SpotData { TimeOfData = DateTime.Parse("2020-03-22 13:55:01"), WaveHeight = 2.3, WavePeriod =  TimeSpan.Parse("0:0:4"), WindSpeed = 4.6, SeaTemp = 14.1},
                new SpotData { TimeOfData = DateTime.Parse("2020-03-22 14:21:41"), WaveHeight = 3.1, WavePeriod =  TimeSpan.Parse("0:0:4"), WindSpeed = 18.9, SeaTemp = 11.7},
                new SpotData { TimeOfData = DateTime.Parse("2020-03-23 11:10:16"), WaveHeight = 2.7, WavePeriod =  TimeSpan.Parse("0:0:3"), WindSpeed = 20.3, SeaTemp = 18.9},
                new SpotData { TimeOfData = DateTime.Parse("2020-03-23 08:49:11"), WaveHeight = 0.4, WavePeriod =  TimeSpan.Parse("0:0:3"), WindSpeed = 25.6, SeaTemp = 19.1},
                new SpotData { TimeOfData = DateTime.Parse("2020-03-24 15:01:57"), WaveHeight = 0.1, WavePeriod =  TimeSpan.Parse("0:0:5"), WindSpeed = 11, SeaTemp = 15.8},
            };
            foreach (SpotData e in SpotData)
            {
                context.SpotData.Add(e);
            }
            context.SaveChanges();

            var SurfSpots = new SurfSpot[]
            {
                new SurfSpot { Name = "Solrød Strand", Latitude = 10.36, Longitude = 36.17, SpotData = { SpotData.ElementAt(0), SpotData.ElementAt(1) } },
                new SurfSpot { Name = "Nysted Strand", Latitude = 77.11, Longitude = 64.81, SpotData = { SpotData.ElementAt(2), SpotData.ElementAt(3) } },
                new SurfSpot { Name = "Odense Havn", Latitude = 97.361, Longitude = 79.01, SpotData = { SpotData.ElementAt(4), SpotData.ElementAt(5) } },
                new SurfSpot { Name = "Kerteminde strand", Latitude = 4.83, Longitude = 81.1, SpotData = { SpotData.ElementAt(6), SpotData.ElementAt(7) } }
            };
            foreach (SurfSpot e in SurfSpots)
            {
                context.SurfSpots.Add(e);
            }
            context.SaveChanges();
        }
    }
}
