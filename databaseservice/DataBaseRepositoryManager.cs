using databaseservice.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseservice
{
   public class DataBaseRepositoryManager
    {
        public static DataBase dataBase => DataBaseSinglton.GetDataBase();
        public DataBaseRepositoryManager()
        {
          
        }
        
        public static CarsBrandRepository GetCarsBrandRepository()
        {
            CarsBrandRepository carsBrandRepository = new CarsBrandRepository(dataBase);
            return carsBrandRepository;
        }

        
        public static CarsModelRepository GetCarsModelRepository()
        {
            CarsModelRepository carsModelRepository = new CarsModelRepository(dataBase);
            return carsModelRepository;

        }
        public static CarsOwnerRepository GetCarsOwnerRepository()
        {
            CarsOwnerRepository carsModelRepository = new CarsOwnerRepository(dataBase);
            return carsModelRepository;
        }
        public static CarsRepository GetCarsRepository()
        {
            CarsRepository carsRepository = new CarsRepository(dataBase);
            return carsRepository;
        
        }
        public static DrivingLicenseRepository GetDrivingLicenseRepository()
        {
            DrivingLicenseRepository DrivingLicenseRepository = new DrivingLicenseRepository(dataBase);
            return DrivingLicenseRepository;
        }

        public static NumberPhoneRepositoty GetNumberPhoneRepository()
        {
            NumberPhoneRepositoty numberPhoneRepository = new NumberPhoneRepositoty(dataBase);
            return numberPhoneRepository;
        }
        public static PaymentRepository GetPaymentRepository()
        {
            PaymentRepository PaymentRepository = new PaymentRepository(dataBase);
            return PaymentRepository;
        }
        public static SubscriptionRepository GetSubscriptiotRepository()
        {
            SubscriptionRepository subscriptionRepository = new SubscriptionRepository(dataBase);
            return subscriptionRepository;
        }
        public static TariffRepository GetTarifRepository()
        {
            TariffRepository tariffRepository = new TariffRepository(dataBase);
            return tariffRepository;
        }

    }
    
}
