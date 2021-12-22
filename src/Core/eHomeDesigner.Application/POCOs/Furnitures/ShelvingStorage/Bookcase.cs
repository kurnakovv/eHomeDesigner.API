using eHomeDesigner.Application.Interfaces.POCOs;
using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;

namespace eHomeDesigner.Application.POCOs.Furnitures.ShelvingStorage;

public class Bookcase : BaseShelvingStorage
{
    public override Guid Id { get; }

    public override string Type => GetType().Name;

    public override int Price { get; }
    public override int SquareMeters { get; }
    public override int Length { get; }

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
