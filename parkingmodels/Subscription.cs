using System;

namespace parkingmodels
{
    public class Subscription
    {
        public string Duration { get; set; }
        public int Price { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }

        private Cars cars;
        public Subscription()
        {
            Duration = "";
            Price = 0;
            StartDate = null;
            EndDate = null;
            cars = new Cars();

        }
        public Cars GetCars()
        {
            return cars;
        }
        public void SetCars(Cars value)
        {
            cars = value;
        }
      

    }
}