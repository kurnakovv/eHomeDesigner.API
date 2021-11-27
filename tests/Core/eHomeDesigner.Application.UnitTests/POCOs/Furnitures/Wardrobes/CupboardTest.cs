using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures.Wardrobes;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures.Wardrobes
{
    public class CupboardTest
    {
        private readonly IWardrobe _cupboard = new Cupboard(
                                                       Guid.NewGuid(),
                                                       1000,
                                                       10,
                                                       50
                                                   );

        [Fact]
        public void CanInitCupboard_Cupboard()
        {
            Assert.NotNull(_cupboard);
        }

        [Fact]
        public void Type_CanGetType_Cupboard()
        {
            // Act
            string result = _cupboard.Type;

            // Assert
            Assert.Equal("Cupboard", result);
        }
    }
}
