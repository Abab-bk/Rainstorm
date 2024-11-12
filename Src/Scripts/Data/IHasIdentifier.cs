using System;

namespace Game.Scripts.Data;

public interface IHasIdentifier
{
    public Action<string> OnIdentifierChanged { get; set; }
    public string Identifier { get; }
}