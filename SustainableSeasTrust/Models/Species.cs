using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SustainableSeasTrust.Models
{
    public class Species : Attraction
    {
        public string genus;
        public string species;

        public Species(string name, string description, string Gen, string Spec) : base(name, description)
        {
            genus = Gen;
            species = Spec;
        }

        public void setDetails(string Gen, string Spec)
        {
            genus = Gen;
            species = Spec;
        }
        public override string getDetails()
        {
            return genus+" "+species;
       
        }

    }
}