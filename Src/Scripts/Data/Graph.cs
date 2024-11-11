using System;
using System.Runtime.Serialization;

namespace Game.Scripts.Data;

public class Graph
{
    public Action<string> OnIdentifierChanged { get; set; }
    
    [DataMember] public string Identifier { get; set; } = "";
    [DataMember] public string SourceImagePath { get; set; } = "";
    
    public void SetIdentifier(string identifier)
    {
        Identifier = identifier;
        OnIdentifierChanged?.Invoke(identifier);
    }
}