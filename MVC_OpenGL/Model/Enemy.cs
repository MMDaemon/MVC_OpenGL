using OpenTK;

namespace MVC_OpenGL.Model
{
    class Enemy : IEntity
    {
        public int Id { get; }
        public Vector2 Position { get; set; }
        public Vector2 Size { get; set; }
        public Enemy(Vector2 position, Vector2 size)
        {
            Id = 2;
            Position = position;
            Size = size;
        }
    }
}
