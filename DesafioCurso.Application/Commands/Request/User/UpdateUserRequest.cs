﻿using DesafioCurso.Application.Commands.Response.User;
using MediatR;
using System.Text.Json.Serialization;

namespace DesafioCurso.Application.Commands.Request.User
{
    public class UpdateUserRequest : IRequest<UpdateUserResponse>
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        // Representa um CPF ou CNPJ.
        public string? Cpf_Cnpj { get; set; }
    }
}

