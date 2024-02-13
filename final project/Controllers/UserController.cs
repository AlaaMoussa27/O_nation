using final_project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registration.Models;
using System;

namespace Registration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        //[HttpPost]
        //[Route("{user}")]

        //public IActionResult addUser(User user)
        //{
        //    O_NATIONContext context = new O_NATIONContext();
        //    context.Users.Add(user);
        //    context.SaveChanges();
        //    return Ok("done");
        //}

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPut]
        [Route("api/profile/edit")]
        public IActionResult EditProfile([FromBody] User updatedProfile)
        {
            var userId = GetUserIdFromToken(); // Implement this method to get the user's ID from the token
            var existingProfile = _userRepository.GetProfileById(userId);

            if (existingProfile == null)
            {
                return NotFound();
            }

            existingProfile.UserName = updatedProfile.UserName;
            existingProfile.UserPassword = updatedProfile.UserPassword;
            existingProfile.UserEmails = updatedProfile.UserEmails;
            // Update other properties as needed

            _userRepository.UpdateProfile(existingProfile);

            return Ok();
        }

        private int GetUserIdFromToken()
        {
            throw new NotImplementedException();
        }

    }
}




