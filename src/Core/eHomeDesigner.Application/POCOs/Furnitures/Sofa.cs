﻿using eHomeDesigner.Application.Interfaces.POCOs;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using System;

namespace eHomeDesigner.Application.POCOs.Furnitures;

public class Sofa : BaseFurniture
{
    public override Guid Id { get; }

    public override string Type => GetType().Name;

    public override int Price { get; }
    public override int SquareMeters { get; }

    public Sofa(
            Guid id,
            int price,
            int squareMeters
        )
    {
        Id = id;
        Price = price;
        SquareMeters = squareMeters;
    }
}
