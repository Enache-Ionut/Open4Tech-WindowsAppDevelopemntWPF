using Caliburn.Micro;
using System.Windows;
using WindowsAppDevelopmentDay2.Models;

namespace WindowsAppDevelopmentDay2.ViewModels
{
  public class LoginViewModel : Screen
  {
    #region Members

    private UserModel userModel = new UserModel();

    #endregion

    #region Properties

    public string Email
    {
      get
      {
        return userModel.Email;
      }
      set
      {
        userModel.Email = value;
        NotifyOfPropertyChange(() => Email);
      }
    }

    #endregion

    #region Public Methods

    public void Login()
    {
      MessageBox.Show("Log In");
      // Process.Start(new ProcessStartInfo("https://www.google.com/"));
    }

    public void ForgotPassword()
    {
      MessageBox.Show("Forgot Password");
    }

    #endregion

  }
}

