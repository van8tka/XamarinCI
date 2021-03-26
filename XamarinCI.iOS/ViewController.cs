using Foundation;
using System;
using UIKit;
using XamarinCI.Shared;

namespace XamarinCI.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            btn.TouchUpInside += Btn_TouchUpInside;
        }

        private int i = 0;

        private void Btn_TouchUpInside(object sender, EventArgs e)
        {
            var calc = new CalculatorModel(new Model { X = i, Y = i });
            tv.Text = $"Result: {calc.Calculate()}";
            i++;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}