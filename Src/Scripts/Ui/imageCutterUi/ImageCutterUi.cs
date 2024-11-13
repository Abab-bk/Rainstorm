namespace Game.Scripts.Ui.ImageCutterUi;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class ImageCutterUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SubViewportContainer"/>, 节点路径: ImageCutterUi.SubViewportContainer
    /// </summary>
    public SubViewportContainer L_SubViewportContainer
    {
        get
        {
            if (_L_SubViewportContainer == null) _L_SubViewportContainer = new SubViewportContainer((ImageCutterUiPanel)this, GetNode<Godot.SubViewportContainer>("SubViewportContainer"));
            return _L_SubViewportContainer;
        }
    }
    private SubViewportContainer _L_SubViewportContainer;


    public ImageCutterUi() : base(nameof(ImageCutterUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.Sprite2D"/>, 路径: ImageCutterUi.SubViewportContainer.SubViewport.Node2D.Sprite2D
    /// </summary>
    public class Sprite2D : UiNode<ImageCutterUiPanel, Godot.Sprite2D, Sprite2D>
    {
        public Sprite2D(ImageCutterUiPanel uiPanel, Godot.Sprite2D node) : base(uiPanel, node) {  }
        public override Sprite2D Clone() => new (UiPanel, (Godot.Sprite2D)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Node2D"/>, 路径: ImageCutterUi.SubViewportContainer.SubViewport.Node2D
    /// </summary>
    public class Node2D : UiNode<ImageCutterUiPanel, Godot.Node2D, Node2D>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Sprite2D"/>, 节点路径: ImageCutterUi.SubViewportContainer.SubViewport.Sprite2D
        /// </summary>
        public Sprite2D L_Sprite2D
        {
            get
            {
                if (_L_Sprite2D == null) _L_Sprite2D = new Sprite2D(UiPanel, Instance.GetNode<Godot.Sprite2D>("Sprite2D"));
                return _L_Sprite2D;
            }
        }
        private Sprite2D _L_Sprite2D;

        public Node2D(ImageCutterUiPanel uiPanel, Godot.Node2D node) : base(uiPanel, node) {  }
        public override Node2D Clone() => new (UiPanel, (Godot.Node2D)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SubViewport"/>, 路径: ImageCutterUi.SubViewportContainer.SubViewport
    /// </summary>
    public class SubViewport : UiNode<ImageCutterUiPanel, Godot.SubViewport, SubViewport>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Node2D"/>, 节点路径: ImageCutterUi.SubViewportContainer.Node2D
        /// </summary>
        public Node2D L_Node2D
        {
            get
            {
                if (_L_Node2D == null) _L_Node2D = new Node2D(UiPanel, Instance.GetNode<Godot.Node2D>("Node2D"));
                return _L_Node2D;
            }
        }
        private Node2D _L_Node2D;

        public SubViewport(ImageCutterUiPanel uiPanel, Godot.SubViewport node) : base(uiPanel, node) {  }
        public override SubViewport Clone() => new (UiPanel, (Godot.SubViewport)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: ImageCutterUi.SubViewportContainer.HBoxContainer.AutoSliceBtn
    /// </summary>
    public class AutoSliceBtn : UiNode<ImageCutterUiPanel, Godot.Button, AutoSliceBtn>
    {
        public AutoSliceBtn(ImageCutterUiPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override AutoSliceBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: ImageCutterUi.SubViewportContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<ImageCutterUiPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: ImageCutterUi.SubViewportContainer.AutoSliceBtn
        /// </summary>
        public AutoSliceBtn L_AutoSliceBtn
        {
            get
            {
                if (_L_AutoSliceBtn == null) _L_AutoSliceBtn = new AutoSliceBtn(UiPanel, Instance.GetNode<Godot.Button>("AutoSliceBtn"));
                return _L_AutoSliceBtn;
            }
        }
        private AutoSliceBtn _L_AutoSliceBtn;

        public HBoxContainer(ImageCutterUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.SubViewportContainer"/>, 路径: ImageCutterUi.SubViewportContainer
    /// </summary>
    public class SubViewportContainer : UiNode<ImageCutterUiPanel, Godot.SubViewportContainer, SubViewportContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.SubViewport"/>, 节点路径: ImageCutterUi.SubViewport
        /// </summary>
        public SubViewport L_SubViewport
        {
            get
            {
                if (_L_SubViewport == null) _L_SubViewport = new SubViewport(UiPanel, Instance.GetNode<Godot.SubViewport>("SubViewport"));
                return _L_SubViewport;
            }
        }
        private SubViewport _L_SubViewport;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: ImageCutterUi.HBoxContainer
        /// </summary>
        public HBoxContainer L_HBoxContainer
        {
            get
            {
                if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer"));
                return _L_HBoxContainer;
            }
        }
        private HBoxContainer _L_HBoxContainer;

        public SubViewportContainer(ImageCutterUiPanel uiPanel, Godot.SubViewportContainer node) : base(uiPanel, node) {  }
        public override SubViewportContainer Clone() => new (UiPanel, (Godot.SubViewportContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Sprite2D"/>, 节点路径: ImageCutterUi.SubViewportContainer.SubViewport.Node2D.Sprite2D
    /// </summary>
    public Sprite2D S_Sprite2D => L_SubViewportContainer.L_SubViewport.L_Node2D.L_Sprite2D;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Node2D"/>, 节点路径: ImageCutterUi.SubViewportContainer.SubViewport.Node2D
    /// </summary>
    public Node2D S_Node2D => L_SubViewportContainer.L_SubViewport.L_Node2D;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SubViewport"/>, 节点路径: ImageCutterUi.SubViewportContainer.SubViewport
    /// </summary>
    public SubViewport S_SubViewport => L_SubViewportContainer.L_SubViewport;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: ImageCutterUi.SubViewportContainer.HBoxContainer.AutoSliceBtn
    /// </summary>
    public AutoSliceBtn S_AutoSliceBtn => L_SubViewportContainer.L_HBoxContainer.L_AutoSliceBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: ImageCutterUi.SubViewportContainer.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_SubViewportContainer.L_HBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.SubViewportContainer"/>, 节点路径: ImageCutterUi.SubViewportContainer
    /// </summary>
    public SubViewportContainer S_SubViewportContainer => L_SubViewportContainer;

}
