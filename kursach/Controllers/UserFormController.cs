using System;
using databaseservice.Repositories;
using kursach.Forms;
using kursach.UserControls;
using parkingmodels;

namespace kursach.Controllers
{
    public class UserFormController : BaseController<UserForm>
    {
        private CarsOwner carsOwner;
        private MyCarsController carsController;
        private MyProfileController myProfileController;
        private OnParkingController onParkingController;
        public UserFormController(UserForm form) : base(form)
        {
            InitializeController();
            carsController = new MyCarsController(new MyCars());
            myProfileController = new MyProfileController(new MyProfile());
            onParkingController = new OnParkingController(new OnParking());
            

        }


        public override void InitializeController()
        {
            CurrentForm.Fillbalance += new System.EventHandler(OnFillBalance);
        }

        private void OnFillBalance(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Bind(CarsOwner carsOwner)
        {
            this.carsOwner=carsOwner;
            CurrentForm.bind(carsOwner);
            CurrentForm.bind(carsController.CurrentForm);
            CurrentForm.bind(myProfileController.CurrentForm);
            CurrentForm.bind(onParkingController.CurrentForm);
        }
    }


}
