using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
{
    "firstname" : "Roger",
    "lastname" : "Moore",
    "age" : 89,
    "isAlive" : false,
    "address" : 
    {
        "streetAddress" : "Sheissestrasse",
        "city" : "Berlin",
        "postCode" : "N1 3XX"

    }
}
*/

namespace JSON_Deserializer
{
    class jsonPersonComplex
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
        public addr address { get; set; }
        
        public class addr //single nested object
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string postCode { get; set; }
        }
    }
}
