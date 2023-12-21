﻿using DesafioCurso.Application.Commands.Request.Person;
using DesafioCurso.Application.Commands.Request.Unit;
using DesafioCurso.Application.Commands.Response.Person;
using DesafioCurso.Application.Commands.Response.Unit;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioCurso.Api.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet("GetAllPerson")]
        public async Task<IEnumerable<GetAllPersonResponse>> GetAllPerson(int value)
        {
            var command = new GetAllPersonRequest();
            command.Quantity = value;

            return await _mediator.Send(command);
        }

        [HttpGet("GetPersonById/{id:Guid}")]
        public async Task<GetPersonByIdResponse> GetPersonByID(Guid id)
        {
            var command = new GetPersonByIdRequest();
            command.Id = id;

            return await _mediator.Send(command);
        }

        [HttpPost("CreatePerson")]
        public async Task<CreatePersonResponse> CreateUnit([FromBody] CreatePersonRequest command)
        {
            return await _mediator.Send(command);

        }

        [HttpPut("UpdatePerson/{id:Guid}")]
        public async Task<UpdatePersonResponse> UpdatePerson([FromBody] UpdatePersonRequest command, Guid id)
        {
            command.Id = id;
            return await _mediator.Send(command);

        }

    }
}
