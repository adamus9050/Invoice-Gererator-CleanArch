using Application.Dto;
using Application.Dto.Customer.Command.CustomerCommandAdd;
using Application.Dto.Material.MaterialQuerries.List;
using Application.Dto.Order.Command.Add;
using Application.Dto.Order.Querry;
using Application.Dto.Product.ProductCommand.Add;
using Application.Dto.Product.ProductQuerries.Get;
using Application.Dto.Product.ProductQuerries.List;
using AutoMapper;
using Azure.Core;
using Domain.Entities;
using Invoice_Generator.Extensions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Invoice_Generator.Controllers
{
    public class OrderController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public OrderController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        public IActionResult AddOrder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOrder(AddOrderCommand order)
        {
            var orders = _mediator.Send(order);
            return RedirectToAction("GetOrderList");
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderList()
        {
            var ordersList = await _mediator.Send(new OrderListQuerry());
            return View(ordersList);
        }
    }
    
}
                            