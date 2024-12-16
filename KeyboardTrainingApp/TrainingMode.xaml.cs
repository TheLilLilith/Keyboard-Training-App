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
using System.Windows.Threading;

namespace KeyboardTrainingApp
{
    /// <summary>
    /// Логика взаимодействия для TrainingMode.xaml
    /// </summary>
    public partial class TrainingMode : Page
    {
        private KeyboardControl keyboardControl;
        private TextManager textManager;
        string selectedLanguage = "English";
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        int count = 0;
        int total = 0;
        int mistakes = 0;
        public TrainingMode()
        {
            InitializeComponent();
            textManager = new TextManager();
            keyboardControl = FindKeyboardControlInMainWindow();
            if (keyboardControl != null)
            {
                keyboardControl.ButtonClickEvent += KeyboardControl_ButtonClickEvent;
            }
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
        }
        private KeyboardControl FindKeyboardControlInMainWindow()
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                var keyboardControl = FindVisualChild<KeyboardControl>(mainWindow);

                return keyboardControl;
            }

            return null;
        }

        private T FindVisualChild<T>(DependencyObject parent) where T : DependencyObject
        {
            int childCount = VisualTreeHelper.GetChildrenCount(parent);

            for (int i = 0; i < childCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is T typedChild)
                {
                    return typedChild;
                }

                var foundChild = FindVisualChild<T>(child);
                if (foundChild != null)
                {
                    return foundChild;
                }
            }

            return null;
        }
        private void KeyboardControl_ButtonClickEvent(string buttonContent)
        {
            if (buttonContent == "Backspace")
            {
                if (InputUserTextBox.Text.Length > 0)
                {
                    InputUserTextBox.Text = InputUserTextBox.Text.Substring(0, InputUserTextBox.Text.Length - 1);
                }
            }
            else if (buttonContent == "L.Shift" || buttonContent == "R.Shift" || buttonContent == "Tab" || buttonContent == "Caps Lock" || buttonContent == "Enter")
            {
            }
            else if (string.IsNullOrEmpty(buttonContent))
            {
                InputUserTextBox.Text += " ";
            }
            else
            {
                InputUserTextBox.Text += buttonContent;
            }
            if (TextToPrint.Text == InputUserTextBox.Text)
            {
                NewInputText();
                TrainingProgressBar.Value += 1;
                if (TrainingProgressBar.Value == 5)
                {
                    MessageBox.Show("Финиш!");
                    TrainingProgressBar.Value = 0;
                    
                }
                else
                {
                    CountdownTimer();
                    
                }
            }

        }
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {

            if (TrainingProgressBar.Value == TrainingProgressBar.Maximum)
            {
                AverageSpeedUser.Content = count / total;
                dispatcherTimer.Stop();
                count = 0;
                total = 0;
                mistakes = 0;

            }
            else
            {
                total += 1;
                TimerCount.Content = total;
                AverageSpeedUser.Content = count / total + " ср.";
                MistaceAvr.Content = 100 - (mistakes / count) + "%";
            }
        }
            
            private async void CountdownTimer()
        {
            int seconds = 15;
            TaskTimerBar.Maximum = seconds;
            TaskTimerBar2.Maximum = seconds;
            while (seconds >= 0)
            {
                await Task.Delay(1000); 
                seconds--;
                TaskTimerBar.Value = seconds;
                TaskTimerBar2.Value = seconds;
            }
        }
        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
        public void NewInputText()
        {
            string newText = textManager.GetRandomTraining(selectedLanguage);
            TextToPrint.Text = newText;
            InputUserTextBox.Clear();
        }
        private void InputUserTextBox_TextChanged(object sender, TextChangedEventArgs e) 
        {
            //Проверка вводимых символов пользователя с символом текста, если не совпадает, помечать ошибку.
            dispatcherTimer.Start();
            count += 1;

            string originalText = TextToPrint.Text;
            string userInput = InputUserTextBox.Text;
            TextToPrint.Foreground = Brushes.Black;
            InlineCollection modifiedInlines = new TextBlock().Inlines;
            for (int i = 0; i < originalText.Length; i++)
            {
                Run run = new Run(originalText[i].ToString());

                if (i < userInput.Length)
                {
                    if (userInput[i] == originalText[i])
                    {
                        run.Foreground = Brushes.Black;
                    }
                    else
                    {
                        run.Foreground = Brushes.Red;
                        TextToPrint.Foreground = Brushes.Red;
                        mistakes++;
                        MistakeCount.Content = mistakes;
                    }
                }
                else
                {
                    run.Foreground = Brushes.Gray;
                }
                InputUserTextBox.ScrollToHorizontalOffset(InputUserTextBox.HorizontalOffset + InputUserTextBox.ActualWidth / 2);

                InputUserTextBox.Select(0, 1);
                modifiedInlines.Add(run);
            }
            Inline[] modifiedInlinesCopy = new Inline[modifiedInlines.Count];
            modifiedInlines.CopyTo(modifiedInlinesCopy, 0);
            TextToPrint.Inlines.Clear();
            TextToPrint.Inlines.AddRange(modifiedInlinesCopy);
            
        }

        private void RussianCheck_Checked(object sender, RoutedEventArgs e)
        {
            selectedLanguage = "Russian";
            keyboardControl.Focus();
            NewInputText();
        }

        private void EnglishCheck_Checked(object sender, RoutedEventArgs e)
        {
            selectedLanguage = "English";
            keyboardControl.Focus();
            NewInputText();

        }

        private void SharpCheck_Checked(object sender, RoutedEventArgs e)
        {
            selectedLanguage = "Sharp";
            keyboardControl.Focus();
            NewInputText();
        }

        private void CPlusPlusCheck_Checked(object sender, RoutedEventArgs e)
        {
            selectedLanguage = "CPlusPlus";
            keyboardControl.Focus();
            NewInputText();
        }

        private void PythonCheck_Checked(object sender, RoutedEventArgs e)
        {
            selectedLanguage = "Python";
            keyboardControl.Focus();
            NewInputText();
        }

        private void PascalCheck_Checked(object sender, RoutedEventArgs e)
        {
            selectedLanguage = "Pascal";
            keyboardControl.Focus();
            NewInputText();
        }
    }
}
