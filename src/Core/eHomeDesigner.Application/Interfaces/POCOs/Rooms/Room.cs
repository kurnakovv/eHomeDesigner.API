using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eHomeDesigner.Application.Interfaces.POCOs.Rooms
{
    public abstract class Room : IRoom
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid CustomerId { get; }

        public int SquareMeters { get; }

	    public IReadOnlyCollection<IFurniture> Furnitures => _furnitures.ToList();
	    public IReadOnlyCollection<IDevice> Devices => _devices.ToList();

        private IList<IFurniture> _furnitures = new List<IFurniture>();
        private IList<IDevice> _devices = new List<IDevice>();

        private int _energy = 0;
        private int _price = 0;

        public Room(
                   Guid customerId,
                   int squareMeters
               )
        {
            CustomerId = customerId;
            SquareMeters = squareMeters;
        }

        public virtual void AddDevice(IDevice device)
        {
            _devices.Add(device);
        }

        public virtual void AddFurniture(IFurniture furniture)
        {
            _furnitures.Add(furniture);
        }

        public virtual void DeleteDevice(Guid id)
        {
            IDevice device = _devices.FirstOrDefault(d => d.Id == id);
            _devices.Remove(device);
        }

        public virtual void DeleteFurniture(Guid id)
        {
            IFurniture furniture = _furnitures.FirstOrDefault(f => f.Id == id);
            _furnitures.Remove(furniture);
        }

        public virtual int CalculateEnergyPerDay()
        {
            _energy = 0;
            
            foreach (IDevice device in _devices)
            {
                _energy += device.CalculateEnergyPerDay(1);
            }

            return _energy;
        }

        public virtual int CalculatePrice()
        {
            _price = 0;

            foreach (IDevice device in _devices)
            {
                _price += device.Price;
            }

            foreach (IFurniture furniture in _furnitures)
            {
                _price += furniture.Price;
            }

            return _price;
        }

        public virtual void Save()
        {
            // TODO: Add save logic.
        }
    }
}
