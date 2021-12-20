using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Application.Interfaces.Repositories;

public interface IShelvingStorageRepository<TShelvingStorage> : IRepository<TShelvingStorage> where TShelvingStorage : BaseShelvingStorage
{
}
