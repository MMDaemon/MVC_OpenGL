using System.Collections.Generic;
using System.Linq;
using OpenTK;

namespace MVC_OpenGL.Model
{
    class Player : IEntity
    {
        private float _speed = 1.0f;

        public int Id { get; }
        public Vector2 Position { get; set; }
        public Vector2 Size { get; set; }

        public Player(Vector2 position, Vector2 size)
        {
            Id = 1;
            Position = position;
            Size = size;
        }

        public void Update(IEnumerable<Actions> actions, float deltaTime)
        {
            Vector2 direction = Vector2.Zero;

            if (actions.Contains(Actions.Up))
            {
                direction.Y += 1;
            }
            if (actions.Contains(Actions.Down))
            {
                direction.Y -= 1;
            }
            if (actions.Contains(Actions.Right))
            {
                direction.X += 1;
            }
            if (actions.Contains(Actions.Left))
            {
                direction.X -= 1;
            }

            if (direction != Vector2.Zero)
            {
                Position += direction.Normalized() * _speed * deltaTime;
            }
        }
    }
}
