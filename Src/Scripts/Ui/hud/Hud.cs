namespace Game.Scripts.Ui.Hud;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Hud : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: Hud.VBoxContainer
    /// </summary>
    public VBoxContainer L_VBoxContainer
    {
        get
        {
            if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer((HudPanel)this, GetNode<Godot.VBoxContainer>("VBoxContainer"));
            return _L_VBoxContainer;
        }
    }
    private VBoxContainer _L_VBoxContainer;


    public Hud() : base(nameof(Hud))
    {
    }

    public sealed override void OnInitNestedUi()
    {

        var inst1 = L_VBoxContainer;
        RecordNestedUi(inst1.L_UiShellHeader.Instance, inst1, UiManager.RecordType.Open);
        inst1.L_UiShellHeader.Instance.OnCreateUi();
        inst1.L_UiShellHeader.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel"/>, 路径: Hud.VBoxContainer.UiShellHeader
    /// </summary>
    public class UiShellHeader : UiNode<HudPanel, Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel, UiShellHeader>
    {
        public UiShellHeader(HudPanel uiPanel, Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel node) : base(uiPanel, node) {  }
        public override UiShellHeader Clone()
        {
            var uiNode = new UiShellHeader(UiPanel, (Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: Hud.VBoxContainer.ColorRect
    /// </summary>
    public class ColorRect : UiNode<HudPanel, Godot.ColorRect, ColorRect>
    {
        public ColorRect(HudPanel uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override ColorRect Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: Hud.VBoxContainer.HSplitContainer.VSplitContainer.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<HudPanel, Godot.PanelContainer, PanelContainer>
    {
        public PanelContainer(HudPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: Hud.VBoxContainer.HSplitContainer.VSplitContainer.PanelContainer2
    /// </summary>
    public class PanelContainer2 : UiNode<HudPanel, Godot.PanelContainer, PanelContainer2>
    {
        public PanelContainer2(HudPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer2 Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VSplitContainer"/>, 路径: Hud.VBoxContainer.HSplitContainer.VSplitContainer
    /// </summary>
    public class VSplitContainer : UiNode<HudPanel, Godot.VSplitContainer, VSplitContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Hud.VBoxContainer.HSplitContainer.PanelContainer
        /// </summary>
        public PanelContainer L_PanelContainer
        {
            get
            {
                if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer(UiPanel, Instance.GetNode<Godot.PanelContainer>("PanelContainer"));
                return _L_PanelContainer;
            }
        }
        private PanelContainer _L_PanelContainer;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Hud.VBoxContainer.HSplitContainer.PanelContainer2
        /// </summary>
        public PanelContainer2 L_PanelContainer2
        {
            get
            {
                if (_L_PanelContainer2 == null) _L_PanelContainer2 = new PanelContainer2(UiPanel, Instance.GetNode<Godot.PanelContainer>("PanelContainer2"));
                return _L_PanelContainer2;
            }
        }
        private PanelContainer2 _L_PanelContainer2;

        public VSplitContainer(HudPanel uiPanel, Godot.VSplitContainer node) : base(uiPanel, node) {  }
        public override VSplitContainer Clone() => new (UiPanel, (Godot.VSplitContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: Hud.VBoxContainer.HSplitContainer.Control
    /// </summary>
    public class Control : UiNode<HudPanel, Godot.Control, Control>
    {
        public Control(HudPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HSplitContainer"/>, 路径: Hud.VBoxContainer.HSplitContainer
    /// </summary>
    public class HSplitContainer : UiNode<HudPanel, Godot.HSplitContainer, HSplitContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VSplitContainer"/>, 节点路径: Hud.VBoxContainer.VSplitContainer
        /// </summary>
        public VSplitContainer L_VSplitContainer
        {
            get
            {
                if (_L_VSplitContainer == null) _L_VSplitContainer = new VSplitContainer(UiPanel, Instance.GetNode<Godot.VSplitContainer>("VSplitContainer"));
                return _L_VSplitContainer;
            }
        }
        private VSplitContainer _L_VSplitContainer;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: Hud.VBoxContainer.Control
        /// </summary>
        public Control L_Control
        {
            get
            {
                if (_L_Control == null) _L_Control = new Control(UiPanel, Instance.GetNode<Godot.Control>("Control"));
                return _L_Control;
            }
        }
        private Control _L_Control;

        public HSplitContainer(HudPanel uiPanel, Godot.HSplitContainer node) : base(uiPanel, node) {  }
        public override HSplitContainer Clone() => new (UiPanel, (Godot.HSplitContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: Hud.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<HudPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel"/>, 节点路径: Hud.UiShellHeader
        /// </summary>
        public UiShellHeader L_UiShellHeader
        {
            get
            {
                if (_L_UiShellHeader == null) _L_UiShellHeader = new UiShellHeader(UiPanel, Instance.GetNode<Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel>("UiShellHeader"));
                return _L_UiShellHeader;
            }
        }
        private UiShellHeader _L_UiShellHeader;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: Hud.ColorRect
        /// </summary>
        public ColorRect L_ColorRect
        {
            get
            {
                if (_L_ColorRect == null) _L_ColorRect = new ColorRect(UiPanel, Instance.GetNode<Godot.ColorRect>("ColorRect"));
                return _L_ColorRect;
            }
        }
        private ColorRect _L_ColorRect;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HSplitContainer"/>, 节点路径: Hud.HSplitContainer
        /// </summary>
        public HSplitContainer L_HSplitContainer
        {
            get
            {
                if (_L_HSplitContainer == null) _L_HSplitContainer = new HSplitContainer(UiPanel, Instance.GetNode<Godot.HSplitContainer>("HSplitContainer"));
                return _L_HSplitContainer;
            }
        }
        private HSplitContainer _L_HSplitContainer;

        public VBoxContainer(HudPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.UiShellHeader.UiShellHeaderPanel"/>, 节点路径: Hud.VBoxContainer.UiShellHeader
    /// </summary>
    public UiShellHeader S_UiShellHeader => L_VBoxContainer.L_UiShellHeader;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: Hud.VBoxContainer.ColorRect
    /// </summary>
    public ColorRect S_ColorRect => L_VBoxContainer.L_ColorRect;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Hud.VBoxContainer.HSplitContainer.VSplitContainer.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_VBoxContainer.L_HSplitContainer.L_VSplitContainer.L_PanelContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Hud.VBoxContainer.HSplitContainer.VSplitContainer.PanelContainer2
    /// </summary>
    public PanelContainer2 S_PanelContainer2 => L_VBoxContainer.L_HSplitContainer.L_VSplitContainer.L_PanelContainer2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VSplitContainer"/>, 节点路径: Hud.VBoxContainer.HSplitContainer.VSplitContainer
    /// </summary>
    public VSplitContainer S_VSplitContainer => L_VBoxContainer.L_HSplitContainer.L_VSplitContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: Hud.VBoxContainer.HSplitContainer.Control
    /// </summary>
    public Control S_Control => L_VBoxContainer.L_HSplitContainer.L_Control;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HSplitContainer"/>, 节点路径: Hud.VBoxContainer.HSplitContainer
    /// </summary>
    public HSplitContainer S_HSplitContainer => L_VBoxContainer.L_HSplitContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: Hud.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_VBoxContainer;

}
