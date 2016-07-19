using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.ServiceModel;
using System.ServiceModel.Discovery;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CWCFNew
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

     
        private async void BtnDiscover_Click(object sender, RoutedEventArgs e)
        {
            var discoveryClient = new DiscoveryClient(new UdpDiscoveryEndpoint());
            //    var findCriteria = new FindCriteria(typeof(IGetIdentity));
            //    findCriteria.Duration = TimeSpan.FromSeconds(5);
            //    var findResponse = await discoveryClient.FindTaskAsync(findCriteria);
        }
    }

    internal interface IGetIdentity
    {
    }
}
