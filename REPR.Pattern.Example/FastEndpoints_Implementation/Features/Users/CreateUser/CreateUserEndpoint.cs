using FastEndpoints;

namespace REPR.Pattern.Example.FastEndpoints_Implementation.Features.Users.CreateUser
{
    public class CreateUserEndpoint : Endpoint<CreateUserRequest, CreateUserResponse>
    {
        public override void Configure()
        {
            Post("/api3/users/create");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
        {
            //Process...

            var response = new CreateUserResponse(0, $"The user has been successfully created... | {req.Name}, {req.Surname}, {req.Age}");

            await SendAsync(response);
        }
    }
}
