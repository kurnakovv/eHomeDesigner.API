using eHomeDesigner.Application.Interfaces.Converters;
using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.Interfaces.Repositories;
using eHomeDesigner.Data.Contexts;
using eHomeDesigner.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Repositories;

public class DeviceRepository : Repository<DeviceEntity, BaseDevice>, IDeviceRepository<BaseDevice>
{
    public DeviceRepository(DeviceDbContext deviceContext, IConverter converter) : base(deviceContext, converter) { }
}
