using System.Windows;
using Caliburn.Micro;

namespace CaliburnMicroApp
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //When this boorstrapper is loaded, AppViewModel will be fired. 
            //The corresponsing view AppView willbe displayed as it is set in the App.xaml
            DisplayRootViewFor<AppViewModel>();
        }
    }
}