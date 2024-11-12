using System;
using System.Runtime.Serialization;

namespace Game.Scripts.Data;

public class Entity : IHasIdentifier
{
    public Action<string> OnIdentifierChanged { get; set; }
    
    [DataMember] public string Identifier
    {
        get => _identifier;
        set
        {
            _identifier = value;
            OnIdentifierChanged?.Invoke(Identifier);
        }
    }

    private string _identifier;
}