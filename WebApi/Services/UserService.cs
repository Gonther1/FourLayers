using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using WebApi.Dtos;
using WebApi.Helpers;

namespace WebApi.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IOptions<JWT> _jwt;
    private readonly IPasswordHasher<User> _passwordHasher;

    public UserService(IUnitOfWork unitOfWork, IOptions<JWT> jwt, IPasswordHasher<User> passwordHasher)
    {
        _unitOfWork = unitOfWork;
        _jwt = jwt;
        _passwordHasher = passwordHasher;
    }

    public Task<string> AddRolAsync(AddRoleDto model)
    {
        throw new NotImplementedException();
    }

    public Task<DataUserDto> GetTokenAsync(LoginDto model)
    {
        throw new NotImplementedException();
    }

    public Task<DataUserDto> RefreshTokenAsync(string refreshToken)
    {
        throw new NotImplementedException();
    }

    public Task<string> RegisterAsync(RegisterDto model)
    {
        throw new NotImplementedException();
    }
}
