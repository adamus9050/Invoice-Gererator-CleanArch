using Application.Dto;
using Application.Dto.Product.ProductCommand.Add;
using Application.Dto.Product.ProductQuerries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Application.Dto.Material.MaterialCommand.Edit;
using Application.Dto.Material.MaterialQuerries.Get;
using Application.Dto.Product.ProductCommand.Edit;
using Application.Dto.Product.ProductQuerries.Get;
using Application.Dto.Product.ProductQuerries.List;

namespace Invoice_Generator.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ProductController(IMapper mapper, IMediator mediator)
        {
            _mapper= mapper;
            _mediator= mediator;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("PolitykaPrywatnosci")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public  IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductCommand products)
        {
            if (!ModelState.IsValid)
            {
                return View("AddProduct");
            }
            await _mediator.Send(products);
            TempData["Product1"] = products.ProductName;
            TempData["Product2"] = products.ProductPrice;
            return RedirectToAction("AddProduct");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts() 
        {
            try
            {
                var ProductList= await _mediator.Send(new ListProduct());
                return View(ProductList);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }

        public async Task<IActionResult> Edit(int id)
        {
            var dtoProduct = await _mediator.Send(new GetProductQuerry(id));
            EditProductCommand model = _mapper.Map<EditProductCommand>(dtoProduct);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditProductCommand product)
        {

            //if (!ModelState.IsValid)
            //{
            //    return View("AddMaterials");
            //}

            await _mediator.Send(product);
            TempData["Product"] = product.ProductName;
            return RedirectToAction("List");
        }
    }
}
