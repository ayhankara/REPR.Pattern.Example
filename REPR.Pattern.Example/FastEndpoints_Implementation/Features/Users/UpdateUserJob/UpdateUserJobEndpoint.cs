using FastEndpoints;

namespace REPR.Pattern.Example.FastEndpoints_Implementation.Features.Users.UpdateUserJob
{
    public class UpdateUserJobEndpoint : Endpoint<UpdateUserJobRequest, UpdateUserJobResponse>
    {
        public override void Configure()
        {
            Put("/api3/users/update-job");
            AllowAnonymous();
        }

        public override async Task HandleAsync(UpdateUserJobRequest req, CancellationToken ct)
        {
            //Process...

            var response = new UpdateUserJobResponse(req.UserId, "Job information has been successfully updated...");

            await SendAsync(response);
        }
    }
}
