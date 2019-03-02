using System;

namespace parkingmodels
{
    public class Cars
    {
        private CarsModel carsModel;
        private CarsOwner carsOwner;
        private Payment payment;
   
        public int Id { get; set; }
        public string CarModel { get; set; }
        public int CarBrand { get; set; }
        public string NumberCar { get; set; }
        public Nullable<bool> OnParking { get; set; }
        public int CarOwner { get; set; }
        public int Payment { get; set; }
        public Cars()
        {
            Id = 0;
            CarModel = "";
            CarBrand = 0;
            NumberCar = "";
            OnParking = null;
            CarOwner = 0;
            Payment = 0;
            carsOwner = new CarsOwner();
            payment = new Payment();
            carsModel = new CarsModel();

        }
            


        public CarsModel GetCarsModel()
        {
            return carsModel;         
        }
        public void  SetCarsModel(CarsModel value)
        {
            carsModel = value;
        }
      
        public CarsOwner GetCarsOwner()
        {
            return carsOwner;
        }
        public void SetCarsOwner(CarsOwner value)
        {
            carsOwner = value;
        }

        public Payment GetPayment()
        {
            return payment;
        }
        public void SetPayment(Payment value)
        {
            payment = value;
        }

    }
}