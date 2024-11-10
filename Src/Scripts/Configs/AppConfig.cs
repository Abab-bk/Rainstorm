using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Game.Scripts.Configs;

public class AppConfig
{
    [DataMember] public List<ProjectItem> RecentProjects { get; set; } = new();
}