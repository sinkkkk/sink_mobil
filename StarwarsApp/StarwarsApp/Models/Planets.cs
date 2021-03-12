using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarwarsApp.Models
{
    public class PlanetDetails
    {
        public string name { get; set; }
        public string climate { get; set; }
        public string terrain { get; set; }
        public string gravity { get; set; }
        public int population { get; set; }
        public int rotation_period { get; set; }
        public int orbital_period { get; set; }
        public int diameter { get; set; }
        public int surface_water { get; set; }

    }

    public class Planet
    {
        public string name { get; set }
        public int population { get; set; }
        public string terrain { get; set; }
        public List<PlanetDetails> results { get; set; }
    }
}