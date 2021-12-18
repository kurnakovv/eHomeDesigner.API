using eHomeDesigner.Application.Interfaces.POCOs.Rooms;

namespace eHomeDesigner.Application.Interfaces.Repositories;

public interface IRoomRepository<TRoom> : IRepository<TRoom> where TRoom : BaseRoom
{
}
