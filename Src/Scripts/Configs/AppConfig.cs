using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Game.Scripts.Configs;

public class AppConfig
{
    [DataMember] public List<ProjectItem> RecentProjects { get; set; } = new();

    public void AddRecentProject(ProjectItem projectItem)
    {
        foreach (var recentProject in RecentProjects)
        {
            if (recentProject == projectItem) return;
        }
        RecentProjects.Add(projectItem);
        EventBus.RecentProjectsChanged?.Invoke(RecentProjects);
    }
}