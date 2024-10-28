namespace Rainstorm.Core;

public abstract class Scene
{
    public virtual void Update() { }
    public virtual void Draw() { }
    public virtual void OnEnter() { }
    public virtual void OnExit() { }
}