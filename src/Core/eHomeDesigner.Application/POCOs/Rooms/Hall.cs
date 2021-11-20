using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using System;

namespace eHomeDesigner.Application.POCOs.Rooms
{
    public class Hall : Room
    {
        public Hall(
                   Guid customerId,
                   int squareMeters
               ) : base(customerId, squareMeters) { }
    }
}
