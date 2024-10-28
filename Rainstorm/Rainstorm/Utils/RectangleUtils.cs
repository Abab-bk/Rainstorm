using Raylib_CsLo;

namespace Rainstorm.Utils;

public static class RectangleUtils
{
    public static Rectangle GetCenteredRectangle(float width, float height)
    {
        return new Rectangle(
            Raylib.GetScreenWidth() / 2f - width / 2f,
            Raylib.GetScreenHeight() / 2f - height / 2f,
            width, height
        );
    }
}