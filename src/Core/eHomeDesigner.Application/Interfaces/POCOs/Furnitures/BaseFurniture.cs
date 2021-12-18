using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Application.Interfaces.POCOs.Furnitures;

public abstract class BaseFurniture : BasePOCO, IFurniture
{
    public abstract Guid Id { get; }

    public abstract string Type { get; }

    public abstract int Price { get; }

    public abstract int SquareMeters { get; }
}
