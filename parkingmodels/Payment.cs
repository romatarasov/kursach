using System;

namespace parkingmodels
{
    public class Payment
    {
        private Tariff tariff;
        private CarsOwner carsOwner;
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public Tariff GetTariff()
        {
            return tariff;
        }
        public void SetTariff(Tariff value)
        {
            tariff = value;
        }

        public CarsOwner GetCarsOwner()
        {
            return carsOwner;
        }
        public void SetCarsOwner(CarsOwner value)
        {
            carsOwner = value;
        }

    }
}