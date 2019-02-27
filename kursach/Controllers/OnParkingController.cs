using databaseservice.Repositories;
using kursach.UserControls;
using System;

namespace kursach.Controllers
{
    public class OnParkingController : BaseController<OnParking>
    {
        private SubscriptionRepository substrictionRepository;

        protected OnParkingController(OnParking form) : base(form)
        {
        }

        public override void InitializeController()
        {
            throw new NotImplementedException();
        }
    }


}
