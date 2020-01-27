using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

using OpenBackSdk;

namespace XamarinSampleApp.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            // Local OpenBack Initialization
            //SetupOpenBack();            

            return base.FinishedLaunching(app, options);
        }

        //private void SetupOpenBack()
        //{
        //    OpenBack.Instance.AppCode = "RQRDKXPGQS";            
        //    OpenBack.Instance.Start();            
        //}
    }
}
