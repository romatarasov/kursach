using databaseservice;
using databaseservice.Repositories;
using kursach.Forms;
using kursach.UserControls;
using parkingmodels;
using System;
using System.Windows.Forms;

namespace kursach.Controllers
{
    public class MyCarsController : BaseController<MyCars>
    {
        private CarsRepository carsRepository;
        private AddCarForm addCarForm;
        private ChangeCarController changeCarController;
        private AddCarController addCarController;
        private ChangeCarForm changeCar;
        private MyCars myCars;
        bool isSelectedChange,isSelectedAdd;
       
        public MyCarsController(MyCars form) : base(form)
        {
            InitializeController();
            carsRepository = new CarsRepository();
            addCarForm = new AddCarForm();
            changeCar = new ChangeCarForm();
        }

        public override void InitializeController()
        {
            CurrentForm.SelectChangeCar += OnSelectChangeCar;
            CurrentForm.SelectAddCar += OnSelectAddCar;
        }
        public void MyCars(object sender,EventArgs e)
        {
            if (isSelectedChange)
            {
                changeCarController = new ChangeCarController(new Forms.ChangeCarForm());
                changeCarController.CurrentForm.Show();
                CurrentForm.Hide();
                if (isSelectedAdd)
                {
                    addCarController = new AddCarController(new Forms.AddCarForm());
                    addCarController.CurrentForm.Show();
                    CurrentForm.Hide();

                }
            }
            else
            {

                CarsOwner carsowner = DataBaseRepositoryManager.GetCarsOwnerRepository().GetModel($"SELECT * FROM [Владелец авто] WHERE []={}");
                Cars cars = DataBaseRepositoryManager.GetCarsRepository().GetList($"SELECT * FROM [Автомобили] where [Владелец_авто]={.Id}");

                if (cars != null)
                {
                    myCars = new MyCars();
                    


                }
                else
                {
                    MessageBox.Show("У вас нет авто");
                }
            }
        
           
        }
        private void OnSelectChangeCar(object sender, EventArgs e)
        {
            CurrentForm.Hide();
            isSelectedChange = true;
        }
        private void OnSelectAddCar(object sender, EventArgs e)
        {
            CurrentForm.Hide();
            isSelectedAdd = true;
        }
    }
   
}

