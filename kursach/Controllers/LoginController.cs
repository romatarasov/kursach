using databaseservice;
using kursach.UserControls;
using parkingmodels;
using System;
using System.Diagnostics;

namespace kursach.Controllers
{
    public class LoginController : BaseController<MainForm>
    {
        bool isAdminSelected;
        private UserFormController userForm;
        private AdminController adminController;
        private AdminControlUC adminogin;
        private UserLoginUC userLogin;



        public LoginController(MainForm form) : base(form)
        {
            InitializeController();

                      
      
        }

        public override void InitializeController( )
        {
            CurrentForm.SelectUser += OnSelectUser;
            CurrentForm.SelectAdmin += OnSelectAdmin;
            CurrentForm.Login += OnLogin;

        }

        private void OnLogin(object sender, EventArgs e)
        {
            if (isAdminSelected)
            {
                adminController = new AdminController(new Forms.AdminForm());
                adminController.CurrentForm.Show();
            }
            else
            {

                CarsOwner carsOwner = DataBaseRepositoryManager.GetCarsOwnerRepository().GetModel($"SELECT * FROM [Владелец авто] where Номер_телефона={userLogin.NumberPhone}");
                if (carsOwner!=null)
                {
                    userForm = new UserFormController(new Forms.UserForm());
                    userForm.CurrentForm.Show();
                }
            }
            

            
        }

        private void OnSelectAdmin(object sender, EventArgs e)
        {
            AdminControlUC adminogin = new AdminControlUC();
            isAdminSelected = true;

        }

        private void OnSelectUser(object sender, EventArgs e)
        {
            UserLoginUC userLogin = new UserLoginUC();
            isAdminSelected = false;
            

        }
        
    }

}
