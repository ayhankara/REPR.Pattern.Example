using Mediator;
using REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.CreateUserCommand;
using REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.UpdateUserJobCommand;

namespace REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands
{
    public static class UserEndpoints
    {
        public static void RegisterUsersEndpoints(this WebApplication application)
        {
            application.MapGroup(prefix: "api2/users")
                .UpdateUserJobEndpoint()
                .CreateUserEndpoint();
        }
    }
}