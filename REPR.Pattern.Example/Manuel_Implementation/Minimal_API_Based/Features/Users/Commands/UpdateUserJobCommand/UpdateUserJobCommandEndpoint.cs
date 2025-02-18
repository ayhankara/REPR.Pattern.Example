using Mediator;
using Microsoft.AspNetCore.Mvc;
using REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.UpdateUserJob;
using System.Net;

namespace REPR.Pattern.Example.Manuel_Implementation.Minimal_API_Based.Features.Users.Commands.UpdateUserJobCommand
{
    public static class UpdateUserJobCommandEndpoint
    {
        public static RouteGroupBuilder UpdateUserJobEndpoint(this RouteGroupBuilder routeGroupBuilder)
        {
            routeGroupBuilder.MapPut(pattern: "/update-job", async (UpdateUserJobCommandRequest updateUserJobCommandRequest, IMediator mediator) =>
            {
                var result = await mediator.Send(updateUserJobCommandRequest);

                return new ObjectResult(result)
                {
                    StatusCode = (int)HttpStatusCode.Created
                };
            });

            return routeGroupBuilder;
        }
    }
}
