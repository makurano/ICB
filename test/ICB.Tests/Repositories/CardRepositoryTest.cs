using ICB.Repositories;
using ICB.Repositories.Interfaces;
using NUnit.Framework;

namespace ICB.Tests.Repositories;

public class CardRepositoryTest
{
    private ICardRepository _repository;

    [SetUp]
    public void Setup()
    {
        _repository = new DraftCardRepository();
    }

    [Test]
    public void GetCharacteristics()
    {
        Assert.IsTrue(_repository.GetCharacteristics().Any());
    }
}
