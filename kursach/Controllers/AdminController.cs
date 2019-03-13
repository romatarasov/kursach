using kursach.Forms;
using System;

namespace kursach.Controllers
{
    public class AdminController : BaseController<AdminForm>
    {
        public AdminController(AdminForm form) : base(form)
        {
        }

        public override void InitializeController()
        {
            throw new NotImplementedException();
        }
    }

}
