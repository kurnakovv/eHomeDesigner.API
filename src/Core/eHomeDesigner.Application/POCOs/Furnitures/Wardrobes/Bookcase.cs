using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using System;

namespace eHomeDesigner.Application.POCOs.Furnitures.Wardrobes
{
    public class Bookcase : IWardrobe
    {
        public Guid Id { get; }

        public int Price { get; }
        public int SquareMeters { get; }
        public int Length { get; }

        public Bookcase(
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
