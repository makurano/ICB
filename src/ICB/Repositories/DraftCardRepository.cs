using System;
using ICB.Models;
using ICB.Repositories.Interfaces;

namespace ICB.Repositories
{
	/// <summary>
    /// クラスを直に生成するリポジトリ
    /// </summary>
	public class DraftCardRepository : ICardRepository
	{
		public DraftCardRepository()
		{
			_characteristics = new()
			{
				new Characteristic() { Id = 1, Name = "むな毛ボーボー", IsRare = false },
				new Characteristic() { Id = 2, Name = "足早い", IsRare = false },
				new Characteristic() { Id = 3, Name = "身長198cm", IsRare = false },
				new Characteristic() { Id = 4, Name = "名前は木村拓哉", IsRare = true },
				new Characteristic() { Id = 5, Name = "しし座", IsRare = false },
			};
		}

		private List<Characteristic> _characteristics;

		public List<Characteristic> GetCharacteristics()
        {
			return _characteristics;
        }
	}
}

