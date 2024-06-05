using AutoFixture.Xunit2;
using RookEcomShop.Persistence.Repositories;
using RookEcomShop.Persistence.UnitTest.TestUtils;

namespace RookEcomShop.Persistence.UnitTest.Repositories;

public class BaseRepositoryTests : TestSetup
{
    [Theory, AutoData]
    public void Create_ShouldAddEntityToContext(
               ConcreteBaseEntity entity)
    {
        // Arrange
        var repository = new BaseRepository<ConcreteBaseEntity>(_dbContextMock);

        // Act
        repository.Create(entity);
        _dbContextMock.SaveChanges();

        // Assert
        var createdEntity = _dbContextMock.Set<ConcreteBaseEntity>().Find(entity.Id);
        Assert.NotNull(createdEntity);
    }

    [Theory, AutoData]
    public void Delete_ShouldRemoveEntityFromContext(
        ConcreteBaseEntity entity)
    {
        // Arrange
        _dbContextMock.Add(entity);
        _dbContextMock.SaveChanges();
        var repository = new BaseRepository<ConcreteBaseEntity>(_dbContextMock);

        // Act
        repository.Delete(entity);
        _dbContextMock.SaveChanges();

        // Assert
        var deletedEntity = _dbContextMock.Set<ConcreteBaseEntity>().Find(entity.Id);
        Assert.Null(deletedEntity);
    }

    [Theory, AutoData]
    public void Update_ShouldUpdateEntityInContext(
        ConcreteBaseEntity entity)
    {
        // Arrange
        _dbContextMock.Add(entity);
        _dbContextMock.SaveChanges();
        var repository = new BaseRepository<ConcreteBaseEntity>(_dbContextMock);

        // Act
        entity.UpdatedAt = DateTime.UtcNow;
        repository.Update(entity);
        _dbContextMock.SaveChanges();

        // Assert
        var updatedEntity = _dbContextMock.Set<ConcreteBaseEntity>().Find(entity.Id);
        Assert.Equal(entity.UpdatedAt, updatedEntity.UpdatedAt);
    }
}