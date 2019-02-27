using databaseservice.Repositories;
using kursach.Forms;

namespace kursach.Controllers
{
    public class UserFormController : BaseController<UserForm>
    {
        private CarsRepository carsRepository;
        private CarsOwnerRepository carsOwnerRepository;
        private SubscriptionRepository subscriptionRepository;

        protected UserFormController(UserForm form) : base(form)
        {
            InitializeController();
        }

        public override void InitializeController()
        {
            
        }
       
        
    }


}
