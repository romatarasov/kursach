using System;

namespace parkingmodels
{
    public class Payment
    {
        private Tariff tariff;
        private CarsOwner carsOwner;
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public  Nullable<DateTime> ArrivalDate { get; set; }
        public Nullable<DateTime> DepartureDate { get; set; }
        public Payment()
        {
            Id = 0;
            PaymentMethod = "";
            ArrivalDate = null;
            DepartureDate = null;
            tariff = new Tariff();
            carsOwner = new CarsOwner();

        }
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