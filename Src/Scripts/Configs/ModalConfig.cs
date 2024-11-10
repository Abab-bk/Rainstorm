using Godot;

namespace Game.Scripts.Configs;

public class ModalConfig(
    string title,
    string optionLabel = "",
    string content = "",
    Node slot = null,
    ActionWithName action1 = null,
    ActionWithName cancelAction = null,
    ActionWithName action2 = null,
    ActionWithName action3 = null
    )
{
    public string Title { get; set; } = title;
    public string OptionLabel { get; set; } = optionLabel;
    public string Content { get; set; } = content;
    public Node Slot { get; set; } = slot;
    public ActionWithName Action1 { get; set; } = action1;
    public ActionWithName CancelAction { get; set; } = cancelAction;
    public ActionWithName Action2 { get; set; } = action2;
    public ActionWithName Action3 { get; set; } = action3;
}