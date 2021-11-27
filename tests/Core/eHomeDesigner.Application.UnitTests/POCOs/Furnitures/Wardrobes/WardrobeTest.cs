﻿using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures.Wardrobes;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures.Wardrobes
{
    public class WardrobeTest
    {
        private readonly IWardrobe _wardrobe = new Wardrobe(
                                                       Guid.NewGuid(),
                                                       1000,
                                                       10,
                                                       50
                                                   );
        [Fact]
        public void CanInitWardrobe_Wardrobe()
        {
            Assert.NotNull(_wardrobe);
        }

        [Fact]
        public void Type_CanGetType_Wardrobe()
        {
            // Act
            string result = _wardrobe.Type;

            // Assert
            Assert.Equal("Wardrobe", result);
        }
    }
}
