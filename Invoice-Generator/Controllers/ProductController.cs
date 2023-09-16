using Application.Dto.Product.ProductCommand.Add;
using Application.Dto.Product.ProductCommand.Edit;
using Application.Dto.Product.ProductQuerries.Get;
using Application.Dto.Product.ProductQuerries.List;
using Microsoft.AspNetCore.Authorization;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MaterialCommand.Delete;
using ProductCommand.Delete;
using MaterialQuerries.Search;
using Application.Dto.Product.ProductQuerries.Search;

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
        [Authorize]
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> RemoveProduct(int id)
        {
            try
            {
                var result = await _mediator.Send(new DeleteProductCommand(id));
                //_dataBaseService.DeleteMaterial(id);
                ViewBag.Message = "Record Delete Succesfully";
                return RedirectToAction("GetAllProducts");
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ProductList() 
        {
            try
            {
                var ProductList= await _mediator.Send(new ListProductQuerrie());
                return View(ProductList);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }

        [Authorize]
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

        public async Task<IActionResult> SearchProducts(string searchProduct)
        {
            try
            {
                var product = await _mediator.Send(new ProductSearchQuerry(searchProduct));
                return View(product);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }

        }
    }
}
