using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SustainableSeasTrust.Models
{
    public class HopeSpot
    {
        public string name { get; set; }
        public string description { get; set; }
        public string diversity { get; set; }
        public string website { get; set; }
        public string imgurl { get; set; }

        private List<Species> Animals;
        private List<Activity> Activities;
        private List<Beach> Beaches;

        public HopeSpot(string Name, string Descr, string div, string site, string img)
        {
            name = Name;
            description = Descr;
            diversity = div;
            website = site;
            imgurl = img;
            Animals = new List<Species>();
            Activities = new List<Activity>();
            Beaches = new List<Beach>();

        }
        public void addSpecies(string name, string description, string genus, string species)
        {
            Species animal = new Species(name, description, genus, species);
            Animals.Add(animal);
        }

        public void addActivity(string name, string description, string site)
        {
            Activity Place = new Activity(name, description, site);
            Activities.Add(Place);
        }
        public void addBeach(string name, string description, string map)
        {
            Beach Place = new Beach(name, description, map);
            Beaches.Add(Place);
        }


    }
}