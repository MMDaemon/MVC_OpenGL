using MVC_OpenGL.Model;
using MVC_OpenGL.View;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace MVC_OpenGL.Controller
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow();
            KeyboardState keyboard = new KeyboardState(window);
            MyModel model = new MyModel();
            MyView view = new MyView();

            window.UpdateFrame += (s, e) => model.Update(keyboard.Actions, (float)e.Time);
            window.RenderFrame += (s, e) => view.Render(model.Entities);
            window.RenderFrame += (s, e) => window.SwapBuffers();
            window.Resize += (s, e) => GL.Viewport(0, 0, window.Width, window.Height);

            window.Run();
        }
    }
}
