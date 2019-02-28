using System;
using System.Collections.Generic;

namespace ConfigurationOptionsExample.Models
{
    public class MoreSettings
    {
        public string Name {get;set;}
        public bool TrueOrFalse {get;set;}
        public List<Car> Car {get;set;}
    }

    public class Car
    {
        public string Name {get;set;}
        public List<string> models {get;set;}

    }
}