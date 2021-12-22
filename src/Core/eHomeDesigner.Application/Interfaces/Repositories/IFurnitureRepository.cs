using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;

namespace eHomeDesigner.Application.Interfaces.Repositories;

public interface IFurnitureRepository<TFurniture> : IRepository<TFurniture> where TFurniture : BaseFurniture
{
}
