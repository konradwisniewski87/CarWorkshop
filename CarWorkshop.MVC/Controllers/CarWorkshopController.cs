using CarWorkshop.Application.CarWorkshop;
using CarWorkshop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers
{
    public class CarWorkshopController : Controller
    {
        private readonly ICarWorkshopService _carWorkshopService;

        public CarWorkshopController(ICarWorkshopService carWorkshopService)
        {
            _carWorkshopService = carWorkshopService;
        }

        public ActionResult Create()
        {
            return View();
        }

        public async Task<ActionResult> Index() //Name index is default name for main pages, we set this page as main
        {
            var carWorkshop = await _carWorkshopService.GetAll();
            return View(carWorkshop);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarWorkshopDTO carWorkshop)
        {
            if(!ModelState.IsValid)
            {
                return View(carWorkshop);
            }
            await _carWorkshopService.Create(carWorkshop);
            return RedirectToAction(nameof(Index));//TODO: refactor

        }
    }
}