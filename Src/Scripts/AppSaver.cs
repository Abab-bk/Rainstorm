using System;
using System.IO;
using Game.Scripts.Configs;
using Tomlyn;

namespace Game.Scripts;

public static class AppSaver
{
    static AppSaver()
    {
        EventBus.RequestSave += Save;
        EventBus.EnterProject += project =>
        {
            Global.AppConfig.AddRecentProject(
                new ProjectItem {
                    Name = project.Name,
                    Path = project.Path
                }
                );
            Save();
        };
    }

    private static string GetConfigFilePath() => Path.Combine(Environment.CurrentDirectory, "rainstormConfig.toml");
    
    public static void Load()
    {
        var projectFilePath = GetConfigFilePath();
        try
        {
            if (File.Exists(projectFilePath))
            {
                var reader = new StreamReader(projectFilePath);
                var content = reader.ReadToEnd();
                Global.AppConfig = Toml.ToModel<AppConfig>(content);
                reader.Close();
                reader.Dispose();
                EventBus.RecentProjectsChanged?.Invoke(Global.AppConfig.RecentProjects);
                return;
            }

            Logger.Log("[AppLoader]: No app config file found.");
            Global.AppConfig = new AppConfig();
        }
        catch (Exception e)
        {
            Logger.Log($"[AppLoader ERROR]: {e}");
            throw;
        }
    }

    public static void Save()
    {
        var projectFilePath = GetConfigFilePath();
        try
        {
            File.WriteAllText(projectFilePath, Toml.FromModel(Global.AppConfig));
            Logger.Log("[AppSaver]: Config saved. Location: ", projectFilePath);;
        }
        catch (Exception e)
        {
            Logger.Log($"[AppSaver ERROR]: {e}");
            throw;
        }
    }
}