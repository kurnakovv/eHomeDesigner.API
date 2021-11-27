using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using System;

namespace eHomeDesigner.Application.POCOs.Furnitures.Wardrobes
{
    public class Cupboard : IShelvingStorage
    {
        public Guid Id { get; }

        public string Type => GetType().Name;

        public int Price { get; }
        public int SquareMeters { get; }
        public int Length { get; }

        public Cupboard(
                Guid id,
                int price,
                int squareMeters,
                int length
            )
        {
            Id = id;
            Price = price;
            SquareMeters = squareMeters;
            Length = length;
        }
    }
}
