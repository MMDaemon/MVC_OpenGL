using System.Collections.Generic;
using System.Drawing;
using MVC_OpenGL.Model;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace MVC_OpenGL.View
{
    class MyView
    {
        public void Render(IEnumerable<IEntity> entities)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            foreach (var entity in entities)
            {
                RenderEntity(entity);
            }
        }

        private void RenderEntity(IEntity entity)
        {
            switch (entity.Id)
            {
                case 1:
                    GL.Color3(Color.Green);
                    break;
                case 2:
                    GL.Color3(Color.Red);
                    break;
            }

            GL.Begin(PrimitiveType.Quads);

            GL.Vertex2(entity.Position + new Vector2(-entity.Size.X / 2, -entity.Size.Y / 2));
            GL.Vertex2(entity.Position + new Vector2(entity.Size.X / 2, -entity.Size.Y / 2));
            GL.Vertex2(entity.Position + new Vector2(entity.Size.X / 2, entity.Size.Y / 2));
            GL.Vertex2(entity.Position + new Vector2(-entity.Size.X / 2, entity.Size.Y / 2));

            GL.End();
        }
    }
}
