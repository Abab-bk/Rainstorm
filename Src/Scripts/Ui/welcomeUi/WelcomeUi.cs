namespace Game.Scripts.Ui.WelcomeUi;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class WelcomeUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: WelcomeUi.MarginContainer
    /// </summary>
    public MarginContainer L_MarginContainer
    {
        get
        {
            if (_L_MarginContainer == null) _L_MarginContainer = new MarginContainer((WelcomeUiPanel)this, GetNode<Godot.MarginContainer>("MarginContainer"));
            return _L_MarginContainer;
        }
    }
    private MarginContainer _L_MarginContainer;


    public WelcomeUi() : base(nameof(WelcomeUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: WelcomeUi.MarginContainer.VBoxContainer.Label
    /// </summary>
    public class Label : UiNode<WelcomeUiPanel, Godot.Label, Label>
    {
        public Label(WelcomeUiPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: WelcomeUi.MarginContainer.VBoxContainer.Buttons.NewProjectBtn
    /// </summary>
    public class NewProjectBtn : UiNode<WelcomeUiPanel, Godot.Button, NewProjectBtn>
    {
        public NewProjectBtn(WelcomeUiPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override NewProjectBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: WelcomeUi.MarginContainer.VBoxContainer.Buttons.LoadProjectBtn
    /// </summary>
    public class LoadProjectBtn : UiNode<WelcomeUiPanel, Godot.Button, LoadProjectBtn>
    {
        public LoadProjectBtn(WelcomeUiPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override LoadProjectBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: WelcomeUi.MarginContainer.VBoxContainer.Buttons.ExitBtn
    /// </summary>
    public class ExitBtn : UiNode<WelcomeUiPanel, Godot.Button, ExitBtn>
    {
        public ExitBtn(WelcomeUiPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override ExitBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: WelcomeUi.MarginContainer.VBoxContainer.Buttons
    /// </summary>
    public class Buttons : UiNode<WelcomeUiPanel, Godot.VBoxContainer, Buttons>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: WelcomeUi.MarginContainer.VBoxContainer.NewProjectBtn
        /// </summary>
        public NewProjectBtn L_NewProjectBtn
        {
            get
            {
                if (_L_NewProjectBtn == null) _L_NewProjectBtn = new NewProjectBtn(UiPanel, Instance.GetNode<Godot.Button>("NewProjectBtn"));
                return _L_NewProjectBtn;
            }
        }
        private NewProjectBtn _L_NewProjectBtn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: WelcomeUi.MarginContainer.VBoxContainer.LoadProjectBtn
        /// </summary>
        public LoadProjectBtn L_LoadProjectBtn
        {
            get
            {
                if (_L_LoadProjectBtn == null) _L_LoadProjectBtn = new LoadProjectBtn(UiPanel, Instance.GetNode<Godot.Button>("LoadProjectBtn"));
                return _L_LoadProjectBtn;
            }
        }
        private LoadProjectBtn _L_LoadProjectBtn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: WelcomeUi.MarginContainer.VBoxContainer.ExitBtn
        /// </summary>
        public ExitBtn L_ExitBtn
        {
            get
            {
                if (_L_ExitBtn == null) _L_ExitBtn = new ExitBtn(UiPanel, Instance.GetNode<Godot.Button>("ExitBtn"));
                return _L_ExitBtn;
            }
        }
        private ExitBtn _L_ExitBtn;

        public Buttons(WelcomeUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override Buttons Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: WelcomeUi.MarginContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<WelcomeUiPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: WelcomeUi.MarginContainer.Label
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: WelcomeUi.MarginContainer.Buttons
        /// </summary>
        public Buttons L_Buttons
        {
            get
            {
                if (_L_Buttons == null) _L_Buttons = new Buttons(UiPanel, Instance.GetNode<Godot.VBoxContainer>("Buttons"));
                return _L_Buttons;
            }
        }
        private Buttons _L_Buttons;

        public VBoxContainer(WelcomeUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: WelcomeUi.MarginContainer
    /// </summary>
    public class MarginContainer : UiNode<WelcomeUiPanel, Godot.MarginContainer, MarginContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: WelcomeUi.VBoxContainer
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

        public MarginContainer(WelcomeUiPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override MarginContainer Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: WelcomeUi.MarginContainer.VBoxContainer.Label
    /// </summary>
    public Label S_Label => L_MarginContainer.L_VBoxContainer.L_Label;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: WelcomeUi.MarginContainer.VBoxContainer.Buttons.NewProjectBtn
    /// </summary>
    public NewProjectBtn S_NewProjectBtn => L_MarginContainer.L_VBoxContainer.L_Buttons.L_NewProjectBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: WelcomeUi.MarginContainer.VBoxContainer.Buttons.LoadProjectBtn
    /// </summary>
    public LoadProjectBtn S_LoadProjectBtn => L_MarginContainer.L_VBoxContainer.L_Buttons.L_LoadProjectBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: WelcomeUi.MarginContainer.VBoxContainer.Buttons.ExitBtn
    /// </summary>
    public ExitBtn S_ExitBtn => L_MarginContainer.L_VBoxContainer.L_Buttons.L_ExitBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: WelcomeUi.MarginContainer.VBoxContainer.Buttons
    /// </summary>
    public Buttons S_Buttons => L_MarginContainer.L_VBoxContainer.L_Buttons;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: WelcomeUi.MarginContainer.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_MarginContainer.L_VBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: WelcomeUi.MarginContainer
    /// </summary>
    public MarginContainer S_MarginContainer => L_MarginContainer;

}
