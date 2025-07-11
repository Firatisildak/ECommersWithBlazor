﻿using ECommerce.Application.Features.Commands.Product.CreateProduct;
using ECommerce.Application.Features.Commands.Product.RemoveProduct;
using ECommerce.Application.Features.Commands.Product.UpdateProduct;
using ECommerce.Application.Features.Commands.ProductImageFile.ChangeShowcaseImage;
using ECommerce.Application.Features.Commands.ProductImageFile.RemoveProductImage;
using ECommerce.Application.Features.Commands.ProductImageFile.UploadProductImage;
using ECommerce.Application.Features.Queries.Product.GetAllProduct;
using ECommerce.Application.Features.Queries.Product.GetByIdProduct;
using ECommerce.Application.Features.Queries.ProductImageFile.GetProductImages;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ECommerce.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{

    readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
    {
        GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
        return Ok(response);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> Get([FromRoute] GetByIdProductQueryRequest getByIdProductQueryRequest)
    {
        GetByIdProductQueryResponse response = await _mediator.Send(getByIdProductQueryRequest);
        return Ok(response);

    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateProductCommandRequest createProductCommandRequest)
    {
        CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
        return StatusCode((int)HttpStatusCode.Created);
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateProductCommandRequest updateProductCommandRequest)
    {
        UpdateProductCommandResponse response = await _mediator.Send(updateProductCommandRequest);
        return Ok();
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
    {
        RemoveProductCommandResponse response = await _mediator.Send(removeProductCommandRequest);
        return Ok();
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Upload([FromQuery] UploadProductImageCommandRequest uploadProductImageCommandRequest)
    {
        uploadProductImageCommandRequest.Files = Request.Form.Files;
        UploadProductImageCommandResponse response = await _mediator.Send(uploadProductImageCommandRequest);
        return Ok();
    }

    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> GetProductImages([FromRoute] GetProductImagesQueryRequest getProductImagesQueryRequest)
    {
        List<GetProductImagesQueryResponse> response = await _mediator.Send(getProductImagesQueryRequest);
        return Ok(response);
    }

    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> DeleteProductImage([FromRoute] RemoveProductImageCommandRequest removeProductImageCommandRequest, [FromQuery] string imageId)
    {
        //Ders sonrası not !
        //Burada RemoveProductImageCommandRequest sınıfı içerisindeki ImageId property'sini de 'FromQuery' attribute'u ile işaretleyebilirdik!

        removeProductImageCommandRequest.ImageId = imageId;
        RemoveProductImageCommandResponse response = await _mediator.Send(removeProductImageCommandRequest);
        return Ok();
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> ChangeShowcaseImage([FromQuery] ChangeShowcaseImageCommandRequest changeShowcaseImageCommandRequest)
    {
        ChangeShowcaseImageCommandResponse response = await _mediator.Send(changeShowcaseImageCommandRequest);
        return Ok(response);
    }

}