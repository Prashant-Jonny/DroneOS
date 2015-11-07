using System;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using System.Windows.Forms;

namespace DroneOSClient
{
    public partial class CameraFeed : Form
    {
        public CameraFeed()
        {
            //InitializeComponent();
        }

        private void btnHide(object sender, EventArgs e)
        {
            this.Close();
        }

        private Capture capture;  //takes images from camera as image frames
        private bool captureInProgress;

        /*private void ProcessFrame(object sender, EventArgs arg)
        {
            Mat ImageFrame = capture.QueryFrame();  //line 1
            feedRaw1.Image = ImageFrame.ToImage<>;  //line 2
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }

            if (capture != null)
            {
                if (captureInProgress)
                    Application.Idle -= ProcessFrame;
                else
                    Application.Idle += ProcessFrame;
                captureInProgress = !captureInProgress;
            }
        }*/
    }
}