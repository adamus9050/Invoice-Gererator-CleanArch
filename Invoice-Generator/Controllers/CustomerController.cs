using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Invoice_Generator.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IDataCustomerService _customerService;
        public CustomerController(IDataCustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            await _customerService.Save(customer);
            TempData["CustomerName"] = customer.Name; // tu zapis. Wywołanie w widoku
            TempData["CustomerSurname"] = customer.Surname;
            return RedirectToAction("Add");
        }
        [HttpPost]
        public IActionResult DeleteCustomers(int id)
        {
            _customerService.DeleteCustomers(id);
            return RedirectToAction("CustomerList");
        }

        [Route("CustomerList")]
        public IActionResult CustomerList(Customer customer)
        {
            var lst = _customerService.GetAll();
            return View(lst);
        }

        [HttpGet]
        public IActionResult DetailsCustomer(int id)
        {
            var detail = _customerService.GetAddress(id);
            return View(detail);
        }


        //public async Task<IActionResult> Search(string searchString)
        //{
        //    if (_customerService.Search == null)
        //    {
        //        return Problem("Customer isn't at the database");
        //    }
        //    var customer = await _customerService.Search(searchString);

        //    return View(customer);
        //}
    }
}

