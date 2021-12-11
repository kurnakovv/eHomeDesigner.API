using eHomeDesigner.Application.Interfaces.POCOs;
using eHomeDesigner.Application.Interfaces.Repositories;
using eHomeDesigner.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Repositories;

public class Repository<TEntity, TPOCO> : IRepository<TPOCO>
    where TEntity : BaseEntity
    where TPOCO : IPOCO
{
    private readonly DbContext _context;
    private readonly DbSet<TEntity> _store;

    public Repository(DbContext context)
    {
        _context = context;
        _store = _context.Set<TEntity>();
    }

    public IReadOnlyCollection<TPOCO> GetAll()
    {
        throw new NotImplementedException();
    }

    public TPOCO GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public void Update(Guid id, TPOCO poco)
    {
        throw new NotImplementedException();
    }

    public void Add(TPOCO poco)
    {
        throw new NotImplementedException();
    }

    public void Commit()
    {
        throw new NotImplementedException();
    }

    public void DeleteById(Guid id)
    {
        throw new NotImplementedException();
    }
}
