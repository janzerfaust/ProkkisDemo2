using Microsoft.AspNetCore.Mvc;
using ProkkisDemo2.Core;
using ProkkisDemo2.Core.Models;
using System.Threading.Tasks;

namespace ProkkisDemo2.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserController(IUserRepository userRepository,
            IUnitOfWork unitOfWork)
        {
            this.userRepository = userRepository;
            this.unitOfWork = unitOfWork;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var activeUser = await userRepository.GetUserAsync(id);
            if(activeUser == null)
            {
                return NotFound();
            }
            return View(activeUser);
        }

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if(!ModelState.IsValid)
            {
                return View(ModelState);
            }
            await userRepository.CreateUser(user);
            await unitOfWork.SaveAsync();
            return RedirectToAction("Create");
        }
    }
}
