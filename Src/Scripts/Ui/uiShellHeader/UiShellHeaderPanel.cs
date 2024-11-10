using System.Collections.Generic;
using Game.Scripts.Configs;
using Godot;

namespace Game.Scripts.Ui.UiShellHeader;

public partial class UiShellHeaderPanel : UiShellHeader
{
    [Export] private string _title = "";

    public void SetTitle(string title)
    {
        _title = title;
        UpdateUi();
    }

    public override void _Ready()
    {
        base._Ready();
        UpdateUi();
    }

    public void UpdateUi()
    {
        S_Title.Instance.Text = _title;
    }

    public override void OnCreateUi()
    {
        UpdateUi();
    }

    public UiShellHeaderPanel SetButtons(IEnumerable<ActionWithName> buttons)
    {
        foreach (var child in S_MenuItems.Instance.GetChildren())
        {
            child.QueueFree();
        }

        var group = new ButtonGroup();
        var isFirst = true;
        
        foreach (var actionWithName in buttons)
        {
            var button = new Button
            {
                CustomMinimumSize = new Vector2(48f, 0f),
                Text = actionWithName.Name,
                ThemeTypeVariation = "HeaderMenuItemBtn",
                ToggleMode = true,
                ButtonGroup = group
            };
            S_MenuItems.Instance.AddChild(button);
            button.Pressed += actionWithName.Action;
            if (isFirst)
            {
                button.ButtonPressed = true;
                isFirst = false;
            }
        }
        
        return this;
    }
}
