using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplicacion.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly FourLayersContext _context;

    public UserRepository(FourLayersContext context) : base(context)
    {
        _context = context;
    }

    public Task<User> GetByRefreshTokenAsync(string refreshToken)
    {
        throw new NotImplementedException();
    }

    /*     public async Task<User> GetByRefreshTokenAsync(string refreshToken)
        {
            return await _context.Users
                        .Include(u => u.Rols)
                        .Include(u => RefreshToken)
                        .FirstOrDefault(u => u.RefreshToken)
        } */

    public Task<User> GetByUsernameAsync(string username)
    {
        throw new NotImplementedException();
    }
}
