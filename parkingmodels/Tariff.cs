using System;

namespace parkingmodels
{
    public class Tariff
    {
        public Nullable<bool> Day { get; set; }
        public int Cost { get; set; }
       
        public Tariff()
        {
            Day =null;
            Cost = 0;          
          
        }
     
    }
}