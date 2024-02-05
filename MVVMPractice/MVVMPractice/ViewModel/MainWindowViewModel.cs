using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MVVMPractice.Model;
using MVVMPractice.ViewModel;

namespace MVVMPractice.ViewModel {
    public partial class MainWindowViewModel {
        // List에 대해서는 INotifyPropertyChanged를 구현하지 않아도 된다.
        // C#에서는 List형태의 Collection 자료구조에 INotifyPropertyChanged가
        // 구현된 컬렉션을 추가로 제공해 준다.
        // List와 동작은 같다! 단, 리스트에 대한 변경사항(항목의 추가, 삭제, 변경)
        // 이 발생되었을 때, 자동으로 이 객체를 구독하고 있는 View에게 변경사항을 알려준다.
        // List 대신 ObservableCollection을 사용하면 된다.
        public ObservableCollection<User> Users { get; set; } = new();

        // List에 대해 Add, Remove, Clear 등의 메서드를 사용하면
        // 자동으로 View에게 변경사항을 알려준다.
        public MainWindowViewModel() {
            AddCommand = new RelayCommand(AddUser);
            Users.Add(new User() { Name = "사용자1", Email = "네이버" });
        }
        public ICommand AddCommand { get; set; }
        public static int n = 0;
        public void AddUser() {
            Users.Add(new User() { Name = $"{n}", Email = $"{n++}" });
        }
    }
    }
