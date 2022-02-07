using System;
using ICB.Models;
using ICB.Repositories.Interfaces;

namespace ICB.Services
{
	public class CardService
	{
		private ICardRepository _cardRepository;

		public CardService(ICardRepository cardRepository)
		{
			_cardRepository = cardRepository;
		}

		public List<Characteristic> GetCharacteristics()
        {
			var list = _cardRepository.GetCharacteristics();
			return Shuffle(list);
        }

		private List<T> Shuffle<T>(IEnumerable<T> collection)
        {
			return collection.OrderBy(i => Guid.NewGuid()).ToList();
        }
	}
}

