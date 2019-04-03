using System.Collections.Generic;
using MVC_OpenGL.Model;
using OpenTK;
using OpenTK.Input;

namespace MVC_OpenGL.Controller
{
    class KeyboardState
    {
        private List<Actions> _actions;

        public IEnumerable<Actions> Actions => _actions;

        public KeyboardState(INativeWindow window)
        {
            _actions = new List<Actions>();

            window.KeyDown += Window_KeyDown;
            window.KeyUp += Window_KeyUp;
        }

        private void Window_KeyDown(object sender, OpenTK.Input.KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.W || e.Key == Key.Up)
            {
                _actions.Add(Model.Actions.Up);
            }
            if (e.Key == Key.S || e.Key == Key.Down)
            {
                _actions.Add(Model.Actions.Down);
            }
            if (e.Key == Key.A || e.Key == Key.Left)
            {
                _actions.Add(Model.Actions.Left);
            }
            if (e.Key == Key.D || e.Key == Key.Right)
            {
                _actions.Add(Model.Actions.Right);
            }
        }

        private void Window_KeyUp(object sender, OpenTK.Input.KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.W || e.Key == Key.Up)
            {
                _actions.Remove(Model.Actions.Up);
            }
            if (e.Key == Key.S || e.Key == Key.Down)
            {
                _actions.Remove(Model.Actions.Down);
            }
            if (e.Key == Key.A || e.Key == Key.Left)
            {
                _actions.Remove(Model.Actions.Left);
            }
            if (e.Key == Key.D || e.Key == Key.Right)
            {
                _actions.Remove(Model.Actions.Right);
            }
        }
    }
}
