using MVVMPractice.ViewModel;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MVVMPractice {
    /// <summary>
    /// Interaction logic for ComboBoxBinding.xaml
    /// </summary>
    public partial class ComboBoxBinding : Window {
        public ComboBoxBinding() {
            InitializeComponent();
            DataContext = new ComboBoxBindingViewModel();
        }
    }
}
