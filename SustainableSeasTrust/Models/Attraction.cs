using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SustainableSeasTrust.Models
{
    public abstract class Attraction
    {
        private string name;
        private string description;
  

        public Attraction()
        {

        }

        public Attraction(string Name, string Descr)
        {
            name = Name;
            description = Descr;

        }
        public virtual string getName()
        {
            return name;
        }
        public virtual string getDescr()
        {
            return description;
        }
    
        public virtual void setName(string Name)
        {
            name=Name;
        }
        public virtual void setDescr(string descr)
        {
            description=descr;
        }
        
        public abstract string getDetails();


    }
}