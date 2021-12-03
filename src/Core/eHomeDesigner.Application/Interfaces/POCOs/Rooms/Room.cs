using eHomeDesigner.Application.Interfaces.POCOs.Devices;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eHomeDesigner.Application.Interfaces.POCOs.Rooms;

public abstract class Room : IRoom
{
    public Guid Id { get; } = Guid.NewGuid();
    public Guid CustomerId { get; }

    public abstract string Type { get; }

    public int SquareMeters { get; }

    public IReadOnlyCollection<IFurniture> Furnitures => _furnitureRepository.GetAll();
    public IReadOnlyCollection<IDevice> Devices => _deviceRepository.GetAll();

    private readonly IFurnitureRepository _furnitureRepository;
    private readonly IDeviceRepository _deviceRepository;

    private int _energy = 0;
    private int _price = 0;

    public Room(
               Guid customerId,
               int squareMeters,
               IFurnitureRepository furnitureRepository,
               IDeviceRepository deviceRepository
           )
    {
        CustomerId = customerId;
        SquareMeters = squareMeters;
        _furnitureRepository = furnitureRepository;
        _deviceRepository = deviceRepository;
    }

    public virtual void AddDevice(IDevice device)
    {
        _deviceRepository.Add(device);
    }

    public virtual void AddFurniture(IFurniture furniture)
    {
        _furnitureRepository.Add(furniture);
    }

    public virtual void DeleteDevice(Guid id)
    {
        _deviceRepository.DeleteById(id);
    }

    public virtual void DeleteFurniture(Guid id)
    {
        _furnitureRepository.DeleteById(id);
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

        foreach (IFurniture furniture in Furnitures)
        {
            _price += furniture.Price;
        }

        return _price;
    }

    public virtual void Save()
    {
        _furnitureRepository.Commit();
        _deviceRepository.Commit();
    }
}