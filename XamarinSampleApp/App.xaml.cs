using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OpenBackSdk;

namespace XamarinSampleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SetupOpenBack();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private void SetupOpenBack()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    OpenBack.Instance.AppCode = "RQRDKXPGQS";
                    break;
                case Device.Android:
                    OpenBack.Instance.AppCode = "EHLONJGFEZ";
                    break;                
            }

            
            OpenBack.Instance.Start();
        }
    }
}
