using System;
using CoreGraphics;
using UIKit;
using WhirlyGlobeMaply;

namespace WGTest
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

            var ree = new MaplyAnnotation() { MaxVis = 1 };
            var testBaseVC = new MaplyBaseViewController();
            var tt = new MaplyVectorObject() { };
            var ss = MaplyVectorObject.VectorObjectFromFile("s");
            var sss = new MaplyAnimationTestTileSource();
            var www = sss.MinZoom();
            var sss2 = new MaplyScreenMarker() { Size = new CGSize(10, 20) };
            var coord = new MaplyCoordinate();
            coord.X = 5;
            coord.Y = 111;
            //sss2.Location = coord;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
