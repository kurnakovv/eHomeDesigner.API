using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures.Wardrobes;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures.Wardrobes
{
    public class WardrobeTest
    {
        [Fact]
        public void CanInitWardrobe_Wardrobe()
        {
            IWardrobe wardrobe = new Wardrobe(
                                        Guid.NewGuid(),
                                        1000,
                                        10,
                                        50
                                     );

            Assert.NotNull(wardrobe);
        }
    }
}
