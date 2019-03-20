using System;

namespace parkingmodels
{
    public class CarsOwner
    {
       
        public int Id { get; set; }
        public string Fio { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> DrivingLicense { get; set; }
        public int Balance { get; set; }
        private DrivingLicense drivingLicense;
        public CarsOwner()
        {
            Id = 0;
            Fio = "Hjsdcsdcsd reger";
            Number = 0;
            DrivingLicense = 0;
            drivingLicense = new DrivingLicense();
        }
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