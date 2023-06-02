using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Dto.Customer.CustomerQueries.List;
using Application.Dto.Customer.CustomerQueries.Details;
//using Application.Dto.Customer.Command.CustomerCommandDelete;
using Application.Dto.Customer.Command.CustomerCommandAdd;
using CustomerCommandDelete;

namespace Invoice_Generator.Controllers
{
    public class CustomerController : Controller
    {
        //private readonly IDataCustomerService _customerService;
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CustomerSaveCommand createCustomer)//CustomerDto customer)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            await _mediator.Send(createCustomer);
            TempData["CustomerName"] = createCustomer.Name;
            TempData["CustomerSurname"] = createCustomer.Surname;
            return RedirectToAction("Add");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCustomers(int id)
        {
            try
            {
                var result = await _mediator.Send(new CustomerDeleteCommand(id));
                return RedirectToAction("CustomerList");
            }
            catch(Exception ex) 
            {
                return Problem(ex.Message);
            }
            
        }

        [HttpGet]
        [Route("CustomerList")]
        public async Task<IActionResult> CustomerList()//CustomerDto customer)
        {
            var lst = await _mediator.Send(new GetAllCustomer());
            return View(lst);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsCustomer(int id)
        {
            var detail = await _mediator.Send(new DetailssCustomer(id+1));
            return View(detail);
        }


        //public async Task<IActionResult> Search(string searchString)
        //{
        //    if (searchString == null)
        //    {
        //        return Problem("Pole szukaj jest puste");
        //    }
        //    else if (_customerService.Search == null)
        //    {
        //        return Problem("Customer isn't at the database");
        //    }
        //    var customer = await _customerService.Search(searchString);

        //    return View(customer);
        //}
    }
}

