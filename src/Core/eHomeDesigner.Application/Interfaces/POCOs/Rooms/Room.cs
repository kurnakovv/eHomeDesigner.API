using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eHomeDesigner.Application.Interfaces.POCOs.Rooms
{
    public abstract class Room : IRoom
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid CustomerId { get; }

        public virtual string Type { get; }

        public int SquareMeters { get; }

	    public IReadOnlyCollection<IFurniture> Furnitures => _furnitures.ToList();
	    public IReadOnlyCollection<IDevice> Devices => _deviceRepository.GetAll();

        private IList<IFurniture> _furnitures = new List<IFurniture>();
        private readonly IDeviceRepository _deviceRepository;

        private int _energy = 0;
        private int _price = 0;

        public Room(
                   Guid customerId,
                   int squareMeters,
                   IDeviceRepository deviceRepository
               )
        {
            CustomerId = customerId;
            SquareMeters = squareMeters;
            _deviceRepository = deviceRepository;

        }

        public virtual void AddDevice(IDevice device)
        {
            _deviceRepository.Add(device);
        }

        public virtual void AddFurniture(IFurniture furniture)
        {
            _furnitures.Add(furniture);
        }

        public virtual void DeleteDevice(Guid id)
        {
            _deviceRepository.DeleteById(id);
        }

        public virtual void DeleteFurniture(Guid id)
        {
            IFurniture furniture = _furnitures.FirstOrDefault(f => f.Id == id);
            _furnitures.Remove(furniture);
        }

        public virtual int CalculateEnergyPerDay()
        {
            _energy = 0;
            
            foreach (IDevice device in Devices)
            {
                _energy += device.CalculateEnergyPerDay(1);
            }

            return _energy;
        }

        public virtual int CalculatePrice()
        {
            _price = 0;

            foreach (IDevice device in Devices)
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
