using Microsoft.AspNetCore.Mvc;

namespace PTFDCallbackServer.Controllers;

[ApiController]
[Route("/api/v1/callback")]
public class RequestController : ControllerBase
{
   
    private readonly ILogger<RequestController> _logger;

    public RequestController(ILogger<RequestController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Post([FromBody] CallbackRequest request)
    {
        if (request == null)
        {
            return BadRequest("Request cannot be null");
        }

        // Process the request here
        _logger.LogInformation($"Received request with Builderid: {request.Builderid}" );
        _logger.LogInformation($"Document path: {request.Documentpath}" );

        // Return a response
        // Documentpath should contain the path to the new document
        var response = new CallbackResponse
        {
            Status = Status.Unchanged,
            Statusmsg = "Request processed successfully",
            Documentpath = ""
        };

        return Ok(response);
    }
}