using System.Linq;
using ICB.Repositories;
using ICB.Services;
using NUnit.Framework;

namespace ICB.Tests;

public class CardServiceTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetCharacteristics()
    {
        var repository = new DraftCardRepository();
        var service = new CardService(repository);
        var list = service.GetCharacteristics();
        Assert.IsTrue(list.Any());
    }
}
