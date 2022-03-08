using System.Runtime.CompilerServices;
using ICB.Models;
using ICB.Repositories.Interfaces;
[assembly: InternalsVisibleTo("ICB.Tests")]

namespace ICB.Services;

public class CardService
{
    private ICardRepository _cardRepository;

    public CardService(ICardRepository cardRepository)
    {
        _cardRepository = cardRepository;
        SetDeck();
    }

    internal List<Characteristic> _deck;


    public Characteristic Next()
    {
        var first = _deck.First();
        _deck.RemoveAll(x => x.Id == first.Id);
        return first;
    }

    private void SetDeck()
    {
        _deck = GetCharacteristics();
    }

    private List<Characteristic> GetCharacteristics()
    {
        var list = _cardRepository.GetCharacteristics();
        return Shuffle(list);
    }

    private List<T> Shuffle<T>(IEnumerable<T> collection)
    {
        return collection.OrderBy(i => Guid.NewGuid()).ToList();
    }
}

