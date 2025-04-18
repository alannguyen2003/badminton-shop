using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BadmintonShopAPI.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class ApplicationController: ControllerBase
{
    public ApplicationController()
    {
    }

    [HttpGet("get-version")]
    public async Task<IActionResult> GetVersion()
    {
        return Ok(1);
    }
}