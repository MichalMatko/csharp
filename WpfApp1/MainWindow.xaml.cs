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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char LastPlayer { get; set; } = '◯';
        public char PlayerOne { get; set; } = '✕';
        public char PlayerTwo { get; set; } = '◯';
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ProcessClick(Button button)
        {
            var buttonContent = button.Content.ToString();
            if (buttonContent.Contains(PlayerOne) || buttonContent.Contains(PlayerTwo))
            {
                return;
            }

            if (LastPlayer == PlayerOne)
            {
                button.Content = PlayerTwo;
                LastPlayer = PlayerTwo;
            }
            else if (LastPlayer == PlayerTwo)
            {
                button.Content = PlayerOne;
                LastPlayer = PlayerOne;
            }

            var isWinner = CheckWinner();
            if (isWinner)
            {
                MessageBox.Show("Vyhral hráč: " + LastPlayer);
            }

        }


        private void Button_0x0_Click(object sender, RoutedEventArgs e)
        {
            ProcessClick(sender as Button);

        }

        public void CheckWinner()
        {
            var button_0x0 = Button_0x0.Content.ToString();
            var button_0x1 = Button_0x0.Content.ToString();
            var button_0x2 = Button_0x0.Content.ToString();
            var button_1x2 = Button_0x0.Content.ToString();
            var button_1x1 = Button_0x0.Content.ToString();
            var button_1x0 = Button_0x0.Content.ToString();
            var button_2x2 = Button_0x0.Content.ToString();
            var button_2x1 = Button_0x0.Content.ToString();
            var button_2x0 = Button_0x0.Content.ToString();

            //kontrola prveho riadku
            if (button_0x0 == button_0x1 && button_0x0 == button_0x2)
            {
                return true;
            }

            //kontrola druheho riadku
            if (button_1x0 == button_1x1 && button_1x0 == button_1x2)
            {
                return true;
            }

            //kontrola tretieho riadku
            if (button_2x0 == button_2x1 && button_2x0 == button_2x2)
            {
                return true;
            }


            //kontrola prveho stlpca riadku
            if (button_0x0 == button_0x1 && button_0x0 == button_0x2)
            {
                return true;
            }

            //kontrola druheho stlpca
            if (button_0x1 == button_1x1 && button_0x1 == button_2x1)
            {
                return true;
            }

            //kontrola tretieho stlpca 
            if (button_0x2 == button_1x2 && button_0x2 == button_2x2)
            {
                return true;
            }

            return false;

        }
    }
}