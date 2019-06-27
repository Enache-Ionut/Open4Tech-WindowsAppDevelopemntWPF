using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsAppDevelopmentDay2.ViewModels
{
  public class LoginViewModel : Screen
  {
    private string email;

    public string Email
    {
      get
      {
        return email;
      }
      set
      {
        email = value;
        NotifyOfPropertyChange(() => Email);
      }
    }

    public void Login()
    {
      MessageBox.Show("Login");
    }

    public void ForgotPassword()
    {
      MessageBox.Show("Forgot Password");
    }

  }
}
