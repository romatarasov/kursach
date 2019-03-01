using kursach.UserControls;
using System;

namespace kursach.Controllers
{
    public class MyProfileController : BaseController<MyProfile>
    {
        
        public MyProfileController(MyProfile form) : base(form)
        {

        }

        public override void InitializeController()
        {
            throw new NotImplementedException();
        }
    }


}
