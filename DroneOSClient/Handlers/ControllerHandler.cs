using DroneOSClient;
using DroneOSClient.NetworkEngine;
using DroneOSClient.Resources;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace DroneOSClient.Handlers
{
    public class ControllerHandler
    {
        GamePadState gamePadState;
        TcpConn con

        private bool connected = true;
        
        //Sticks, globally declares for performance.
        private double leftX = 0;
        private double leftY = 0;
        private double rightX = 0;
        private double rightY = 0;

        public ControllerHandler(TcpConn con)
        {
            ErrorLog.println(Error.Info, "(4/5) ControllerHandler Started");
            this.con = c;
        }

        public void UpdateInput()
        {
            //Get all the buttons and stick values of the controller
            gamePadState = GamePad.GetState(PlayerIndex.One);

            if (!gamePadState.IsConnected && connected)
            {
                connected = false;//Stops from spamming messages
                println("Controller disconnected.");
                return;
            }
            else if (gamePadState.IsConnected && !connected) {
                println("Controller reconnected.");
                connected = true;//Arm the controller detector after it has been reconnected
            }

            leftX = Math.Round((double)(gamePadState.ThumbSticks.Left.X * 100.0f));
            leftY = Math.Round((double)(gamePadState.ThumbSticks.Left.Y * 100.0f));
            
            rightX = Math.Round((double)(gamePadState.ThumbSticks.Right.X * 100.0f));
            rightY = Math.Round((double)(gamePadState.ThumbSticks.Right.Y * 100.0f));

            //Thumb Sticks
            /*if (leftX != 0) {
                println("leftX: " + leftX);
            }
            if (leftY != 0)
                println("leftY: " + leftY);

            if (rightX != 0)
                println("rightX: " + rightX);
            if (rightY != 0)
                println("rightY: " + rightY);*/

            try { 
            //Send to tcp
            if (leftY < -5)
                tcp.sendPacket(PacketCreator.controlPacket(ThrusterPins.left, 2, true));
            else if (leftY > 5)
                tcp.sendPacket(PacketCreator.controlPacket(ThrusterPins.left, 1));

            if (rightY < -5)
                tcp.sendPacket(PacketCreator.controlPacket(ThrusterPins.right, 2, true));
            else if (rightY > 5)
                tcp.sendPacket(PacketCreator.controlPacket(ThrusterPins.right, 2));

        
            if (gamePadState.Buttons.LeftShoulder == ButtonState.Pressed)
                tcp.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrt, 1, true));

            if (gamePadState.Buttons.RightShoulder == ButtonState.Pressed)
                tcp.sendPacket(PacketCreator.controlPacket(ThrusterPins.vrt, 1));
            } catch (NullReferenceException e){
                ErrorLog.println("tcp con failure: " + e);
            }

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
            MainForm._mainForm.println(message);
        }
    }
}