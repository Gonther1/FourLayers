using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.Repositories
{
    public class RolRepository : GenericRepository<Rol>, IRolRepository
    {
        private readonly FourLayersContext _context;

        public RolRepository(FourLayersContext context) : base(context)
        {
            _context = context;
        }
    }
}