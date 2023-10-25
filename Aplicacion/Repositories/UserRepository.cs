using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly FourLayersContext _context;

    public UserRepository(FourLayersContext context) : base(context)
    {
        _context = context;
    }
}
