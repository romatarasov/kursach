using kursach.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.Controllers
{
    public abstract class BaseController<T>
    {
       public T CurrentForm { get; set; }
        protected BaseController(T form)
            {
              this.CurrentForm = form;
            }
        public abstract void InitializeController();
        
        
    }
   public class AdminController : BaseController<AdminControlUC>
    {
        public AdminController(AdminControlUC form) : base(form)
        {
        }

        public override void InitializeController()
        {
            throw new NotImplementedException();
        }
    }

}
