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
    /// Interaction logic for GameSessionView.xaml
    /// </summary>
    public partial class GameSessionView : Window
    {
        GameSessionViewModel _gameSessionViewModel;
        
        public GameSessionView(GameSessionViewModel gameSessionViewModel)
        {
            _gameSessionViewModel = gameSessionViewModel;

            InitializeComponent();
            Room1_Room2.Visibility = Visibility.Hidden;
            Room1_Room3.Visibility = Visibility.Hidden;
            Room1_Room5.Visibility = Visibility.Hidden;
            Room2_Room1.Visibility = Visibility.Hidden;
            Room3_Room1.Visibility = Visibility.Hidden;
            Room3_Room4.Visibility = Visibility.Hidden;
            Room4_Room3.Visibility = Visibility.Hidden;
            Room5_Room1.Visibility = Visibility.Hidden;
            Room5_Room6.Visibility = Visibility.Hidden;
            Room6_Room5.Visibility = Visibility.Hidden;
            Room6_Room7.Visibility = Visibility.Hidden;
            Room6_Room8.Visibility = Visibility.Hidden;
            Room7_Room6.Visibility = Visibility.Hidden;
            Room8_Panel.Visibility = Visibility.Hidden;

        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Enter_Room1_Click (object sender, RoutedEventArgs e)
        {
            Opening.Visibility = Visibility.Hidden;            
            Room1_Room2.Visibility = Visibility.Visible;
            Room1_Room3.Visibility = Visibility.Visible;
            Room1_Room5.Visibility = Visibility.Visible;
            Room2_Room1.Visibility = Visibility.Hidden;
            Room3_Room1.Visibility = Visibility.Hidden;
            Room3_Room4.Visibility = Visibility.Hidden;
            Room5_Room1.Visibility = Visibility.Hidden;
            Room5_Room6.Visibility = Visibility.Hidden;


            _gameSessionViewModel.EnterRoom1();
        }

        private void Room1_Room2_Click(object sender, RoutedEventArgs e)
        {
            Room1_Room2.Visibility = Visibility.Hidden;
            Room1_Room3.Visibility = Visibility.Hidden;
            Room1_Room5.Visibility = Visibility.Hidden;
            Room2_Room1.Visibility = Visibility.Visible;
            _gameSessionViewModel.EnterRoom2();
        }

        private void Room1_Room3_Click(object sender, RoutedEventArgs e)
        {
            Room1_Room2.Visibility = Visibility.Hidden;
            Room1_Room3.Visibility = Visibility.Hidden;
            Room1_Room5.Visibility = Visibility.Hidden;
            Room3_Room1.Visibility = Visibility.Visible;
            Room3_Room4.Visibility = Visibility.Visible;
            _gameSessionViewModel.EnterRoom3();
            
        }

        private void Room3_Room4_Click(object sender, RoutedEventArgs e)
        {
            if (_gameSessionViewModel.TestLock)
            {
                Room3_Room1.Visibility = Visibility.Hidden;
                Room3_Room4.Visibility = Visibility.Hidden;
                Room4_Room3.Visibility = Visibility.Visible;
                _gameSessionViewModel.EnterRoom4();
            }
            else
            {
                _gameSessionViewModel.DoorLocked1();
            }


        }
        private void Room4_Room3_Click(object sender, RoutedEventArgs e)
        {
            Room3_Room1.Visibility = Visibility.Visible;
            Room4_Room3.Visibility = Visibility.Hidden;
            Room3_Room4.Visibility = Visibility.Visible;
            _gameSessionViewModel.EnterRoom3();
        }

        private void Room1_Room5_Click(object sender, RoutedEventArgs e)
        {
            Room1_Room2.Visibility = Visibility.Hidden;
            Room1_Room3.Visibility = Visibility.Hidden;
            Room1_Room5.Visibility = Visibility.Hidden;
            Room5_Room1.Visibility = Visibility.Visible;
            Room5_Room6.Visibility = Visibility.Visible;
            _gameSessionViewModel.EnterRoom5();
        }



        private void Room5_Room6_Click(object sender, RoutedEventArgs e)
        {
            Room5_Room6.Visibility = Visibility.Hidden;
            Room5_Room1.Visibility = Visibility.Hidden;
            Room6_Room5.Visibility = Visibility.Visible;
            Room6_Room7.Visibility = Visibility.Visible;
            Room6_Room8.Visibility = Visibility.Visible;
            _gameSessionViewModel.EnterRoom6();
        }

        private void Room6_Room5_Click(object sender, RoutedEventArgs e)
        {
            Room6_Room5.Visibility = Visibility.Hidden;
            Room6_Room7.Visibility = Visibility.Hidden;
            Room6_Room8.Visibility = Visibility.Hidden;
            Room5_Room1.Visibility = Visibility.Visible;
            Room5_Room6.Visibility = Visibility.Visible;
            _gameSessionViewModel.EnterRoom5();
        }

        private void Room6_Room7_Click(object sender, RoutedEventArgs e)
        {
            Room6_Room5.Visibility = Visibility.Hidden;
            Room6_Room7.Visibility = Visibility.Hidden;
            Room6_Room8.Visibility = Visibility.Hidden;
            Room7_Room6.Visibility = Visibility.Visible;
            _gameSessionViewModel.EnterRoom7();
        }

        private void Room7_Room6_Click(object sender, RoutedEventArgs e)
        {
            Room6_Room5.Visibility = Visibility.Visible;
            Room6_Room7.Visibility = Visibility.Visible;
            Room6_Room8.Visibility = Visibility.Visible;
            Room7_Room6.Visibility = Visibility.Hidden;
            _gameSessionViewModel.EnterRoom6();
        }

        private void Room6_Room8_Click(object sender, RoutedEventArgs e)
        {
            Room6_Room5.Visibility = Visibility.Hidden;
            Room6_Room7.Visibility = Visibility.Hidden;
            Room6_Room8.Visibility = Visibility.Hidden;
            Room8_Panel.Visibility = Visibility.Visible;

            _gameSessionViewModel.EnterRoom8();
        }

        private void Room8_Room6_Click(object sender, RoutedEventArgs e)
        {
            Room6_Room5.Visibility = Visibility.Visible;
            Room6_Room7.Visibility = Visibility.Visible;
            Room6_Room8.Visibility = Visibility.Visible;
            Room8_Panel.Visibility = Visibility.Hidden;
            _gameSessionViewModel.EnterRoom6();
        }
    }
}
