using Game.Scripts.Data;
using Godot;

namespace Game.Scripts.Ui.GraphsUi;

public partial class GraphsUiPanel : GraphsUi
{
    private enum Page
    {
        Default,
        EditGraph
    }
    
    private ButtonGroup _buttonGroup = new ();
    private Graph _currentGraph;

    public override void _Ready()
    {
        base._Ready();

        VisibilityChanged += () =>
        {
            if (!Visible)
            {
                ChangePage(Page.Default);
            }
        };
        
        S_RepoLeftPanel.Instance.Config(
            Global.ProjectWriter.Project.GraphRepository,
            () => new Graph
            {
                Identifier = "New Graph"
            }
        );

        S_RepoLeftPanel.Instance.OnItemClicked += graph =>
        {
            _currentGraph = graph;
            UpdateGraphInfo();
            ChangePage(Page.EditGraph);
        };

        S_IdentifierLineEdit.Instance.TextChanged += text =>
        {
            _currentGraph.Identifier = text;
        };

        ChangePage(Page.Default);
    }
    
    private void UpdateGraphInfo()
    {
        if (_currentGraph == null)
        {
            S_IdentifierLineEdit.Instance.Text = "";
            return;
        }

        S_IdentifierLineEdit.Instance.Text = _currentGraph.Identifier;
    }

    private void ChangePage(Page page)
    {
        S_Pages.Instance.CurrentTab = (int)page;
        if (page == Page.EditGraph)
        {
            _currentGraph = null;
            UpdateGraphInfo();
        }
    }
}
