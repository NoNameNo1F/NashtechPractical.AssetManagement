using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NashtechPractical.AssetManagement.Core.Repositories;
using NashtechPractical.AssetManagement.WebAPI.Common;

namespace NashtechPractical.AssetManagement.WebAPI.Controllers;

[ApiController]
[ApiVersion(ApiVersions.Version1)]
[Route("api/v{version:apiVersion}/account")]
[Produces("application/problem+json")]
public class AccountsController : ControllerBase
{
    // private readonly IAccountRepository _accountRepository;
    // private readonly IMediator _mediator;

    public AccountsController()
    {
        // _accountRepository = accountRepository;
        // _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get(int pageSize = 25, int pageNumber = 1,
        CancellationToken cancellationToken = default)
    {
        return Ok(new ApiResponse
        {
            Result = "Hahahaha"
        });
    }
    
}