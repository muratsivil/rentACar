﻿using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Update;
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id){
        GetByIdBrandResponse response = await Mediator.Send(new GetByIdBrandQuery { Id = id });
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBrandCommand updateBrandCommand){
        UpdatedBrandResponse response = await Mediator.Send(updateBrandCommand);
        return Ok(response);
    }
}
