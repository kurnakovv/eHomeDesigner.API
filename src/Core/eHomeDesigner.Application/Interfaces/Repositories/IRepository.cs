using eHomeDesigner.Application.Interfaces.POCOs;
using System;
using System.Collections.Generic;

namespace eHomeDesigner.Application.Interfaces.Repositories
{
    public interface IRepository<TPOCO> where TPOCO : IPOCO
    {
        IReadOnlyCollection<TPOCO> GetAll();
        TPOCO GetById(Guid id);
        void Add(IPOCO poco);
        void Update(Guid id, TPOCO poco);
        void DeleteById(Guid id);
    }
}
