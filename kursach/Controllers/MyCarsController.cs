using databaseservice.Repositories;
using kursach.UserControls;
using parkingmodels;
using System;

namespace kursach.Controllers
{
    public class MyCarsController : BaseController<MyCars>
    {
        private CarsRepository carsRepository;
        
       
        protected MyCarsController(MyCars form) : base(form)
        {
            carsRepository = new CarsRepository();
        }

        public override void InitializeController()
        {
            throw new NotImplementedException();
        }
    }

}
