namespace Game.Scripts.Ui.ProjectItem;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class ProjectItem : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: ProjectItem.PanelContainer
    /// </summary>
    public PanelContainer L_PanelContainer
    {
        get
        {
            if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer((ProjectItemPanel)this, GetNode<Godot.Button>("PanelContainer"));
            return _L_PanelContainer;
        }
    }
    private PanelContainer _L_PanelContainer;


    public ProjectItem() : base(nameof(ProjectItem))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: ProjectItem.PanelContainer.MarginContainer.VBoxContainer.Label
    /// </summary>
    public class Label : UiNode<ProjectItemPanel, Godot.Label, Label>
    {
        public Label(ProjectItemPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: ProjectItem.PanelContainer.MarginContainer.VBoxContainer.Label2
    /// </summary>
    public class Label2 : UiNode<ProjectItemPanel, Godot.Label, Label2>
    {
        public Label2(ProjectItemPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label2 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: ProjectItem.PanelContainer.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<ProjectItemPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: ProjectItem.PanelContainer.MarginContainer.Label
        /// </summary>
        public Label L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label _L_Label;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: ProjectItem.PanelContainer.MarginContainer.Label2
        /// </summary>
        public Label2 L_Label2
        {
            get
            {
                if (_L_Label2 == null) _L_Label2 = new Label2(UiPanel, Instance.GetNode<Godot.Label>("Label2"));
                return _L_Label2;
            }
        }
        private Label2 _L_Label2;

        public VBoxContainer(ProjectItemPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: ProjectItem.PanelContainer.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<ProjectItemPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ProjectItem.PanelContainer.VBoxContainer
        /// </summary>
        public VBoxContainer L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer _L_VBoxContainer;

        public MarginContainer(ProjectItemPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: ProjectItem.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<ProjectItemPanel, Godot.Button, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: ProjectItem.MarginContainer
        /// </summary>
        public MarginContainer L_MarginContainer
        {
            get
            {
                if (_L_MarginContainer == null) _L_MarginContainer = new MarginContainer(UiPanel, Instance.GetNode<Godot.MarginContainer>("MarginContainer"));
                return _L_MarginContainer;
            }
        }
        private MarginContainer _L_MarginContainer;

        public PanelContainer(ProjectItemPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: ProjectItem.PanelContainer.MarginContainer.VBoxContainer.Label
    /// </summary>
    public Label S_Label => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_Label;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: ProjectItem.PanelContainer.MarginContainer.VBoxContainer.Label2
    /// </summary>
    public Label2 S_Label2 => L_PanelContainer.L_MarginContainer.L_VBoxContainer.L_Label2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ProjectItem.PanelContainer.MarginContainer.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_PanelContainer.L_MarginContainer.L_VBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: ProjectItem.PanelContainer.MarginContainer
    /// </summary>
    public MarginContainer S_MarginContainer => L_PanelContainer.L_MarginContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: ProjectItem.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_PanelContainer;

}
