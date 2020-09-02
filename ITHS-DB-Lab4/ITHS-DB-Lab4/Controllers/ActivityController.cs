using ITHS_DB_Lab4.Models;
using ITHS_DB_Lab4.Repository;
using ITHS_DB_Lab4.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ITHS_DB_Lab4.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IApplicationRepository _repository;
        private readonly UserManager<ApplicationUser> _userManager;

        public ActivityController(IApplicationRepository repository, UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        [Authorize]
        public ActionResult Index()
        {
            var activities = _repository.GetAllActivities();
            return View(activities);
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new ActivityFormViewModel
            {
                Categories = _repository.GetAllCategories()
            };

            return View(viewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CreateActivity(ActivityFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _repository.GetAllCategories();
                return View("Create", viewModel);
            }

            var activity = new Activity
            {
                CategoryId = viewModel.CategoryId,
                Name = viewModel.Name,
                User = await _userManager.GetUserAsync(User)
            };

            _repository.AddActivity(activity);
            _repository.SaveAll();
            return RedirectToAction("Index", "Activity");
        }
    }
}