using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Application.Interfaces.POCOs.Furnitures;

public abstract class BaseShelvingStorage : BasePOCO, IShelvingStorage
{
    public abstract int Length { get; }

    public abstract Guid Id { get; }

    public abstract string Type { get; }

    public abstract int Price { get; }

    public abstract int SquareMeters { get; }
}
