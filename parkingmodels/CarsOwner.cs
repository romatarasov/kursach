namespace parkingmodels
{
    public class CarsOwner
    {
        private DrivingLicense drivingLicense; 
        public int Id { get; set; }
        public string Fio { get; set; }
        public int Number { get; set; }
        public int Balance { get; set; }
        public  DrivingLicense GetNumberDrivingLicense()
        {
            return drivingLicense;
        }
        public void SetNumberDrivingLicense(DrivingLicense value)
        {
            drivingLicense = value;
        }
    }
}