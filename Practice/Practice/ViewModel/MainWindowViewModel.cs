using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Practice.ViewModel {
    public class MainWindowViewModel : INotifyPropertyChanged {
        private string _userName;
        public string UserName {
            get { return _userName; }
            set {
                _userName = value;
                OnPropertyChanged(nameof(UserName));
                OnPropertyChanged(nameof(GreetingMessage));
            }
        }

        public string GreetingMessage {
            get {
                return $"Hello, {_userName}!";
            }
        }

        public ICommand ButtonClick { get; }

        public MainWindowViewModel() {
            ButtonClick = new RelayCommand(ButtonClickAction);
        }

        public void ButtonClickAction() {
            MessageBox.Show("Hello!");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

