namespace parkingmodels
{
    public class CarsBrand
    {
        
        private CarsModel carsModel;
        private CarsBrand carsBrand;
        public int Id { get; set; }
        public string Brand { get; set; }
        public CarsBrand()
        {
            Id = 0;
            Brand = "";
            carsModel = new CarsModel();

        }
        public CarsModel GetCarsModel ()
        {
            return carsModel;
        }
        public void SetCarsModel(CarsModel value)
        {
            carsModel = value;
        }
       

    }
}