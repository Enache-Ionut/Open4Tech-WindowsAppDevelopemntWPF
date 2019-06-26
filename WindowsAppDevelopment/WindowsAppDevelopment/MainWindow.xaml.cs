using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsAppDevelopment
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window, INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;


    private string email;


    public string LoginToUse { get; private set; } = "Login to use Open4tech";

    public string Password { get; private set; }


    public string Email
    {
      get
      {
        return email;
      }
      set
      {
        email = value;

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));

        //if (PropertyChanged != null)
        //  PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Email"));
      }
    }

    public MainWindow()
    {
      InitializeComponent();
      DataContext = this;
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Reset your password");

      Email = string.Empty;

      //this.Close();
    }

    private void ForgotPasswordButton_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Reset your password");
    }

    private void OnPasswordChanged(object sender, RoutedEventArgs e)
    {
      if (DataContext != null)
      {
        Password = ((PasswordBox)sender).Password;
      }

    }

  }
}
