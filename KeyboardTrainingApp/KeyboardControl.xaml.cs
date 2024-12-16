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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KeyboardTrainingApp
{
    /// <summary>
    /// Логика взаимодействия для KeyboardControl.xaml
    /// </summary>
    public partial class KeyboardControl : UserControl
    {
        bool isRussian;
        ButtonGroup SetButtons = new ButtonGroup("Набор кнопок");

        char[] shiftOnEnglish = 
        {
            '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+',
            'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', '{', '}', '|',
            'A','S','D','F','G','H','J','K','L',':', '"',
            'Z','X','C','V','B','N','M','<', '>', '?'
        };
        char[] shiftOnRussian = 
        {
            'Ё', '!', '"', '№' ,';' ,'%' ,':' ,'?' ,'*' ,'(' ,')' ,'_' ,'+' ,
            'Й','Ц','У','К','Е','Н','Г','Ш','Щ','З','Х' ,'Ъ' ,'/' ,
            'Ф','Ы','В','А','П','Р','О','Л', 'Д','Ж' ,'Э',
            'Я','Ч','С','М','И','Т','Ь','Б' ,'Ю' ,','
        };
        char[] russianAlphabet =
        {
            'ё','1','2','3','4','5','6','7','8','9','0','-','=',
            'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ', '\\',
            'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'ж', 'э',
            'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'б', 'ю', '.'
        };
        char[] englishAlphabet =
        {
            '`','1','2','3','4','5','6','7','8','9','0', '-','=',
            'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', '[', ']', '\\',
            'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', ';', '\u0027',
            'z', 'x', 'c', 'v', 'b', 'n', 'm', ',', '.', '/'
        };
        public KeyboardControl()
        {
            InitializeComponent();
            LoadButtonGroups();
        }
        public void LoadButtonGroups()
        {

            Button[] setButtons = new Button[]
            {
                buttonMult0, buttonMult01, buttonMult02, buttonMult03, buttonMult04, buttonMult05,
                buttonMult06, buttonMult07, buttonMult08, buttonMult09, buttonMult10,
                buttonMult11, buttonMult12, buttonQ, buttonW, buttonE, buttonR, buttonT,
                buttonY, buttonU, buttonI, buttonO, buttonP, buttonMult, buttonMult2, buttonMult3,
                buttonA, buttonS, buttonD, buttonF, buttonG, buttonH, buttonJ, buttonK, buttonL,
                buttonMult21, buttonMult22, buttonZ, buttonX, buttonC, buttonV, buttonB, buttonN,
                buttonM, buttonMult31, buttonMult32, buttonMult33
            };
            foreach (Button button in setButtons)
            {
                SetButtons.Buttons.Add(button);
            }

        }
        public class ButtonGroup
        {
            public string Name { get; set; }
            public List<Button> Buttons { get; set; }

            public ButtonGroup(string name)
            {
                Name = name;
                Buttons = new List<Button>();
            }
        }
        public delegate void ButtonClickEventHandler(string buttonContent);
        public event ButtonClickEventHandler ButtonClickEvent;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string buttonContent = button.Content.ToString();
            ButtonClickEvent?.Invoke(buttonContent);

        }


        private void UserControl_PreviewKeyDown(object sender, KeyEventArgs e)
        {

            if (Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.LeftAlt))
            {
                var currentLanguage = InputLanguageManager.Current.CurrentInputLanguage;
                if (currentLanguage.KeyboardLayoutId == 1033)
                {
                    UpdateButtonsContent(russianAlphabet);
                    isRussian = true;
                }
                else if (currentLanguage.KeyboardLayoutId == 1049)
                {
                    UpdateButtonsContent(englishAlphabet);
                    isRussian = false;
                }
            }
            else if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
            {
                if (isRussian)
                {
                    UpdateButtonsContent(shiftOnRussian);
                }
                else
                {
                    UpdateButtonsContent(shiftOnEnglish);
                }
            }
            foreach (var button in FindButtons(KeyboardControlGrid))
            {
                if (button.Tag != null && button.Tag.ToString() == e.Key.ToString())
                {
                    HandleButtonKeyPress(button, "ButtonDownAnimation");
                    break;
                }
            }
            e.Handled = true;
        }

        private void UserControl_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (!(Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
            {
                if (isRussian)
                {
                    UpdateButtonsContent(russianAlphabet);
                }
                else
                {
                    UpdateButtonsContent(englishAlphabet);
                }
            }
            foreach (var button in FindButtons(KeyboardControlGrid))
            {
                if (button.Tag != null && button.Tag.ToString() == e.Key.ToString())
                {
                    var buttonAnimation = this.FindResource("ButtonUpAnimation") as Storyboard;
                    button.BeginStoryboard(buttonAnimation);
                    break;
                }
            } 
            e.Handled = true;
        }
        private void UpdateButtonsContent(char[] alphabet)
        {
            for (int i = 0; i < SetButtons.Buttons.Count; i++)
            {
                if (i < alphabet.Length)
                {
                    SetButtons.Buttons[i].Content = alphabet[i].ToString();
                }
            }
        }

        private void HandleButtonKeyPress(Button button, string animationName) //Обработка нажатия кнопки с физической клавиатуры в событие click
        {
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            var buttonAnimation = this.FindResource(animationName) as Storyboard;
            button.BeginStoryboard(buttonAnimation);
        }
        private IEnumerable<Button> FindButtons(DependencyObject parent) //Поиск дочерних элементов в Grid (Поиск кнопок)
        {
            var count = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is Button button)
                {
                    yield return button;
                }
                else
                {
                    foreach (var foundButton in FindButtons(child))
                    {
                        yield return foundButton;
                    }
                }
            }
        }
        public void HighlightButtonWithContent(string letter)
        {
            foreach (var button in FindButtons(KeyboardControlGrid))
            {
                if (button.Content != null && button.Content.ToString() == letter)
                {
                    var buttonAnimation = this.FindResource("ButtonDownAnimation") as Storyboard;
                    // Trigger the ButtonDownAnimation storyboard on the target button
                    button.BeginStoryboard(buttonAnimation);
                }
            }
        }
    }
}
