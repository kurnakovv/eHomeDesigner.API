using eHomeDesigner.Application.Interfaces.Converters;
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
    where TPOCO : BasePOCO
{
    private readonly DbContext _context;
    private readonly DbSet<TEntity> _store;
    private readonly IConverter _converter;

    public Repository(
        DbContext context, 
        IConverter converter)
    {
        _context = context;
        _store = _context.Set<TEntity>();
        _converter = converter;
    }

    public IReadOnlyCollection<TPOCO> GetAll()
    {
        IReadOnlyCollection<TPOCO> result = _converter.Convert<IReadOnlyCollection<TPOCO>, List<TEntity>>(_store.ToList());

        return result;
    }

    public TPOCO GetById(Guid id)
    {
        TEntity entity = _store.FirstOrDefault(x => x.Id == id);
        TPOCO result = _converter.Convert<TPOCO, TEntity>(entity);

        return result;
    }

    public void Update(Guid id, TPOCO poco)
    {
        TEntity oldEntity = _store.FirstOrDefault(x => x.Id == id);

        if (oldEntity == null)
            return;

        TEntity newEntity = _converter.Convert<TEntity, TPOCO>(poco);
        newEntity.Id = oldEntity.Id;
        _context.Entry(oldEntity).CurrentValues.SetValues(newEntity);
    }

    public void Add(TPOCO poco)
    {
        TEntity entity = _converter.Convert<TEntity, TPOCO>(poco);
        _store.Add(entity);
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public void DeleteById(Guid id)
    {
        TEntity entity = _store.FirstOrDefault(x => x.Id == id);
        _store.Remove(entity);
    }
}
