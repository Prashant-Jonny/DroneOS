using DroneOSClient;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace DroneOS.Handlers
{
    public class ControllerProcessor
    {
        GamePadState gamePadState;
        public bool connected = true;//TODO: add functionality later

        //Sticks
        double leftX = 0;
        double leftY = 0;
        double rightX = 0;
        double rightY = 0;

        public void UpdateInput()
        {
            gamePadState = GamePad.GetState(PlayerIndex.One);

            if (!gamePadState.IsConnected && connected)
            {
                connected = false;//Stops from spamming messages
                println("Controller disconnected.");//TODO: stop this from spamming
                return;
            }
            else if (gamePadState.IsConnected && !connected) {
                println("Controller reconnected.");//TODO: stop this from spamming
                connected = true;//Arm the controller detector
            }

            leftX = Math.Round((double)(gamePadState.ThumbSticks.Left.X * 100.0f));
            leftY = Math.Round((double)(gamePadState.ThumbSticks.Left.Y * 100.0f));
            
            rightX = Math.Round((double)(gamePadState.ThumbSticks.Right.X * 100.0f));
            rightY = Math.Round((double)(gamePadState.ThumbSticks.Right.Y * 100.0f));

            //Thumg Sticks
            if (leftX != 0) {
                println("leftX: " + leftX);
            }
            if (leftY != 0)
                println("leftY: " + leftY);

            if (rightX != 0)
                println("rightX: " + rightX);
            if (rightY != 0)
                println("rightY: " + rightY);


            

            //Buttons
            if (gamePadState.Buttons.A == ButtonState.Pressed)
            {
                println("button A pressed");
            }

            if (gamePadState.Buttons.B == ButtonState.Pressed)
            {
                // Button B is currently being pressed;
            }

            if (gamePadState.Buttons.X == ButtonState.Pressed)
            {
                // Button C is currently being pressed;
            }

            if (gamePadState.Buttons.Y == ButtonState.Pressed)
            {
                // Button D is currently being pressed;
            }
        }

        private void println(/*enum Error = NONE,*/ String message)
        {
            mainForm._mainForm.println(message);
        }
    }
}