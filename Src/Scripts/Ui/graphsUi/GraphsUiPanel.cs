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
    private Graph _selectedGraph;

    public override void _Ready()
    {
        base._Ready();
        S_NewGraphBtn.Instance.Pressed += () =>
        {
            Global.ProjectWriter.Project.AddGraph(
                new Graph
                {
                    Identifier = "New Graph"
                }
            );
        };
        S_IdentifierLineEdit.Instance.TextChanged += identifier =>
        {
            if (_selectedGraph == null) return;
            _selectedGraph.SetIdentifier(identifier);
        };
        S_SearchBarUi.Instance.OnQueryChanged += query =>
        {
            foreach (var child in S_GraphButtons.Instance.GetChildren())
            {
                if (child is not Godot.Control control) continue;

                if (query == "")
                {
                    control.Visible = true;
                    continue;
                }

                control.Visible = false;
                
                if (!control.HasMeta("GraphId")) continue;
                if (((string)control.GetMeta("GraphId")).StartsWith(query))
                {
                    control.Visible = true;
                }
            }
        };

        Global.ProjectWriter.Project.OnGraphAdded += graph =>
        {
            UpdateGraphs();
            var button = SearchGraphButton(graph.Identifier);
            if (button != null)
            {
                button.ButtonPressed = true;
                _selectedGraph = graph;
                ChangePage(Page.EditGraph);
            }
        };
        
        Global.ProjectWriter.Project.OnGraphRemoved += graph =>
        {
            UpdateGraphs();
            _selectedGraph = null;
            ChangePage(Page.Default);
        };

        ChangePage(Page.Default);

        UpdateGraphs();
    }

    private Button SearchGraphButton(string id)
    {
        foreach (var child in S_GraphButtons.Instance.GetChildren())
        {
            if (child is not Button button) continue;
            if (button.HasMeta("GraphId") && (string)button.GetMeta("GraphId") == id)
            {
                return button;
            }
        }

        return null;
    }

    // FIXME: refactor
    private void UpdateGraphs()
    {
        foreach (var child in S_GraphButtons.Instance.GetChildren())
        {
            child.QueueFree();
        }
        
        foreach (var graph in Global.ProjectWriter.Project.Graphs)
        {
            AddNewGraph(graph);
        }
    }

    private void AddNewGraph(Graph graph)
    {
        var button = new Button
        {
            Alignment = HorizontalAlignment.Left,
            CustomMinimumSize = new Vector2(0f, 48f),
            ThemeTypeVariation = "TabButton",
            ToggleMode = true,
            ButtonGroup = _buttonGroup
        };
        
        S_GraphButtons.Instance.AddChild(button);
        
        graph.OnIdentifierChanged += identifier =>
        {
            button.Text = identifier;
            button.SetMeta("GraphId", graph.Identifier);
        };
        
        button.Text = graph.Identifier;
        button.SetMeta("GraphId", graph.Identifier);

        button.Pressed += () =>
        {
            _selectedGraph = graph;
            ChangePage(Page.EditGraph);
        };
    }

    private void UpdateGraphInfo()
    {
        if (_selectedGraph == null) return;
        S_IdentifierLineEdit.Instance.Text = _selectedGraph.Identifier;
    }

    private void ChangePage(Page page)
    {
        S_Pages.Instance.CurrentTab = (int)page;
        if (page == Page.EditGraph)
            UpdateGraphInfo();
    }
}
