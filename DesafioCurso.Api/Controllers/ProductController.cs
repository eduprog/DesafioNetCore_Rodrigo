﻿using DesafioCurso.Application.Commands.Request.Person;
using DesafioCurso.Application.Commands.Request.Product;
using DesafioCurso.Application.Commands.Response.Product;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioCurso.Api.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "administrator, commonUser, manager, seller")]
        [HttpGet("GetAllProduct")]
        public async Task<IEnumerable<GetAllProductResponse>> GetAllPerson(int value)
        {
            var command = new GetAllProductRequest() {Quantity = value };
            return await _mediator.Send(command);
        }

        [Authorize(Roles = "administrator, commonUser, manager, seller")]
        [HttpGet("GetAllProductSeleable")]
        public async Task<IEnumerable<GetAllProductSeleableResponse>> GetAllProductSeleable(int value)
        {
            var command = new GetAllProductSeleableRequest() { Quantity = value };
    
            return await _mediator.Send(command);
        }

        [Authorize(Roles = "administrator, commonUser, manager, seller")]
        [HttpGet("GetProductById/{idOrIdentifier}")]
        public async Task<GetProductByIdResponse> GetProductById(string idOrIdentifier)
        {
            var command = new GetProductByIdRequest() { IdOrIdentifier = idOrIdentifier };
       
            return await _mediator.Send(command);
        }

        [Authorize(Roles = "administrator, manager, seller")]
        [HttpPost("CreateProduct")]
        public async Task<CreateProductResponse> CreateProduct([FromBody] CreateProductRequest command)
        {
            return await _mediator.Send(command);
        }

        [Authorize(Roles = "administrator, manager")]
        [HttpPut("UpdateProduct/{idOrIdentifier}")]
        public async Task<UpdateProductResponse> UpdateProduct([FromBody] UpdateProductRequest command, string idOrIdentifier)
        {
            command.IdOrIdentifier = idOrIdentifier;
            return await _mediator.Send(command);
        }

        [Authorize(Roles = "administrator, manager")]
        [HttpDelete("DeleteProduct/{idOrIdentifier}")]
        public async Task<DeleteProductResponse> DeleteProduct(string idOrIdentifier)
        {
            var command = new DeleteProductRequest() { IdOrIdentifier = idOrIdentifier };

            return await _mediator.Send(command);
        }
    }
}