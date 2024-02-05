using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using WPFPractice.Model;
using WPFPractice.Service;

namespace WPFPractice {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private IUserManager _userManager = new LocalUserManager();

        public MainWindow() {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) {
            if(String.IsNullOrEmpty(TxtID.Text) || String.IsNullOrEmpty(TxtPW.Password)) {
                MessageBox.Show("두 필드를 모두 채워주세요!", "경고", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            // Login
            try {
                User user = _userManager.SignIn(TxtID.Text, TxtPW.Password);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                TxtID.Text = string.Empty;
                TxtPW.Password = string.Empty;
                return;
            }
        }
    }
}