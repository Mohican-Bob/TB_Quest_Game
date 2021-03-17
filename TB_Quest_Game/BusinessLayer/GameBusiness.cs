using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TB_Quest_Game.Models;
using TB_Quest_Game.DataLayer;
using TB_Quest_Game.PresentationLayer;

namespace TB_Quest_Game.BusinessLayer
{
    public class GameBusiness
    {

        GameStatus _gameStatus = new GameStatus();
        GameSessionViewModel _gameSessionViewModel;
        Player _player = new Player();
        List<string> _messages;        
        PlayerSetupView _playerSetupView;
        Location _location = new Location();


        private void SetupPlayer()
        {
            _playerSetupView = new PlayerSetupView(_gameStatus);
            _playerSetupView.ShowDialog();
            if (_gameStatus.NewGame)
            {
                InitializeDataSet();
            }
            else
            {
                //
                // This is where File IO methods will read from saved files
                //
                InitializeDataSet();
            }
        }

        public GameBusiness()
        {
            SetupPlayer();            
            InstantiateAndShowView();  
            
        }

        private void InitializeDataSet()
        {
            _player = GameData.PlayerData();
            _messages = GameData.InitializeMessages();
        }

        private void InstantiateAndShowView()
        {
            //
            // instantiate the view model and initialize the data set
            //
            _gameSessionViewModel = new GameSessionViewModel(_player, _messages);
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;
            
            gameSessionView.Show();

            //
            // dialog window is initially hidden to mitigate issue 
            // with main window closing after dialog window closes
            //
            _playerSetupView.Close();
        }
    }
}
