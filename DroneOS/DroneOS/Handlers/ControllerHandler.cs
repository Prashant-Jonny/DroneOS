using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ControllerHandler
{
    public class ControllerHandler : Microsoft.Xna.Framework.Game
    {
        void UpdateInput()
        {
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);
            if (!currentState.IsConnected)
                return;
            /**
            //Buttons
            if (currentState.Buttons.A == ButtonState.Pressed)
            {
                // Button A is currently being pressed;
            }

            if (currentState.Buttons.B == ButtonState.Pressed)
            {
                // Button B is currently being pressed;
            }

            if (currentState.Buttons.X == ButtonState.Pressed)
            {
                // Button C is currently being pressed;
            }

            if (currentState.Buttons.Y == ButtonState.Pressed)
            {
                // Button D is currently being pressed;
            }

            //Triggers
            if (currentState.Triggers.Left)
            {
                // Button A is currently being pressed;
            }

            if (currentState.Buttons.A == ButtonState.Pressed)
            {
                // Button A is currently being pressed;
            } */
        }
    }
}