using eHomeDesigner.Application.Interfaces.POCOs.Furnitures;
using eHomeDesigner.Application.POCOs.Furnitures.Wardrobes;
using System;
using Xunit;

namespace eHomeDesigner.Application.UnitTests.POCOs.Furnitures.Wardrobes
{
    public class BookcaseTest 
    { 
        [Fact]
        public void CanInitBookcase_Bookcase()
        {
            IWardrobe bookcase = new Bookcase(
                                         Guid.NewGuid(),
                                         1000,
                                         10,
                                         50
                                     );

            Assert.NotNull(bookcase);
        }
    }
}
