using System;

namespace parkingmodels
{
    public class Subscription
    {
        private Cars cars;
        public Cars GetCars()
        {
            return cars;
        }
        public void SetCars(Cars value)
        {
            cars = value;
        }
        public string Duration { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}