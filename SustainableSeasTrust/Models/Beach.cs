using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SustainableSeasTrust.Models
{
    public class Beach : Attraction
    {
        public string location;
        public Beach(string name, string description, string map) : base(name, description)
        {
            location = map;
        }
        public void setDetails(string map)
        {
            location = map;
        }
        public override string getDetails()
        {
            return location;

        }

    }
}