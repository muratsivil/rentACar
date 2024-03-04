using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers;

namespace WebAPI;
[Route("api/[controller]")]
[ApiController]
public class BrandsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand){
        CreatedBrandResponse response = await Mediator.Send(createBrandCommand);
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest){
        GetListResponse<GetListBrandListItemDto> response = await Mediator.Send(new GetListBrandQuery { PageRequest = pageRequest });
        return Ok(response);
    }
}
