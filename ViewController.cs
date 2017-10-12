using System;

using UIKit;

namespace HextoRGB
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            // "Connects" code to the app
            convertButton.TouchUpInside+= ConvertButton_TouchUpInside;
        }

        // Code(aka method) for app's functions
        void ConvertButton_TouchUpInside(object sender, EventArgs e)
        {
            // Variable for the user's written input
            string hexValue = hexValueTextField.Text;
            // Variable for the first two numbers and/or letters
            string redHexValue = hexValue.Substring(0, 2);
            // Variable for the following two numbers and/or letters
            string greenHexValue = hexValue.Substring(2, 2);
            // Variable for the last two numbers and/or letters
            string blueHexValue = hexValue.Substring(4, 2);

            // Converts the hex values to their RGB counterparts
            int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
            int greenValue = int.Parse(greenHexValue, System.Globalization.NumberStyles.HexNumber);
            int blueValue = int.Parse(blueHexValue, System.Globalization.NumberStyles.HexNumber);

            // Displays the converted RGB values onto their respective text areas in the app
            redValueLabel.Text = redValue.ToString();
            greenValueLabel.Text = greenValue.ToString();
            blueValueLabel.Text = blueValue.ToString();

            // Invisible area that changes colour depending on the colour value found
            colorView.BackgroundColor = UIColor.FromRGB(redValue, greenValue, blueValue);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
