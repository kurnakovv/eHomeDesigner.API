using AutoMapper;
using eHomeDesigner.Application.Interfaces.Converters;
using eHomeDesigner.Application.Interfaces.POCOs;
using eHomeDesigner.Application.Interfaces.Repositories;
using eHomeDesigner.Converters.AutoMapper;
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
    private readonly IConverter _converter;

    public RepositoryTest()
    {
        var options = new DbContextOptionsBuilder<MockDbContext>()
                              .UseInMemoryDatabase(Guid.NewGuid().ToString())
                              .Options;

        _context = new MockDbContext(options);

        var configuration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<MockEntity, MockPOCO>().ReverseMap();
            cfg.CreateMap<List<MockEntity>, List<MockPOCO>>().ReverseMap();
        });
        configuration.AssertConfigurationIsValid();
        IMapper mapper = configuration.CreateMapper();

        _converter = new Converter(mapper);

        _repository = new Repository<MockEntity, MockPOCO>(new MockDbContext(options), _converter);
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

    [Fact]
    public void GetAll_CanGetEntities_Entities()
    {
        // Act
        IReadOnlyCollection<MockPOCO> result = _repository.GetAll();

        // Assert
        Assert.Equal(3, result.Count);
    }

    [Fact]
    public void GetById_CanGetPOCOById_POCO()
    {
        // Arrange
        var entity = new MockEntity();
        _context.Add(entity);
        _context.SaveChanges();

        // Act
        MockPOCO result = _repository.GetById(entity.Id);

        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public void GetById_CannotGetByIdIfEntityNotFound_Null()
    {
        // Act
        MockPOCO result = _repository.GetById(Guid.NewGuid());

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Update_CanUpdateEntityByPOCO_NotExceptions()
    {
        // Arrange
        var poco = new MockPOCO();

        // Act
        Exception exception = Record.Exception(() => _repository.Update(Guid.NewGuid(), poco));

        // Assert
        Assert.Null(exception);
    }

    [Fact]
    public void Add_CanAddNewPOCO_NotExceptions()
    {
        // Arrange
        var poco = new MockPOCO();

        // Act
        Exception exception = Record.Exception(() => _repository.Add(poco));

        // Assert
        Assert.Null(exception);
    }

    [Fact]
    public void Commit_CanCommit_NotExceptions()
    {
        // Act
        Exception exception = Record.Exception(() => _repository.Commit());

        // Assert
        Assert.Null(exception);
    }

    [Fact]
    public void DeleteById_CanDeleteById_NotExceptions()
    {
        var entity = new MockEntity();
        _context.MockEntities.Add(entity);
        _context.SaveChanges();

        // Act
        Exception exception = Record.Exception(() => _repository.DeleteById(entity.Id));

        // Assert
        Assert.Null(exception);
    }
}
