using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using System;

namespace eHomeDesigner.Application.POCOs.Rooms
{
    public class Bedroom : Room
    {
        public Bedroom(
                   Guid customerId,
                   int squareMeters
               ) : base(customerId, squareMeters) { }

        public override string Type => GetType().Name;
    }
}
