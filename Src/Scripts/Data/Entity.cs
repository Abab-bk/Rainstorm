using System.Runtime.Serialization;

namespace Game.Scripts.Data;

public class Entity
{
    [DataMember] public string Name { get; set; }
}