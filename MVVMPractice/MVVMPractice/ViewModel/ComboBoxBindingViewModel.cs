using MVVMPractice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPractice.ViewModel {
    public class ComboBoxBindingViewModel : INotifyPropertyChanged{
        public ObservableCollection<User> Users { get; set; } = new();

        private User _selectedUser;
        public User SelectedUser {
            get => _selectedUser;
            set {
                _selectedUser = value;

                // View에게: SelectedUser 값 바꿨어!
                // 새로운 값 가져가~
                OnPropertyChanged(nameof(SelectedUser));
                OnPropertyChanged(nameof(SelectedUserName));
            }
        }

        public string SelectedUserName {
            get {
                return $"{SelectedUser.Name} : {SelectedUser.Email}";
            }
        }

        public ComboBoxBindingViewModel() {
            Users.Add(new User { Name = "사용자1", Email = "이메일1" });
            Users.Add(new User { Name = "사용자2", Email = "이메일2" });
            Users.Add(new User { Name = "사용자3", Email = "이메일3" });
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
