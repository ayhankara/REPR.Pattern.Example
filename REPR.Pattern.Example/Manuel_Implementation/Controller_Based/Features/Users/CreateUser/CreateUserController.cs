using Microsoft.AspNetCore.Mvc;

namespace REPR.Pattern.Example.Manuel_Implementation.Controller_Based.Features.Users.CreateUser
{
    [Route("api/users/create")]
    [ApiController]
    public class CreateUserController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUserAsync([FromBody] CreateUserRequest createUserRequest)
        {
            //Process...

            var response = new CreateUserResponse()
            {
                UserId = 0,
                Message = $"The user has been successfully created... | {createUserRequest.Name}, {createUserRequest.Surname}, {createUserRequest.Age}"
            };
            return Ok(response);
        }
    }
}
