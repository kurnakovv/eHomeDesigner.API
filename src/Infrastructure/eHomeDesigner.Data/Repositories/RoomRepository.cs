using eHomeDesigner.Application.Interfaces.Converters;
using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using eHomeDesigner.Application.Interfaces.Repositories;
using eHomeDesigner.Data.Contexts;
using eHomeDesigner.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.Data.Repositories;

public class RoomRepository : Repository<RoomEntity, BaseRoom>, IRoomRepository<BaseRoom>
{
    public RoomRepository(RoomDbContext context, IConverter converter) : base(context, converter) { }
}
