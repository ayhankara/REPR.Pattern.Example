using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using static FastEndpoints.Ep;

namespace REPR.Pattern.Example.ApiEndpoints_Implementation.Features.Users.UpdateUserJob
{
    public class UpdateUserJobEndpoint : EndpointBaseAsync.WithRequest<UpdateUserJobRequest>.WithActionResult<UpdateUserJobResponse>
    {
        [HttpPut("api4/users/update-job")]
        public override async Task<ActionResult<UpdateUserJobResponse>> HandleAsync(UpdateUserJobRequest request, CancellationToken cancellationToken = default)
        {
            //Process...

            var response = new UpdateUserJobResponse(request.UserId, "Job information has been successfully updated...");

            return response;
        }
    }
}
