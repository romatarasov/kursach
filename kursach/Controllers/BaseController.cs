using kursach.UserControls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.Controllers
{
    /// <summary>
    /// Базовый контролер который выполняет обработку событий с формы
    /// 
    /// </summary>
    /// <typeparam name="T">Форма для контроллера</typeparam>
    public abstract class BaseController<T>
    {
        /// <summary>
        /// Форма с которой связан контроллер
        /// </summary>
        public T CurrentForm { get; set; }
        protected BaseController(T form)
            {
              this.CurrentForm = form;
            }
        /// <summary>
        /// Инициализация данных в контроллере и подписка на события
        /// </summary>
        public abstract void InitializeController();
        
        
    }
    
}
