using SistemaVentaBLL.Interfaces;
using SistemaVentaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVentaBLL.Interfaces;
using SistemaVentaDAL.Interfaces;
using SistemaVentaEntity;

namespace SistemaVentaBLL.Implementacion
{
    public class RolService : IRolService
    {
        private readonly IGenericRepository<Rol> _repository;

        public RolService(IGenericRepository<Rol> repository)
        {
            _repository = repository;
        }

        public async Task<List<Rol>> Lista()
        {

            IQueryable<Rol> query = await _repository.Consultar();

            return query.ToList();
            
        }
    }
}
