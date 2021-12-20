using eHomeDesigner.Application.Interfaces.Converters;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.Interfaces.Repositories;
using eHomeDesigner.Data.Contexts;
using eHomeDesigner.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Repositories;

public class FurnitureRepository : Repository<FurnitureEntity, BaseFurniture>, IFurnitureRepository<BaseFurniture>
{
    public FurnitureRepository(FurnitureDbContext deviceContext, IConverter converter) : base(deviceContext, converter) { }
}
