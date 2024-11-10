namespace Game.Scripts.Ui.Modal;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Modal : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: Modal.ColorRect
    /// </summary>
    public ColorRect L_ColorRect
    {
        get
        {
            if (_L_ColorRect == null) _L_ColorRect = new ColorRect((ModalPanel)this, GetNode<Godot.ColorRect>("ColorRect"));
            return _L_ColorRect;
        }
    }
    private ColorRect _L_ColorRect;

    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Modal.PanelContainer
    /// </summary>
    public PanelContainer L_PanelContainer
    {
        get
        {
            if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer((ModalPanel)this, GetNode<Godot.PanelContainer>("PanelContainer"));
            return _L_PanelContainer;
        }
    }
    private PanelContainer _L_PanelContainer;


    public Modal() : base(nameof(Modal))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: Modal.ColorRect
    /// </summary>
    public class ColorRect : UiNode<ModalPanel, Godot.ColorRect, ColorRect>
    {
        public ColorRect(ModalPanel uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override ColorRect Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer.VBoxContainer.OptionalLabel
    /// </summary>
    public class OptionalLabel : UiNode<ModalPanel, Godot.Label, OptionalLabel>
    {
        public OptionalLabel(ModalPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override OptionalLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer.VBoxContainer.TitleLabel
    /// </summary>
    public class TitleLabel : UiNode<ModalPanel, Godot.Label, TitleLabel>
    {
        public TitleLabel(ModalPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override TitleLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer_1 : UiNode<ModalPanel, Godot.VBoxContainer, VBoxContainer_1>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer.OptionalLabel
        /// </summary>
        public OptionalLabel L_OptionalLabel
        {
            get
            {
                if (_L_OptionalLabel == null) _L_OptionalLabel = new OptionalLabel(UiPanel, Instance.GetNode<Godot.Label>("OptionalLabel"));
                return _L_OptionalLabel;
            }
        }
        private OptionalLabel _L_OptionalLabel;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer.TitleLabel
        /// </summary>
        public TitleLabel L_TitleLabel
        {
            get
            {
                if (_L_TitleLabel == null) _L_TitleLabel = new TitleLabel(UiPanel, Instance.GetNode<Godot.Label>("TitleLabel"));
                return _L_TitleLabel;
            }
        }
        private TitleLabel _L_TitleLabel;

        public VBoxContainer_1(ModalPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_1 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureButton"/>, 路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer.CloseBtn
    /// </summary>
    public class CloseBtn : UiNode<ModalPanel, Godot.TextureButton, CloseBtn>
    {
        public CloseBtn(ModalPanel uiPanel, Godot.TextureButton node) : base(uiPanel, node) {  }
        public override CloseBtn Clone() => new (UiPanel, (Godot.TextureButton)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<ModalPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Title.VBoxContainer
        /// </summary>
        public VBoxContainer_1 L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer_1(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer_1 _L_VBoxContainer;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Title.CloseBtn
        /// </summary>
        public CloseBtn L_CloseBtn
        {
            get
            {
                if (_L_CloseBtn == null) _L_CloseBtn = new CloseBtn(UiPanel, Instance.GetNode<Godot.TextureButton>("CloseBtn"));
                return _L_CloseBtn;
            }
        }
        private CloseBtn _L_CloseBtn;

        public HBoxContainer(ModalPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: Modal.PanelContainer.VBoxContainer.Title
    /// </summary>
    public class Title : UiNode<ModalPanel, Godot.MarginContainer, Title>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: Modal.PanelContainer.VBoxContainer.HBoxContainer
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

        public Title(ModalPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override Title Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: Modal.PanelContainer.VBoxContainer.Content.ContentText
    /// </summary>
    public class ContentText : UiNode<ModalPanel, Godot.Label, ContentText>
    {
        public ContentText(ModalPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override ContentText Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.MarginContainer"/>, 路径: Modal.PanelContainer.VBoxContainer.Content
    /// </summary>
    public class Content : UiNode<ModalPanel, Godot.MarginContainer, Content>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: Modal.PanelContainer.VBoxContainer.ContentText
        /// </summary>
        public ContentText L_ContentText
        {
            get
            {
                if (_L_ContentText == null) _L_ContentText = new ContentText(UiPanel, Instance.GetNode<Godot.Label>("ContentText"));
                return _L_ContentText;
            }
        }
        private ContentText _L_ContentText;

        public Content(ModalPanel uiPanel, Godot.MarginContainer node) : base(uiPanel, node) {  }
        public override Content Clone() => new (UiPanel, (Godot.MarginContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: Modal.PanelContainer.VBoxContainer.Buttons.CancelBtn
    /// </summary>
    public class CancelBtn : UiNode<ModalPanel, Godot.Button, CancelBtn>
    {
        public CancelBtn(ModalPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override CancelBtn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: Modal.PanelContainer.VBoxContainer.Buttons.Action3Btn
    /// </summary>
    public class Action3Btn : UiNode<ModalPanel, Godot.Button, Action3Btn>
    {
        public Action3Btn(ModalPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Action3Btn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: Modal.PanelContainer.VBoxContainer.Buttons.Action2Btn
    /// </summary>
    public class Action2Btn : UiNode<ModalPanel, Godot.Button, Action2Btn>
    {
        public Action2Btn(ModalPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Action2Btn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: Modal.PanelContainer.VBoxContainer.Buttons.Action1Btn
    /// </summary>
    public class Action1Btn : UiNode<ModalPanel, Godot.Button, Action1Btn>
    {
        public Action1Btn(ModalPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Action1Btn Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: Modal.PanelContainer.VBoxContainer.Buttons
    /// </summary>
    public class Buttons : UiNode<ModalPanel, Godot.HBoxContainer, Buttons>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: Modal.PanelContainer.VBoxContainer.CancelBtn
        /// </summary>
        public CancelBtn L_CancelBtn
        {
            get
            {
                if (_L_CancelBtn == null) _L_CancelBtn = new CancelBtn(UiPanel, Instance.GetNode<Godot.Button>("CancelBtn"));
                return _L_CancelBtn;
            }
        }
        private CancelBtn _L_CancelBtn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Action3Btn
        /// </summary>
        public Action3Btn L_Action3Btn
        {
            get
            {
                if (_L_Action3Btn == null) _L_Action3Btn = new Action3Btn(UiPanel, Instance.GetNode<Godot.Button>("Action3Btn"));
                return _L_Action3Btn;
            }
        }
        private Action3Btn _L_Action3Btn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Action2Btn
        /// </summary>
        public Action2Btn L_Action2Btn
        {
            get
            {
                if (_L_Action2Btn == null) _L_Action2Btn = new Action2Btn(UiPanel, Instance.GetNode<Godot.Button>("Action2Btn"));
                return _L_Action2Btn;
            }
        }
        private Action2Btn _L_Action2Btn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Action1Btn
        /// </summary>
        public Action1Btn L_Action1Btn
        {
            get
            {
                if (_L_Action1Btn == null) _L_Action1Btn = new Action1Btn(UiPanel, Instance.GetNode<Godot.Button>("Action1Btn"));
                return _L_Action1Btn;
            }
        }
        private Action1Btn _L_Action1Btn;

        public Buttons(ModalPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override Buttons Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: Modal.PanelContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<ModalPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: Modal.PanelContainer.Title
        /// </summary>
        public Title L_Title
        {
            get
            {
                if (_L_Title == null) _L_Title = new Title(UiPanel, Instance.GetNode<Godot.MarginContainer>("Title"));
                return _L_Title;
            }
        }
        private Title _L_Title;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: Modal.PanelContainer.Content
        /// </summary>
        public Content L_Content
        {
            get
            {
                if (_L_Content == null) _L_Content = new Content(UiPanel, Instance.GetNode<Godot.MarginContainer>("Content"));
                return _L_Content;
            }
        }
        private Content _L_Content;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: Modal.PanelContainer.Buttons
        /// </summary>
        public Buttons L_Buttons
        {
            get
            {
                if (_L_Buttons == null) _L_Buttons = new Buttons(UiPanel, Instance.GetNode<Godot.HBoxContainer>("Buttons"));
                return _L_Buttons;
            }
        }
        private Buttons _L_Buttons;

        public VBoxContainer(ModalPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: Modal.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<ModalPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: Modal.VBoxContainer
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

        public PanelContainer(ModalPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: Modal.ColorRect
    /// </summary>
    public ColorRect S_ColorRect => L_ColorRect;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer.VBoxContainer.OptionalLabel
    /// </summary>
    public OptionalLabel S_OptionalLabel => L_PanelContainer.L_VBoxContainer.L_Title.L_HBoxContainer.L_VBoxContainer.L_OptionalLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer.VBoxContainer.TitleLabel
    /// </summary>
    public TitleLabel S_TitleLabel => L_PanelContainer.L_VBoxContainer.L_Title.L_HBoxContainer.L_VBoxContainer.L_TitleLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer.CloseBtn
    /// </summary>
    public CloseBtn S_CloseBtn => L_PanelContainer.L_VBoxContainer.L_Title.L_HBoxContainer.L_CloseBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Title.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_PanelContainer.L_VBoxContainer.L_Title.L_HBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Title
    /// </summary>
    public Title S_Title => L_PanelContainer.L_VBoxContainer.L_Title;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Content.ContentText
    /// </summary>
    public ContentText S_ContentText => L_PanelContainer.L_VBoxContainer.L_Content.L_ContentText;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.MarginContainer"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Content
    /// </summary>
    public Content S_Content => L_PanelContainer.L_VBoxContainer.L_Content;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Buttons.CancelBtn
    /// </summary>
    public CancelBtn S_CancelBtn => L_PanelContainer.L_VBoxContainer.L_Buttons.L_CancelBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Buttons.Action3Btn
    /// </summary>
    public Action3Btn S_Action3Btn => L_PanelContainer.L_VBoxContainer.L_Buttons.L_Action3Btn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Buttons.Action2Btn
    /// </summary>
    public Action2Btn S_Action2Btn => L_PanelContainer.L_VBoxContainer.L_Buttons.L_Action2Btn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Buttons.Action1Btn
    /// </summary>
    public Action1Btn S_Action1Btn => L_PanelContainer.L_VBoxContainer.L_Buttons.L_Action1Btn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: Modal.PanelContainer.VBoxContainer.Buttons
    /// </summary>
    public Buttons S_Buttons => L_PanelContainer.L_VBoxContainer.L_Buttons;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: Modal.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_PanelContainer;

}
