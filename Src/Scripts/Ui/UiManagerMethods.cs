namespace DsUi;

// 该类为自动生成的, 请不要手动编辑, 以免造成代码丢失
public static partial class UiManager
{

    public static class UiName
    {
        public const string Hud = "Hud";
        public const string Modal = "Modal";
        public const string NewProjectPopup = "NewProjectPopup";
        public const string TextInputFluid = "TextInputFluid";
        public const string WelcomeUi = "WelcomeUi";
    }

    /// <summary>
    /// 创建 Hud, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.Hud.HudPanel Create_Hud()
    {
        return CreateUi<Game.Scripts.Ui.Hud.HudPanel>(UiName.Hud);
    }

    /// <summary>
    /// 打开 Hud, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.Hud.HudPanel Open_Hud()
    {
        return OpenUi<Game.Scripts.Ui.Hud.HudPanel>(UiName.Hud);
    }

    /// <summary>
    /// 隐藏 Hud 的所有实例
    /// </summary>
    public static void Hide_Hud()
    {
        var uiInstance = Get_Hud_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Hud 的所有实例
    /// </summary>
    public static void Destroy_Hud()
    {
        var uiInstance = Get_Hud_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Hud 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.Hud.HudPanel[] Get_Hud_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.Hud.HudPanel>(nameof(Game.Scripts.Ui.Hud.Hud));
    }

    /// <summary>
    /// 创建 Modal, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.Modal.ModalPanel Create_Modal()
    {
        return CreateUi<Game.Scripts.Ui.Modal.ModalPanel>(UiName.Modal);
    }

    /// <summary>
    /// 打开 Modal, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.Modal.ModalPanel Open_Modal()
    {
        return OpenUi<Game.Scripts.Ui.Modal.ModalPanel>(UiName.Modal);
    }

    /// <summary>
    /// 隐藏 Modal 的所有实例
    /// </summary>
    public static void Hide_Modal()
    {
        var uiInstance = Get_Modal_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Modal 的所有实例
    /// </summary>
    public static void Destroy_Modal()
    {
        var uiInstance = Get_Modal_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Modal 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.Modal.ModalPanel[] Get_Modal_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.Modal.ModalPanel>(nameof(Game.Scripts.Ui.Modal.Modal));
    }

    /// <summary>
    /// 创建 NewProjectPopup, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel Create_NewProjectPopup()
    {
        return CreateUi<Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel>(UiName.NewProjectPopup);
    }

    /// <summary>
    /// 打开 NewProjectPopup, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel Open_NewProjectPopup()
    {
        return OpenUi<Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel>(UiName.NewProjectPopup);
    }

    /// <summary>
    /// 隐藏 NewProjectPopup 的所有实例
    /// </summary>
    public static void Hide_NewProjectPopup()
    {
        var uiInstance = Get_NewProjectPopup_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 NewProjectPopup 的所有实例
    /// </summary>
    public static void Destroy_NewProjectPopup()
    {
        var uiInstance = Get_NewProjectPopup_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 NewProjectPopup 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel[] Get_NewProjectPopup_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.NewProjectPopup.NewProjectPopupPanel>(nameof(Game.Scripts.Ui.NewProjectPopup.NewProjectPopup));
    }

    /// <summary>
    /// 创建 TextInputFluid, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel Create_TextInputFluid()
    {
        return CreateUi<Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel>(UiName.TextInputFluid);
    }

    /// <summary>
    /// 打开 TextInputFluid, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel Open_TextInputFluid()
    {
        return OpenUi<Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel>(UiName.TextInputFluid);
    }

    /// <summary>
    /// 隐藏 TextInputFluid 的所有实例
    /// </summary>
    public static void Hide_TextInputFluid()
    {
        var uiInstance = Get_TextInputFluid_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 TextInputFluid 的所有实例
    /// </summary>
    public static void Destroy_TextInputFluid()
    {
        var uiInstance = Get_TextInputFluid_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 TextInputFluid 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel[] Get_TextInputFluid_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.TextInputFluid.TextInputFluidPanel>(nameof(Game.Scripts.Ui.TextInputFluid.TextInputFluid));
    }

    /// <summary>
    /// 创建 WelcomeUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel Create_WelcomeUi()
    {
        return CreateUi<Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel>(UiName.WelcomeUi);
    }

    /// <summary>
    /// 打开 WelcomeUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel Open_WelcomeUi()
    {
        return OpenUi<Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel>(UiName.WelcomeUi);
    }

    /// <summary>
    /// 隐藏 WelcomeUi 的所有实例
    /// </summary>
    public static void Hide_WelcomeUi()
    {
        var uiInstance = Get_WelcomeUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 WelcomeUi 的所有实例
    /// </summary>
    public static void Destroy_WelcomeUi()
    {
        var uiInstance = Get_WelcomeUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 WelcomeUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel[] Get_WelcomeUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.WelcomeUi.WelcomeUiPanel>(nameof(Game.Scripts.Ui.WelcomeUi.WelcomeUi));
    }

}
