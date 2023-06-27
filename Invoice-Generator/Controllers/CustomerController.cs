using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Dto.Customer.CustomerQueries.List;
using Application.Dto.Customer.CustomerQueries.Details;
using Application.Dto.Customer.Command.CustomerCommandAdd;
using CustomerCommandDelete;
using CustomerQueries.Search;
using Application.Dto.Customer.Command.Edit;
using AutoMapper;
using Application.Dto.Customer.CustomerQueries.GetCustomer;
using Microsoft.AspNetCore.Authorization;
using Invoice_Generator.Extensions;

namespace Invoice_Generator.Controllers
{
    public class CustomerController : Controller
    {
        //private readonly IDataCustomerService _customerService;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CustomerController(IMediator mediator, IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Add()
        {
            if (User.Identity == null || !User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Account/Login", new { area = "Identity" });
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CustomerSaveCommand createCustomer)
        {
            if (!ModelState.IsValid)
            {
                return View("Add");
            }
            try
            {
                await _mediator.Send(createCustomer);
                //var notification = new Notification("Success", $"Created Customer: {createCustomer.Name}, {createCustomer.Surname}");
                //TempData["Notification"]=JsonConvert.SerializeObject(notification);
                this.SetNotification("success", $"Created customer: {createCustomer.Name} {createCustomer.Surname}");
                return RedirectToAction("CustomerList");
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DeleteCustomers(int id)
        {
            try
            {
                var result = await _mediator.Send(new CustomerDeleteCommand(id));
                ViewBag.Message = "Record Delete Succesfully";
                return RedirectToAction("CustomerList");
            }
            catch (Exception ex)
            {

                return Problem(ex.Message);
            }

        }

        [HttpGet]
        [Route("CustomerList")]
        public async Task<IActionResult> CustomerList()//CustomerDto customer)
        {
            try
            {
                var lst = await _mediator.Send(new GetAllCustomer());
                return View(lst);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> DetailsCustomer(int id)
        {
            var detail = await _mediator.Send(new DetailssCustomer(id));
            return View(detail);
        }

       
        [Route("Edit")]
        [Authorize]
        public async Task<IActionResult> Edit(int id) 
        {
            var dtoAddress = await _mediator.Send(new GetCustomerQuerrie(id));

            EditCustomerCommand model = _mapper.Map<EditCustomerCommand>(dtoAddress);

            return View(model);
        }

        [HttpPost]
        [Route("Edit")]
        public async Task<IActionResult> Edit(int id,EditCustomerCommand editcustomer)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View("Add");
            //}
            try
            {
                await _mediator.Send(editcustomer);
                TempData["CustomerName"] = editcustomer.Name;
                TempData["CustomerSurname"] = editcustomer.Surname;
                return RedirectToAction("CustomerList");
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }
        public async Task<IActionResult> Search(string searchString)
        {
            //if (searchString == null)
            //{
            //    return View(CustomerList());
            //}
            if (searchString == null)
            {
                var customerList = await _mediator.Send(new GetAllCustomer());

                return View(customerList);
            }
            var customerSearch = await _mediator.Send(new CustomerSearchQuerry(searchString));

            return View(customerSearch);
        }
    }
}

