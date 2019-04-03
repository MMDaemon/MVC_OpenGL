using OpenTK;

namespace MVC_OpenGL.Model
{
    interface IEntity
    {
        int Id { get; }
        Vector2 Position { get; }
        Vector2 Size { get; }
    }
}
