using databaseservice;
using databaseservice.Repositories;
using kursach.UserControls;
using parkingmodels;
using System;
using System.Data.SqlClient;

namespace kursach.Controllers
{
    public class OnParkingController : BaseController<OnParking>
    {
        private SubscriptionRepository substrictionRepository;
        bool StartParking, StopParking;

        public OnParkingController(OnParking form) : base(form)
        {
            InitializeController();
        }

        public override void InitializeController()
        {
           
        }

        public void OnParking(object sender ,EventArgs e)
        {
            if (StartParking)
            {                 
                //Payment payment=DataBaseRepositoryManager.GetPaymentRepository().Insert($"INSERT INTO [Оплата] ([Дата_заезда]) VALUES (CURRENT_TIMESTAMP)";
            }
            if (StopParking)
            {
                //Payment payment = DataBaseRepositoryManager.GetPaymentRepository().Insert(INSERT INTO[Оплата]([Дата_выезда]) VALUES(CURRENT_TIMESTAMP);
                //select DATEDIFF(MINUTE, [Дата_заезда], [Дата_выезда])
                //    from[Оплата] where id = 1;

            }
               
               
            }
        }
      

    }


