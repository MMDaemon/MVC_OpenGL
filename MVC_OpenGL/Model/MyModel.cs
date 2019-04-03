using System.Collections.Generic;
using OpenTK;

namespace MVC_OpenGL.Model
{
    class MyModel
    {
        readonly List<IEntity> _entities;

        public IEnumerable<IEntity> Entities => _entities;

        public MyModel()
        {
            _entities = new List<IEntity>();
            _entities.Add(new Player(Vector2.Zero, new Vector2(0.2f)));
            _entities.Add(new Enemy(new Vector2(-0.2f), new Vector2(-0.2f)));
            _entities.Add(new Enemy(new Vector2(-0.4f), new Vector2(-0.2f)));
        }

        public void Update(IEnumerable<Actions> actions, float deltaTime)
        {
            foreach (var entity in _entities)
            {
                if (entity is Player)
                {
                    ((Player)entity).Update(actions, deltaTime);
                }
                if (entity is Enemy)
                {
                    ((Enemy)entity).Position += Vector2.UnitX * deltaTime;
                    if (entity.Position.X > 1)
                    {
                        ((Enemy)entity).Position = new Vector2(-1f, ((Enemy)entity).Position.Y);
                    }
                }
            }
        }
    }
}
