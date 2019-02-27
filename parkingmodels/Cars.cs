namespace parkingmodels
{
    public class Cars
    {
        public int Id { get; set; }
        public CarsModel CarsModel { get; set; }
        public int NumberCar { get; set; }
        public bool OnParking { get; set; }
        public CarsOwner CarsOwner { get; set; }
        public Payment Payment { get; set; }

    }
}