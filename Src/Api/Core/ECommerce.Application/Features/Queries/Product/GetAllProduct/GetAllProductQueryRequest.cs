﻿using ECommerce.Application.RequestParameters;
using MediatR;

namespace ECommerce.Application.Features.Queries.Product.GetAllProduct;

public class GetAllProductQueryRequest : IRequest<GetAllProductQueryResponse>
{
    public Pagination? Pagination { get; set; }
    public int Page { get; set; } = 0;
    public int PageSize { get; set; } = 10;
}