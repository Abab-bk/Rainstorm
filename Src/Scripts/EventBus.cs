﻿using System;
using System.Collections.Generic;
using Game.Scripts.Configs;
using Game.Scripts.Data;

namespace Game.Scripts;

public static class EventBus
{
    public static Action<Project> EnterProject { get; set; }
    public static Action<List<ProjectItem>> RecentProjectsChanged { get; set; }

    static EventBus()
    {
        EnterProject += project =>
        {
            Logger.Log("[Enter Project]", project.ToToml());
        };
    }
}