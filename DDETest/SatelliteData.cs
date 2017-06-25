using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDETest
{
    class SatelliteData
    {
        public string name { get; set; }
        public double azimuth { get; set; }
        public double elevation { get; set; }
        public int uplinkFreq { get; set; }
        public int downlinkFreq { get; set; }
        public int baseFreq { get; set; }
        public int doppShift { get; set; }
        public double altitude { get; set; }

        public SatelliteData()
        {
        }

        public SatelliteData(string n)
        {
            name = n;
        }

        public SatelliteData(string n, double a, double e)
        {
            name = n;
            azimuth = a;
            elevation = e;
        }

        public SatelliteData(string n, double a, double e, int u, int d, int alt)
        {
            name = n;
            azimuth = a;
            elevation = e;
            uplinkFreq = u;
            downlinkFreq = d;
            altitude = alt;
        }
    }
}
