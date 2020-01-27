using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenBackSdk;
using OpenBackSdk.Interfaces;
using Xamarin.Forms;

namespace XamarinSampleApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        uint logStep = 1;
        double logValue = 1.0;

        public MainPage()
        {
            InitializeComponent();
            UpdateLogButtonText();
            string sdkVersion = OpenBack.Instance.SdkVersion;
            sdkLabel.Text = $"OpenBack SDK {sdkVersion}";
        }

        private void UpdateLogButtonText()
        {
            logButton.Text = $"Log goal 'test' with step {logStep} and value {logValue}";
        }

        private void SetCustom1_Clicked(object sender, EventArgs e)
        {
            OpenBack openBack = OpenBack.Instance;
            openBack.SetCustomTrigger(CustomTrigger.CustomTrigger1, "Bob");
        }

        private void SetCustom2_Clicked(object sender, EventArgs e)
        {
            OpenBack openBack = OpenBack.Instance;
            openBack.SetCustomTrigger(CustomTrigger.CustomTrigger2, 42);
        }

        private void SetCustom3_Clicked(object sender, EventArgs e)
        {
            OpenBack openBack = OpenBack.Instance;
            openBack.SetCustomTrigger(CustomTrigger.CustomTrigger3, 1.13);
        }

        private void LogGoal_Clicked(object sender, EventArgs e)
        {
            logStep += 1;
            logValue += 3.1;
            UpdateLogButtonText();
            OpenBack openBack = OpenBack.Instance;
            openBack.LogGoal("test", logStep, logValue);
        }

        private void SaveUserInfo_Clicked(object sender, EventArgs e)
        {
            string first = firstname.Text;
            string last = lastname.Text;
            OpenBack openBack = OpenBack.Instance;
            openBack.UserInfo = new System.Collections.Generic.Dictionary<string, string>
            {
                { "firstName", first },
                { "lastName", last }
            };
        }
    }
}
