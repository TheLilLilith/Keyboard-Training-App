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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyboardTrainingApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            ContentFrame.Navigate(new MainMenu());

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FocusManager.SetFocusedElement(this, keyboardControl);
            Keyboard.Focus(keyboardControl);
        }

        private void HideButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Свернуть окно
            this.WindowState = WindowState.Minimized;
        }

        private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //Обработка выхода из приложения
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        private void MainMenuGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                //Реализация перемещения окна
                if (e.ChangedButton == MouseButton.Left)
                    this.DragMove();
            }
            catch
            {

            }
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = (MediaElement)sender;
            mediaElement.Position = TimeSpan.Zero;
            mediaElement.Play();
        }

        private void MediaElement_Loaded(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = (MediaElement)sender;
            mediaElement.Play();
        }
    }
}
