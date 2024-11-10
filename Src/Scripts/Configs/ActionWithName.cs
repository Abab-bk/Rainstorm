using System;

namespace Game.Scripts.Configs;

public class ActionWithName(string name, Action action)
{
    public string Name => name;
    public Action Action => action;
}