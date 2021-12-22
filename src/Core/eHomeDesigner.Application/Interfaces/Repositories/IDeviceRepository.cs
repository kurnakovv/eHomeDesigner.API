using eHomeDesigner.Application.Interfaces.POCOs;
using eHomeDesigner.Application.Interfaces.POCOs.Devices;

namespace eHomeDesigner.Application.Interfaces.Repositories;

public interface IDeviceRepository<TDevice> : IRepository<TDevice> where TDevice : BaseDevice
{
}
