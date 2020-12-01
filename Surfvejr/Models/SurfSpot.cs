using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Surfvejr.Models
{
    public class SurfSpot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {
            get { return id; }
            set { id = value; }
        }
        private int id;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        private string name;

        public double Latitude {
            get { return latitude; }
            set { latitude = value; }
        }
        private double latitude;

        public double Longitude {
            get { return longitude; }
            set { longitude = value; }
        }
        private double longitude;

        public ICollection<SpotData> SpotData { get; set; }
    }
}
