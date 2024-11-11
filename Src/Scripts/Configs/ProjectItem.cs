using System.Runtime.Serialization;

namespace Game.Scripts.Configs;

public class ProjectItem
{
    [DataMember] public string Name { get; set; }
    [DataMember] public string Path { get; set; }

    public static bool operator ==(ProjectItem a, ProjectItem b)
    {
        return a?.Name == b?.Name && a?.Path == b?.Path;
    }
    
    public static bool operator !=(ProjectItem a, ProjectItem b)
    {
        return !(a == b);
    }
}