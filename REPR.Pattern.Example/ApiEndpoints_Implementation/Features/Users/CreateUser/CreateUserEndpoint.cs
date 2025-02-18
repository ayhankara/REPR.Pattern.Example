using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace REPR.Pattern.Example.ApiEndpoints_Implementation.Features.Users.CreateUser
{
    public class CreateUserEndpoint : EndpointBaseAsync.WithRequest<CreateUserRequest>.WithActionResult<CreateUserResponse>
    {
        [HttpPost("api4/users/create")]
        public override async Task<ActionResult<CreateUserResponse>> HandleAsync(CreateUserRequest request, CancellationToken cancellationToken = default)
        {
            //Process...

            var response = new CreateUserResponse(0, $"The user has been successfully created... | {request.Name}, {request.Surname}, {request.Age}");

            return response;
        }
    }
}
