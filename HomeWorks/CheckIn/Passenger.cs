using System;
using System.Collections.Generic;
using System.Text;

namespace CheckIn
{
    public class Passenger
    {    
        public string FullName;
            public int PassportNumber;
            public int FlightNumber;
            public Passenger(string Name)
            {
                FullName = Name;           
            }
    }
}
