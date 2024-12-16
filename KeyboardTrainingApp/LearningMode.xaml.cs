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
    /// Логика взаимодействия для LearningMode.xaml
    /// </summary>
    public partial class LearningMode : Page
    {
        private KeyboardControl keyboardControl;
        private TextManager textManager;
        private char[] sourceLetters;
        char[] englishLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] russianLetters = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ','ъ','ы','ь','э','ю','я' };
        public LearningMode()
        {
            InitializeComponent();
            keyboardControl = FindKeyboardControlInMainWindow();
            textManager = new TextManager();
            if (keyboardControl != null)
            {
                keyboardControl.ButtonClickEvent += KeyboardControl_ButtonClickEvent;
            }
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
            if (LetterMode.Visibility == Visibility.Visible)
            {
                SetButtonContent(buttonContent);
            }
            if (TypingMode.Visibility == Visibility.Visible)
            {
                BeginTextType(buttonContent);
            }
        }
        private void StartLetterButton_Click(object sender, RoutedEventArgs e)
        {
            keyboardControl.Focus();
            Random random = new Random();
            int index = random.Next(sourceLetters.Length);
            char randomLetter = sourceLetters[index];
            StatusBar.Value = 0;
            StatusBar.Maximum = CounterSlider.Value;
            TypeLabel.Content = randomLetter.ToString();
            keyboardControl.HighlightButtonWithContent(randomLetter.ToString());
        }
        public void SetButtonContent(string buttonContent)
        {
            if (StatusBar.Value != StatusBar.Maximum)
            {
                if (TypeLabel.Content.ToString() == buttonContent)
                {
                    StatusBar.Value += 1;
                    Random random = new Random();
                    int index = random.Next(sourceLetters.Length);
                    char randomLetter = sourceLetters[index];
                    TypeLabel.Content = randomLetter.ToString();
                    keyboardControl.HighlightButtonWithContent(randomLetter.ToString());
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Финиш");
                StatusBar.Value = 0;
                TypeLabel.Content = "";
            }
        }
        private int currentIndex;
        string myText;
        char[] textCharacters;
        public void BeginTextType(string buttonContent)
        {
            keyboardControl.Focus();
            try
            {
                if (currentIndex != textCharacters.Length)
                {
                    char currentCharacter = textCharacters[currentIndex];

                    if (buttonContent.Trim() == currentCharacter.ToString().Trim())
                    {
                        currentIndex++;
                        TypingBar.Value += 1;
                        if (currentIndex < textCharacters.Length)
                        {
                            char nextCharacter = textCharacters[currentIndex];
                            TypeTextBox.AppendText(nextCharacter.ToString()); 
                            keyboardControl.HighlightButtonWithContent(nextCharacter.ToString());
                            TypeTextBox.ScrollToHorizontalOffset(TypeTextBox.HorizontalOffset + TypeTextBox.ActualWidth / 2);

                            TypeTextBox.Focus();
                            TypeTextBox.Select(0, 1);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Финиш");
                    currentIndex = 0;
                    TypingBar.Value = 0;
                    TypeTextBox.Text = "";
                }
            }
            catch
            {

            }
        }
        private void CounterSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (CounterLabel != null)
            {
                CounterSlider.Value = Math.Round(CounterSlider.Value);
                CounterLabel.Content = CounterSlider.Value.ToString();
            }
        }

        private void EnglishCheck_Checked(object sender, RoutedEventArgs e)
        {
            sourceLetters = englishLetters;
        }

        private void RussianCheck_Checked(object sender, RoutedEventArgs e)
        {
            sourceLetters = russianLetters;
        }

        private void LetterSelectButton_Click(object sender, RoutedEventArgs e)
        {
            SelectionMode.Visibility = Visibility.Collapsed;
            LetterMode.Visibility = Visibility.Visible;
        }

        private void TypingSelectButton_Click(object sender, RoutedEventArgs e)
        {
            SelectionMode.Visibility = Visibility.Collapsed;
            TypingMode.Visibility = Visibility.Visible;
        }

        private void StartTypeButton_Click(object sender, RoutedEventArgs e)
        {
            TypeTextBox.Clear();
            currentIndex = 0;
            TypingBar.Value = 0;

            string selectedLanguage = EnglishText.IsChecked == true ? "English" : "Russian";
            string randomText = textManager.GetRandomText(selectedLanguage);
            keyboardControl.Focus();
            myText = randomText;
            TypingBar.Maximum = myText.Length;
            textCharacters = myText.ToCharArray();
            TypeTextBox.AppendText(textCharacters[0].ToString());


        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            TypingMode.Visibility = Visibility.Collapsed;
            SelectionMode.Visibility = Visibility.Visible;
        }

        private void BackButton2_Click(object sender, RoutedEventArgs e)
        {
            LetterMode.Visibility = Visibility.Collapsed;
            SelectionMode.Visibility = Visibility.Visible;
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
    }
}
