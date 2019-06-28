using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace WindowsAppDevelopment
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window, INotifyPropertyChanged
  {
    #region Members

    private string email;

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion

    #region Properties

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

        //if (PropertyChanged != null)
        //  PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Email"));

        // This line is equivalent with the if statment from above
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
      }
    }

    #endregion

    #region Public Methods

    public MainWindow()
    {
      InitializeComponent();
      DataContext = this;
    }

    #endregion

    #region Private Methods

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Login");
      Process.Start(new ProcessStartInfo("https://www.google.com/"));
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

    #endregion

  }
}
