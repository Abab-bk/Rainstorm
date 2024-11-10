using System.Runtime.Serialization;

namespace Game.Scripts.Configs;

public class ProjectItem
{
    [DataMember] public string Name { get; set; }
    [DataMember] public string Path { get; set; }
}