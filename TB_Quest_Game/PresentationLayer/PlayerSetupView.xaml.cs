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
using TB_Quest_Game.Models;

namespace TB_Quest_Game.PresentationLayer
{
    /// <summary>
    /// Interaction logic for PlayerSetupView.xaml
    /// </summary>
    public partial class PlayerSetupView : Window
    {
        private GameStatus _gameStatus;
        
        
        public PlayerSetupView(GameStatus newGame)
        {
            _gameStatus = newGame;
            InitializeComponent();

            //SetupWindow();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _gameStatus.NewGame = true;
            Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _gameStatus.NewGame = false;
            Visibility = Visibility.Hidden;
        }
    }
}
