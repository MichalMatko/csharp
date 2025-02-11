using PokemonGame.Windows;
using System.Windows;

namespace PokemonGame
{
    public partial class MainWindow : Window
    {
        public Window_PokemonBattle Window_PokemonBattle { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            //Window_PokemonBattle = new Window_PokemonBattle();
            //Window_PokemonBattle.Show();
            //Close();

        }
    }
}