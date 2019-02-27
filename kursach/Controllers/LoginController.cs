using kursach.UserControls;
using System;

namespace kursach.Controllers
{
    public class LoginController : BaseController<MainForm>
    {
        private string NumberPhone;
        private string Password;      
        public LoginController(MainForm form) : base(form)
        {
            InitializeController();
        }

        public override void InitializeController()
        {
            CurrentForm.SelectUser += OnSelectUser;

        }

        private void OnSelectUser(object sender, EventArgs e)
        {
            UserLoginUC userLogin = new UserLoginUC();

        }
        
    }

}
