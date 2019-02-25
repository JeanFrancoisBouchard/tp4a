using System.Collections.Generic;
using api_b.Models;
using api_b.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_b.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return _userService.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(string id)
        {
            var user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpPost("{nom}/{isbnLivrePrefere}/{nomEmissionPreferee}")]
        public ActionResult<User> Create(string nom, string isbnLivrePrefere, string nomEmissionPreferee)
        {
            User user = new User { username = nom, isbn = isbnLivrePrefere, show = nomEmissionPreferee };
            _userService.Create(user);

            return CreatedAtRoute("GetUser", new { id = user.Id.ToString() }, user);
        }

        [HttpPost]
        public ActionResult<User> CreateObject(User user)
        {
            _userService.Create(user);
            return CreatedAtRoute("Getuser", new { id = user.Id.ToString() }, user);
        }
    }
}