using Marketplace.Communication.Request;
using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Api.Controllers;

public class UsuarioController : MarketplaceController
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Login([FromBody] RequestSignupUserJson request)
    {
        return Ok(request);
        throw new Exception("Not implemented");
    }

}
