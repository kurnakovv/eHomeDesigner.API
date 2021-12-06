using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;

namespace eHomeDesigner.Application.POCOs.Furnitures.ShelvingStorage;

public class Bookcase : IShelvingStorage
{
    public Guid Id { get; }

    public string Type => GetType().Name;

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
