namespace Game.Scripts.Ui.SearchBarUi;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class SearchBarUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: SearchBarUi.LineEdit
    /// </summary>
    public LineEdit L_LineEdit
    {
        get
        {
            if (_L_LineEdit == null) _L_LineEdit = new LineEdit((SearchBarUiPanel)this, GetNode<Godot.LineEdit>("LineEdit"));
            return _L_LineEdit;
        }
    }
    private LineEdit _L_LineEdit;


    public SearchBarUi() : base(nameof(SearchBarUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.LineEdit"/>, 路径: SearchBarUi.LineEdit
    /// </summary>
    public class LineEdit : UiNode<SearchBarUiPanel, Godot.LineEdit, LineEdit>
    {
        public LineEdit(SearchBarUiPanel uiPanel, Godot.LineEdit node) : base(uiPanel, node) {  }
        public override LineEdit Clone() => new (UiPanel, (Godot.LineEdit)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.LineEdit"/>, 节点路径: SearchBarUi.LineEdit
    /// </summary>
    public LineEdit S_LineEdit => L_LineEdit;

}
