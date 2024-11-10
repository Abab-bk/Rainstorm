using System;
using Game.Scripts.Data;

namespace Game.Scripts;

public static class EventBus
{
    public static Action<Project> EnterProject { get; set; }

    static EventBus()
    {
        EnterProject += project =>
        {
            Logger.Log("[Enter Project]", project.ToToml());
        };
    }
}