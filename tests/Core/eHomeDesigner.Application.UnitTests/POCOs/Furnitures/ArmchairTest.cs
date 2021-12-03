using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures;

public class ArmchairTest
{
    private readonly IFurniture _armchair = new Armchair(
                                                    Guid.NewGuid(),
                                                    1000,
                                                    5
                                                );
    [Fact]
    public void CanInitArmchair_Armchair()
    {
        Assert.NotNull(_armchair);
    }

    [Fact]
    public void Type_CanGetType_Armchair()
    {
        // Act
        string result = _armchair.Type;

        // Assert
        Assert.Equal("Armchair", result);
    }
}
