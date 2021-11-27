using eHomeDesigner.Application.Interfaces.POCOs.Rooms;
using eHomeDesigner.Application.Interfaces.Repositories;
using System;

namespace eHomeDesigner.Application.POCOs.Rooms
{
    public class Hall : Room
    {
        public Hall(
                   Guid customerId,
                   int squareMeters,
                   IDeviceRepository deviceRepository
               ) : base(customerId, squareMeters, deviceRepository) { }

        public override string Type => GetType().Name;
    }
}
