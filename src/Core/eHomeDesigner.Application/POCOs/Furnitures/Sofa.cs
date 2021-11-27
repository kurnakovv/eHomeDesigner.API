﻿using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using System;

namespace eHomeDesigner.Application.POCOs.Furnitures
{
    public class Sofa : IFurniture
    {
        public Guid Id { get; }

        public string Type => GetType().Name;

        public int Price { get; }
        public int SquareMeters { get; }

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
}
