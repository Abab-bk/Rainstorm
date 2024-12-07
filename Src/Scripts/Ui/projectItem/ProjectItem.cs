namespace Game.Scripts.Ui.ProjectItem;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class ProjectItem : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: ProjectItem.Button
    /// </summary>
    public Button L_Button
    {
        get
        {
            if (_L_Button == null) _L_Button = new Button((ProjectItemPanel)this, GetNode<Godot.Button>("Button"));
            return _L_Button;
        }
    }
    private Button _L_Button;


    public ProjectItem() : base(nameof(ProjectItem))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: ProjectItem.Button.MarginContainer.VBoxContainer.Name
    /// </summary>
    public class Name : UiNode<ProjectItemPanel, Godot.Label, Name>
    {
        public Name(ProjectItemPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Name Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: ProjectItem.Button.MarginContainer.VBoxContainer.Path
    /// </summary>
    public class Path : UiNode<ProjectItemPanel, Godot.Label, Path>
    {
        public Path(ProjectItemPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Path Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: ProjectItem.Button.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<ProjectItemPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: ProjectItem.Button.MarginContainer.Name
        /// </summary>
        public Name L_Name
        {
            get
            {
                if (_L_Name == null) _L_Name = new Name(UiPanel, Instance.GetNode<Godot.Label>("Name"));
                return _L_Name;
            }
        }
        private Name _L_Name;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: ProjectItem.Button.MarginContainer.Path
        /// </summary>
        public Path L_Path
        {
            get
            {
                if (_L_Path == null) _L_Path = new Path(UiPanel, Instance.GetNode<Godot.Label>("Path"));
                return _L_Path;
            }
        }
        private Path _L_Path;

        public VBoxContainer(ProjectItemPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: ProjectItem.Button.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<ProjectItemPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ProjectItem.Button.VBoxContainer
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
    /// 类型: <see cref="Godot.Button"/>, 路径: ProjectItem.Button
    /// </summary>
    public class Button : UiNode<ProjectItemPanel, Godot.Button, Button>
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

        public Button(ProjectItemPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Button Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: ProjectItem.Button.MarginContainer.VBoxContainer.Name
    /// </summary>
    public Name S_Name => L_Button.L_MarginContainer.L_VBoxContainer.L_Name;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: ProjectItem.Button.MarginContainer.VBoxContainer.Path
    /// </summary>
    public Path S_Path => L_Button.L_MarginContainer.L_VBoxContainer.L_Path;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ProjectItem.Button.MarginContainer.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_Button.L_MarginContainer.L_VBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: ProjectItem.Button.MarginContainer
    /// </summary>
    public MarginContainer S_MarginContainer => L_Button.L_MarginContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: ProjectItem.Button
    /// </summary>
    public Button S_Button => L_Button;

}
