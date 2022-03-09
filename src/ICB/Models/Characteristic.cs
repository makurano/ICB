using System.Diagnostics;

namespace ICB.Models;

[DebuggerDisplay("Name = {Name}")]
public class Characteristic
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public bool IsRare { get; set; }
}

