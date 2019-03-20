using databaseservice;
using kursach.UserControls;
using parkingmodels;
using System;
using System.Windows.Forms;

namespace kursach.Controllers
{
    public class MyProfileController : BaseController<MyProfile>
    {

        bool isChangeSelected;
        private MyProfile myProfile;
        private CarsOwner carsOwner;

        public MyProfileController(MyProfile form) : base(form)
        {
            InitializeController();
            myProfile = new MyProfile();
            carsOwner = new CarsOwner();
           
        }

        public override void InitializeController()
        {
            CurrentForm.Change += OnChange;
        }
        private void OnChange(object sender,EventArgs e)
        {
            CurrentForm.bind(carsOwner);
            //CurrentForm.Bind(carsOwner);
            if (isChangeSelected)
            {


                //CarsOwner carsOwner = DataBaseRepositoryManager.GetCarsOwnerRepository().Edit($"UPDATE [Владелец авто] SET [ФИО]={myProfile.FIO} , [Водительское_удостоверение]={myProfile.DrivingLicense}") ;


                MessageBox.Show("Данные изменены");



            }
        }
        
    }


}
