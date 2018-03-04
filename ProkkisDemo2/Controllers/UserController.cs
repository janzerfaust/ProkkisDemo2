using Microsoft.AspNetCore.Mvc;
using ProkkisDemo2.Core;
using System.Threading.Tasks;

namespace ProkkisDemo2.Controllers
{
    public class UserController : Controller
    {
        IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
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
    }
}
