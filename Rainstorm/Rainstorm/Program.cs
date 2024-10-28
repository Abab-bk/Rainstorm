using Rainstorm.Core;
using Rainstorm.Scenes;
using Raylib_CsLo;

namespace Rainstorm;

public static class Program
{
    private static bool _shouldExit;
    
    public static Scene CurrentScene { get; private set; }
    
    
    public static void Main(string[] args)
    {
        Raylib.InitWindow(1280, 720, "Rainstorm");
        RayGui.GuiLoadStyleDefault();
        Raylib.SetTargetFPS(60);
        
        ChangeScene(new MainMenu());
        
        while (!Raylib.WindowShouldClose() && !_shouldExit)
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Raylib.SKYBLUE);

            if (CurrentScene != null)
            {
                CurrentScene.Update();
                CurrentScene.Draw();
            }
            
            Raylib.EndDrawing();
        }
        
        Raylib.CloseWindow();
    }
    
    public static void ChangeScene(Scene scene)
    {
        if (CurrentScene != null)
        {
            CurrentScene.OnExit();
        }

        CurrentScene = scene;
        CurrentScene.OnEnter();
    }
    
    public static void Exit()
    {
        _shouldExit = true;
    }
}