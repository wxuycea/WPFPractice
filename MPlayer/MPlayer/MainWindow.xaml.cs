using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MPlayer {
    public partial class MainWindow : Window {
        private bool _isFileOpened { get; set; } = false;
        private bool _isPlaying { get; set; } = false;
        private string _filePath { get; set; }

        public MediaPlayer Player { get; } = new();

        public MainWindow() {
            InitializeComponent();
        }

        private void BtnFileOpenClick(object sender, RoutedEventArgs e) {
            if(_isPlaying) {
                StopMusic();
            }
            OpenFileDialog dialog = new();
            dialog.Filter = "Audio files (*.mp3;*.wav;*.wma)|*.mp3;*.wav;*.wma|All files (*.*)|*.*";

            if(dialog.ShowDialog() == true) {
                _filePath = dialog.FileName;
                TbFileName.Text = _filePath;

                Player.Open(new Uri(_filePath));
                _isFileOpened = true;

                BtnPlay.IsEnabled = true;
                BtnPause.IsEnabled = true;
                BtnStop.IsEnabled = true;
            }
        }

        private void BtnPlay_OnClick(object sender, RoutedEventArgs e) {
            PlayMusic();
            _isPlaying = true;
        }


        private void BtnPause_OnClick(object sender, RoutedEventArgs e) {
            PauseMusic();
            _isPlaying = false;
        }

        private void BtnStop_OnClick(object sender, RoutedEventArgs e) {
            StopMusic();
            _isPlaying = false;
        }
        private void PlayMusic() {
            Player.Play();
        }

        private void StopMusic() {
            Player.Stop();
        }

        private void PauseMusic() {
            Player.Pause();
        }
    }
}