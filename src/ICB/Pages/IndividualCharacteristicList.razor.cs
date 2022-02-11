using ICB.Models;
using ICB.Services;
using Microsoft.AspNetCore.Components;

namespace ICB.Pages
{
	public partial class IndividualCharacteristicList
	{
		[Inject]
		private CardService _service { get; set; }

		private Characteristic Characteristic { get; set; }

		private void SetCharacteristic()
        {
			Characteristic = _service.Next();
        }
	}
}

