﻿
using ECommerce.Application.Abstractions.Services;
using ECommerce.Application.Features.Commands.Product.UpdateStockQrCodeToProduct;
using MediatR;

public class UpdateStockQrCodeToProductCommandHandler : IRequestHandler<UpdateStockQrCodeToProductCommandRequest, UpdateStockQrCodeToProductCommandResponse>
{
    readonly IProductService _productService;

    public UpdateStockQrCodeToProductCommandHandler(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<UpdateStockQrCodeToProductCommandResponse> Handle(UpdateStockQrCodeToProductCommandRequest request, CancellationToken cancellationToken)
    {
        await _productService.StockUpdateToProductAsync(request.ProductId, request.Stock);
        return new();
    }
}