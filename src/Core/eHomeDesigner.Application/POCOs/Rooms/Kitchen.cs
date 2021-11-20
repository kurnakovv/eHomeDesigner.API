using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using System;

namespace eHomeDesigner.Application.POCOs.Rooms
{
    public class Kitchen : Room
    {
        public Kitchen(
                   Guid customerId,
                   int squareMeters
               ) : base(customerId, squareMeters) { }
    }
}
