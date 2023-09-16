using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Dto.Material.MaterialCommand.Add;
using Application.Dto.Material.MaterialQuerries.List;
using MaterialCommand.Delete;
using MaterialQuerries.Search;
using Application.Dto.Material.MaterialQuerries.Get;
using Application.Dto.Material.MaterialCommand.Edit;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace Invoice_Generator.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public HomeController(IMediator mediator,IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
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
        public IActionResult AddMaterials()
        {
            return View();
        }

        //Add materials to database
        [HttpPost]
        public async Task<IActionResult> AddMaterials(MaterialSaveCommand material)
        {

            if (!ModelState.IsValid)
            {
                return View("AddMaterials");
            }
            try
            {
                await _mediator.Send(material);
                TempData["Materials"] = material.Name;
                return RedirectToAction("AddMaterials");
            }
            catch(Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            try
            {
                var listMaterial = await _mediator.Send(new MaterialListQuerrie());
                return View(listMaterial);
            }
            catch(Exception ex)
            {
                return Problem(ex.Message);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteMaterials(int id)
        {
            try
            {
                var result = await _mediator.Send(new MaterialRemove(id));
                //_dataBaseService.DeleteMaterial(id);
                ViewBag.Message = "Record Delete Succesfully";
                return RedirectToAction("List");
            }
            catch(Exception ex)
            {
                return Problem(ex.Message);
            }
        }
     
        public async Task<IActionResult> Edit(int id)
        {
            var dtoMaterial = await _mediator.Send(new GetMaterialQuerry(id));
            EditMaterialCommand model = _mapper.Map<EditMaterialCommand>(dtoMaterial);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,EditMaterialCommand material)
        {

            //if (!ModelState.IsValid)
            //{
            //    return View("AddMaterials");
            //}

            await _mediator.Send(material);
            TempData["Materials"] = material.Name;
            return RedirectToAction("List");
        }

        public async Task<IActionResult> SearchMaterials(string searchMaterial)
        {
            try 
            {
                var material = await _mediator.Send(new MaterialSearchQuerrie(searchMaterial));
                return View(material); 
            }
            catch(Exception ex)
            {
                return Problem(ex.Message);
            }

        }

    }
}