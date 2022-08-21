using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SustainableSeasTrust.Models
{
    public class Activity : Attraction
    {
        public string website;
        public Activity(string name, string description, string site) : base(name, description)
        {
            website = site;
        }
        public void setDetails(string site)
        {
            website = site;
        }
        public override string getDetails()
        {
            return website;

        }
    }
}