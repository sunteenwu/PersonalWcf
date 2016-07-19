using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel;
using UWPClient.ServiceReference1;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace UWPClient
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            var binding = new NetTcpBinding(SecurityMode.Transport);
            binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
          var  client = new GetIdentityClient(binding, new EndpointAddress(new Uri("net.tcp://localhost:8056/WCFService/GetIdentity")));   
            //client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = System.ServiceModel.Security.X509CertificateValidationMode.None;
            string result = await client.GetAsync("my computer test");
            await new Windows.UI.Popups.MessageDialog(result).ShowAsync();       

        }
    }
}
