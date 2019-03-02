using databaseservice;
using kursach.UserControls;
using parkingmodels;
using System;
using System.Diagnostics;
using System.Windows.Forms;

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

            adminogin = new AdminControlUC();

            userLogin = new UserLoginUC();
            CurrentForm.Bind(userLogin);
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
                CurrentForm.Hide();
            }
            else
            {
                NumberPhone phone = DataBaseRepositoryManager.GetNumberPhoneRepository().GetModel($"SELECT * FROM [Номер телефона] WHERE [Номер_телефона]={userLogin.NumberPhone}");
                CarsOwner carsOwner = DataBaseRepositoryManager.GetCarsOwnerRepository().GetModel($"SELECT * FROM [Владелец авто] where [Номер_телефона]={phone.Id}"); 
                if (carsOwner!=null)
                {
                    userForm = new UserFormController(new Forms.UserForm());
                    userForm.Bind(carsOwner);
                    userForm.CurrentForm.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Данного пользователя не существует");
                }
            }
            

            
        }

        private void OnSelectAdmin(object sender, EventArgs e)
        {
            CurrentForm.Bind(adminogin);
            isAdminSelected = true;

        }

        private void OnSelectUser(object sender, EventArgs e)
        {
            isAdminSelected = false;
            CurrentForm.Bind(userLogin);
            

        }
        
    }

}
