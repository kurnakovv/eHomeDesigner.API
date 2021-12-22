using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;

namespace eHomeDesigner.Application.Interfaces.POCOs.Rooms;

public interface IEditableRoom
{
    void AddFurniture(BaseFurniture furniture);
    void AddDevice(BaseDevice device);
    void DeleteFurniture(Guid id);
    void DeleteDevice(Guid id);

    void Save();
}