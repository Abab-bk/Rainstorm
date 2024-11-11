using System;

namespace Game.Scripts.Ui.ProjectItem;

public partial class ProjectItemPanel : ProjectItem
{
    public ProjectItemPanel Config(Configs.ProjectItem config, Action<string> path)
    {
        S_Name.Instance.Text = config.Name;
        S_Path.Instance.Text = config.Path;
        S_Button.Instance.Pressed += () => path(config.Path);
        return this;
    }
}
