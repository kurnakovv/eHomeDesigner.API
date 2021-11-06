using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures.Wardrobes;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures.Wardrobes
{
    public class CupboardTest
    {
        [Fact]
        public void CanInitCupboard_Cupboard()
        {
            IWardrobe cupboard = new Cupboard(
                                        Guid.NewGuid(),
                                        1000,
                                        10,
                                        50
                                     );

            Assert.NotNull(cupboard);
        }
    }
}
