using DsUi;
using Game.Scripts.Classes;
using Godot;
using GodotTask;

namespace Game.Scripts;

public partial class World : Node2D
{
    private StateMachine _stateMachine;
    
    public override void _Ready()
    {
        _stateMachine = new StateMachine(GetNode("StateMachinePlayer"), "WorldState");

        _stateMachine.OnTransition += OnStateMachineTransition;
        _stateMachine.OnUpdate += OnStateMachineUpdate;
        
        _stateMachine.SetTrigger("ToPreBoot");
        
        EventBus.EnterProject += project =>
        {
            var writer = new ProjectWriter(project);
            Global.ProjectWriter = writer;
            _stateMachine.SetTrigger("ToEditor");
            UiManager.Open_Hud().Config(writer);
        };
    }

    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("Save"))
        {
            EventBus.RequestSave?.Invoke();
        }
    }

    private void OnStateMachineUpdate(string state, float delta)
    {
    }

    private void OnStateMachineTransition(string from, string to)
    {
        switch (to)
        {
            case "PreBoot":
                Global.World = this;
                _stateMachine.SetTrigger("ToBooting");
                break;
            case "Booting":
                GDTask.NextFrame().ContinueWith(() =>
                {
                    _stateMachine.SetTrigger("ToInitGame");
                });
                break;
            case "InitGame":
                GDTask.NextFrame().ContinueWith(() =>
                {
                    _stateMachine.SetTrigger("ToInGame");
                });
                break;
            case "InGame":
                GDTask.NextFrame().ContinueWith(() =>
                {
                    _stateMachine.SetTrigger("ToWelcome");
                });
                break;
            case "InWelcome":
                UiManager.Open_WelcomeUi();
                // load
                AppSaver.Load();
                break;
            case "InEditor":
                UiManager.Destroy_WelcomeUi();
                
                break;
            case "End":
                break;
        }
    }
}
