using System;

namespace parkingmodels
{
    public class Subscription
    {
        public Cars Cars { get; set; }
        public string Duration { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}