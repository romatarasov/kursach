using kursach.Forms;
using System;

namespace kursach.Controllers
{
    public class ChangeCarController : BaseController<ChangeCarForm>
    {
        public ChangeCarController(ChangeCarForm form) : base(form)
        {
        }

        public override void InitializeController()
        {
            throw new NotImplementedException();
        }
    }
}
