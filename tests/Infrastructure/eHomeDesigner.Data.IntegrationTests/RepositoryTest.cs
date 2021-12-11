using eHomeDesigner.Application.Interfaces.POCOs;
using eHomeDesigner.Application.Interfaces.Repositories;
using eHomeDesigner.Data.IntegrationTests.Mocks;
using eHomeDesigner.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace eHomeDesigner.Data.IntegrationTests;

public class RepositoryTest : IDisposable
{
    private readonly IRepository<MockPOCO> _repository;
    private readonly MockDbContext _context;

    public RepositoryTest()
    {
        var options = new DbContextOptionsBuilder<MockDbContext>()
                              .UseInMemoryDatabase(Guid.NewGuid().ToString())
                              .Options;

        _context = new MockDbContext(options);
        _repository = new Repository<MockEntity, MockPOCO>(new MockDbContext(options));
        SeedContext();
    }

    public void Dispose()
    {
        _context.Database.EnsureDeleted();
        _context.DisposeAsync();
    }

    private void SeedContext()
    {
        _context.AddRange(new List<MockEntity>() { new MockEntity(), new MockEntity(), new MockEntity() });
        _context.SaveChanges();
    }

    //[Fact]
    //public void GetAll_CanGetEntities_Entities()
    //{
    //    // Act
    //    IReadOnlyCollection<MockPOCO> result = _repository.GetAll();

    //    // Assert
    //    Assert.Equal(3, result.Count);
    //}
}
