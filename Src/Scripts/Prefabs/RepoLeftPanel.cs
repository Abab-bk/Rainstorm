using System;
using AcidUtilities;
using Game.Scripts.Data;
using Game.Scripts.Repositories;
using Game.Scripts.Ui.SearchBarUi;
using Godot;
using OnReadyCs;

namespace Game.Scripts.Prefabs;

/// <summary>
/// For graph ui, cuz godot problem...
/// </summary>
/// <typeparam name="T"></typeparam>
public partial class RepoLeftPanel : Control
{
    [OnReady("%SearchBarUi")] private SearchBarUiPanel _searchBarUiPanel;
    [OnReady("%Items")] private VBoxContainer _items;
    [OnReady("%NewItemBtn")] private Button _newItemBtn;
    
    public event Action<Graph> OnItemClicked;
    
    private Func<Graph> _onClickNewButtonGet;
    
    private IRepository<Graph> _repository;
    private ButtonGroup _buttonGroup = new ();
    
    public static RepoLeftPanel Create()
    {
        return GD
            .Load<PackedScene>("res://Scenes/RepoLeftPanel.tscn")
            .Instantiate<RepoLeftPanel>();
    }

    public override void _Ready()
    {
        this.InitializeOnReadyFields();
    }

    public RepoLeftPanel Config(
        IRepository<Graph> repository,
        Func<Graph> onClickNewButtonGet
        )
    {
        _repository = repository;
        
        _repository.OnAdd += OnAdd;
        _repository.OnRemove += OnRemove;
        
        _onClickNewButtonGet = onClickNewButtonGet;

        _searchBarUiPanel.OnQueryChanged += query =>
        {
            foreach (var child in _items.GetChildren())
            {
                if (child is not Control control) continue;

                if (query == "")
                {
                    control.Visible = true;
                    continue;
                }

                control.Visible = false;
                
                if (!control.HasMeta("Identifier")) continue;
                if (((string)control.GetMeta("Identifier")).StartsWith(query))
                {
                    control.Visible = true;
                }
            }
        };
        
        _newItemBtn.Pressed += () =>
        {
            _repository.Add(onClickNewButtonGet());
        };

        UpdateUi();
        
        return this;
    }

    private void OnAdd(Graph item)
    {
        AddItem(item);
    }
    
    private void OnRemove(Graph item)
    {
        UpdateUi();
    }

    public Button SearchButton(string id)
    {
        foreach (var child in _items.GetChildren())
        {
            if (child is not Button button) continue;
            if (!button.HasMeta("Identifier")) continue;
            if ((string)button.GetMeta("Identifier") != id) continue;
            return button;
        }

        return null;
    }
    
    private void UpdateUi()
    {
        _items.RemoveAllChildren();
        foreach (var item in _repository.GetItems())
        {
            AddItem(item);
        }
    }

    private void AddItem(Graph item)
    {
        var button = new Button
        {
            Alignment = HorizontalAlignment.Left,
            CustomMinimumSize = new Vector2(0f, 48f),
            ThemeTypeVariation = "TabButton",
            ToggleMode = true,
            ButtonGroup = _buttonGroup
        };
        
        _items.AddChild(button);
        
        item.OnIdentifierChanged += identifier =>
        {
            button.Text = identifier;
            button.SetMeta("Identifier", item.Identifier);
        };
        
        button.Text = item.Identifier;
        button.SetMeta("Identifier", item.Identifier);

        button.Pressed += () =>
        {
            OnItemClicked?.Invoke(item);
        };
        
        OnItemClicked?.Invoke(item);
    }
}
