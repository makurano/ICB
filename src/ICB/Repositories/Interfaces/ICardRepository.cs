using ICB.Models;

namespace ICB.Repositories.Interfaces;

public interface ICardRepository
{
    public List<Characteristic> GetCharacteristics();
}

