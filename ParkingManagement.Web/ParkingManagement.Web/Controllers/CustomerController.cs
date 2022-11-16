using Microsoft.AspNetCore.Mvc;
using ParkingManagement.Web.DataAccess;
using ParkingManagement.Web.Intrefaces;
using ParkingManagement.Web.Models.ViewModel;

namespace ParkingManagement.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IBaseRepository<Customer> _repo;
        public CustomerController(IBaseRepository<Customer> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new CustomersViewModel();
            model.Customers = await _repo.GetByFilter(1, 100);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new CustomerViewModel();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var currentCustomer = await _repo.GetOne(id);
            var model = new CustomerViewModel()
            {
                inputCustomer = currentCustomer
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Save(CustomerViewModel model)
        {
            var isNew = model.inputCustomer.InternalId == Guid.Empty;
            var viewName = isNew ? "Create" : "Edit";

            if (!ModelState.IsValid)
                return View(viewName, model);

            if(isNew)
            {
                //Create
                model.inputCustomer.InternalId = Guid.NewGuid();
                model.inputCustomer.CustomerId = "CSTMR000000001";
                await _repo.Insert(model.inputCustomer);
            }
            else
            {
                //Update
                await _repo.Update(model.inputCustomer.InternalId, new { 
                                                                        model.inputCustomer.FirstName,
                                                                        model.inputCustomer.MiddleName,
                                                                        model.inputCustomer.LastName,
                                                                        model.inputCustomer.BirthDate,
                                                                        model.inputCustomer.Gender,
                                                                        model.inputCustomer.ContactNo,
                                                                        model.inputCustomer.EmailAddress,
                                                                        model.inputCustomer.Address
                                                                    });
            }
            return RedirectToAction("Index");
        }
    }
}
