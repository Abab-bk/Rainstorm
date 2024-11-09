namespace DsUi;

// 该类为自动生成的, 请不要手动编辑, 以免造成代码丢失
public static partial class UiManager
{

    public static class UiName
    {
        public const string NewProjectPopup = "NewProjectPopup";
        public const string WelcomeUi = "WelcomeUi";
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
