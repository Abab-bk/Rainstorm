using Godot;

namespace Game.Scripts.Prefabs;

[GlobalClass]
public partial class ZoomCamera : Camera2D
{
    public Vector2 ZoomFactor = new (0.5f, 0.5f);
    
    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventMouseMotion motion && motion.ButtonMask == MouseButtonMask.Middle)
        {
            Position -= motion.Relative * GetZoom();
        }

        if (@event.IsActionPressed("ZoomUp"))
        {
            SetZoom((GetZoom() + ZoomFactor).LimitLength(3f));
        }

        if (@event.IsActionPressed("ZoomDown"))
        {
            var zoom = GetZoom() - ZoomFactor;

            if (zoom.X <= 0.1f)
            {
                zoom = new Vector2(0.3f, 0.3f);
            }
            
            SetZoom(zoom);
        }
    }
}