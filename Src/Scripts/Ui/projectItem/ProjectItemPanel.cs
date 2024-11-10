namespace Game.Scripts.Ui.ProjectItem;

public partial class ProjectItemPanel : ProjectItem
{
    public ProjectItemPanel Config(Configs.ProjectItem config)
    {
        S_Name.Instance.Text = config.Name;
        S_Path.Instance.Text = config.Path;
        return this;
    }
}
