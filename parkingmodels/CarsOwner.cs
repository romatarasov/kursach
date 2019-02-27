namespace parkingmodels
{
    public class CarsOwner
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public int Number { get; set; }
        public  DrivingLicense NumberDrivingLicense { get; set; }
    }
}