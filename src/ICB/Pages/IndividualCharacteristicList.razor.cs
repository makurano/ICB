using System.Diagnostics;
using ICB.Models;
using ICB.Services;
using Microsoft.AspNetCore.Components;

namespace ICB.Pages;

public partial class IndividualCharacteristicList
{
    [Inject]
    private CardService _service { get; set; }

    private List<Player> Players { get; set; } = new();

    protected override async Task OnInitializedAsync()
    {
        Players.Add(new() { Id = 1 });
        Players.Add(new() { Id = 2 });
    }

    private void SetCharacteristic(int playerId)
    {
        var item = Players.Single(x => x.Id == playerId);
        item.Items.Add(_service.Next());
    }
}

[DebuggerDisplay("Id: {Id}, Items Count: {Items.Count}")]
public class Player
{
    public int Id { get; set; }

    public List<Characteristic> Items { get; set; } = new();
}
