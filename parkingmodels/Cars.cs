namespace parkingmodels
{
    public class Cars
    {
        private CarsModel carsModel;
        private CarsOwner carsOwner;
        private Payment payment;
        public int Id { get; set; }
        public CarsModel GetCarsModel()
        {
            return carsModel;         
        }
        public void  SetCarsModel(CarsModel value)
        {
            carsModel = value;
        }
        public int NumberCar { get; set; }
        public bool OnParking { get; set; }
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