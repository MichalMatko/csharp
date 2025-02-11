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

namespace PokemonGame.Windows
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            GenerateMap();
        }
        public void GenerateMap()
        {
            Random random = new Random();
            int numberOfEnemies = 3;

            for (int i = 0; i < 3; i++)
            {
                var positionX = random.Next(-325, 325);
                var positionY = random.Next(-325, 325);

                Button button = new Button();
                button.Width = 50;
                button.Height = 50;
                button.Margin = new Thickness(positionX, positionY, 0, 0);

                button.Content = "Enemie" + i;
                Grid_Map.Children.Add(button);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
