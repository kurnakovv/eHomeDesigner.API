﻿using eHomeDesigner.Application.Interfaces.POCOs;
using eHomeDesigner.Application.Interfaces.POCOs.Devices;

namespace eHomeDesigner.Application.POCOs.Devices;

public class Computer : BaseDevice
{
    public override Guid Id { get; }

    public override string Type => GetType().Name;

    public override int Price { get; }
    public override int SquareMeters { get; }
    public override int EnergyPerHour { get; }

    public override string Author { get; }


    private const int DAY = 24;
    private const double COMPUTER_ENERGY_PERCENTAGE = 0.3;

    public Computer(
               Guid id,
               int price,
               int squareMeters,
               int energyPerHour,
               string author
           )
    {
        Id = id;
        Price = price;
        SquareMeters = squareMeters;
        EnergyPerHour = energyPerHour;
        Author = author;
    }

    public override int CalculateEnergyPerDay(int days)
    {
        int energy = (EnergyPerHour * DAY) * days;
        return energy;
    }

    public override int CalculateEnergyPrice(int energy)
    {
        int price = (int)(energy * COMPUTER_ENERGY_PERCENTAGE);
        return price;
    }
}
