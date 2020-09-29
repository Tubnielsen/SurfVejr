using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Surfvejr.Models
{
    public class SpotData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int id;
        public DateTime TimeOfData { 
            get { return timeOfData; }
            set { timeOfData = value; } 
        }
        private DateTime timeOfData;

        public double WaveHeight {
            get { return waveHeight; }
            set { waveHeight = value; }
        }
        private double waveHeight;

        public TimeSpan WavePeriod {
            get { return wavePeriod; }
            set { wavePeriod = value; }
        }
        private TimeSpan wavePeriod;

        public double WindSpeed {
            get { return windSpeed; }
            set { windSpeed = value; }
        }
        private double windSpeed;

        public double SeaTemp {
            get { return seaTemp; }
            set { seaTemp = value; }
        }
        private double seaTemp;
        /*enum SurfCondition
        {
            Bad,
            Normal,
            Good,
            Perfect
        }*/
    }
}
