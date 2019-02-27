namespace parkingmodels
{
    public class CarsBrand
    {
        private CarsModel carsModel;
        public int Id { get; set; }
        public CarsModel GetCarsModel ()
        {
            return carsModel;
        }
        public void SetCarsModel(CarsModel value)
        {
            carsModel = value;
        }
        public string Brand { get; set; }

    }
}