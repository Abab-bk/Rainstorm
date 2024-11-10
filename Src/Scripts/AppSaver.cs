using System;
using System.IO;
using Game.Scripts.Configs;
using Tomlyn;

namespace Game.Scripts;

public static class AppSaver
{
    static AppSaver()
    {
        EventBus.EnterProject += project =>
        {
            Global.AppConfig.RecentProjects.Add(
                new ProjectItem
                {
                    Name = project.Name,
                    Path = project.Path
                }
                );
            Save();
            EventBus.RecentProjectsChanged?.Invoke(Global.AppConfig.RecentProjects);
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
                EventBus.RecentProjectsChanged?.Invoke(Global.AppConfig.RecentProjects);
                return;
            }

            Logger.Log("[AppLoader]: No app config file found, create a new one. Location: ", projectFilePath);
            Global.AppConfig = new AppConfig();
            File.Create(projectFilePath).Close();
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
            if (!File.Exists(projectFilePath))
            {
                File.Create(projectFilePath).Close();
            }

            var writer = new StreamWriter(projectFilePath);
            writer.Write(Toml.FromModel(Global.AppConfig));
            writer.Close();
            
            Logger.Log("[AppSaver]: Config saved. Location: ", projectFilePath);;
        }
        catch (Exception e)
        {
            Logger.Log($"[AppSaver ERROR]: {e}");
            throw;
        }
    }
}