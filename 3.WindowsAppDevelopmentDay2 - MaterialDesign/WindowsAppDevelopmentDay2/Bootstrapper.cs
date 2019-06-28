using Caliburn.Micro;
using System.Windows;
using WindowsAppDevelopmentDay2.ViewModels;

namespace WindowsAppDevelopmentDay2
{
  public class Bootstrapper : BootstrapperBase
  {

    public Bootstrapper()
    {
      Initialize();
    }

    protected override void OnStartup(object sender, StartupEventArgs e)
    {
      DisplayRootViewFor<LoginViewModel>();
    }
  }
}
