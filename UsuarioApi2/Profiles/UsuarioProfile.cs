﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuarioApi.Data.Dtos;
using UsuarioApi.Models;

namespace UsuarioApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
            CreateMap<Usuario, IdentityUser<int>>();

        }
    }
}
