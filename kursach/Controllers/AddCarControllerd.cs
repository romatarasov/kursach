using kursach.Forms;
using System;

namespace kursach.Controllers
{
    public class AddCarController : BaseController<AddCarForm>
    {
        public AddCarController(AddCarForm form) : base(form)
        {
        }

        public override void InitializeController()
        {
            throw new NotImplementedException();
        }
    }
}
