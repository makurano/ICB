using ICB.Repositories;
using ICB.Services;
using NUnit.Framework;

namespace ICB.Tests;

public class CardServiceTest
{
    private CardService _service;

    [SetUp]
    public void Setup()
    {
        var repository = new DraftCardRepository();
        _service = new CardService(repository);
    }

    [Test]
    public void SetDeck()
    {
        Assert.IsTrue(_service._deck.Any());
    }

    [Test]
    public void Next()
    {
        var count = _service._deck.Count;
        for (int i = 1; i <= count; i++)
        {
            var first = _service.Next();
            Assert.IsNotNull(first);
        }
        Assert.Throws<InvalidOperationException>(() => _service.Next());
    }
}
