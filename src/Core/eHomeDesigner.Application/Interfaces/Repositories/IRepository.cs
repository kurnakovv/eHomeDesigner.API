using eHomeDesigner.Application.Interfaces.POCOs;

namespace eHomeDesigner.Application.Interfaces.Repositories;

public interface IRepository<TPOCO> where TPOCO : BasePOCO
{
    IReadOnlyCollection<TPOCO> GetAll();
    TPOCO GetById(Guid id);
    void Add(TPOCO poco);
    void Update(Guid id, TPOCO poco);
    void DeleteById(Guid id);

    // TODO: Add UnitOfWork pattern.
    void Commit();
}
