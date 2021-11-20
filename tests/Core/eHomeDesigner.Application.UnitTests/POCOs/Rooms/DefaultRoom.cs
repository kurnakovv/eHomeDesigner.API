using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using System;

namespace eHomeDesigner.Application.UnitTests.POCOs.Rooms
{
    /// <summary>
    /// Default room for testing abstract Room.
    /// </summary>
    internal class DefaultRoom : Room
    {
        public DefaultRoom(
                   Guid customerId,
                   int squareMeters
               ) : base(customerId, squareMeters) { }
    }
}
