using System;

namespace parkingmodels
{
    public class Payment
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public Tariff Tariff { get; set; }
        public CarsOwner CarsOwner { get; set; }

    }
}