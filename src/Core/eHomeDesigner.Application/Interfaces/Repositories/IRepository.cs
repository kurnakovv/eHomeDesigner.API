using eHomeDesigner.Application.Interfaces.POCOs;
using System;
using System.Collections.Generic;

namespace eHomeDesigner.Application.Interfaces.Repositories
{
    public interface IRepository
    {
        IReadOnlyCollection<IPOCO> GetAll();
        IPOCO GetById(Guid id);
        void Add(IPOCO poco);
        void Update(Guid id, IPOCO poco);
        void DeleteById(Guid id);
    }
}
