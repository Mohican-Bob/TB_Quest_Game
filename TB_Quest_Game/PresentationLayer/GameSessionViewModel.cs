using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TB_Quest_Game.Models;

namespace TB_Quest_Game.PresentationLayer
{
    public class GameSessionViewModel : ObservableObject
    {
        private Player _player;
        private string _messages;
        private Location _location = new Location();
        private string _currentLocation;
        private bool _testLock;

        public bool TestLock
        {
            get { return _testLock; }
            set 
            { 
                _testLock = value;
                OnPropertyChanged(nameof(CurrentLocation));                  
            }
        }

        public string CurrentLocation
        {
            get { return _currentLocation; }
            set 
            { 
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
            }
        }


        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return _messages; }
            set 
            {
                _messages = value;
                OnPropertyChanged(nameof(MessageDisplay));
            }          
                    
        }

        public GameSessionViewModel()
        {
            
        }

        public GameSessionViewModel(Player player, List<string> initialMessages)
        {
            _player = player;
            _location.CreateDescriptions();
            _location.CreateLocked();            
            _messages = _location.RoomDescription[0];
            _location.CreateLocations();
            CurrentLocation = _location.Background[0];
        }

        public void EnterRoom1()
        {
            CurrentLocation = _location.Background[1];
            MessageDisplay = _location.RoomDescription[1];
            //TestLock = true;
        }

        internal void EnterRoom2()
        {
            CurrentLocation = _location.Background[2];
            MessageDisplay = _location.RoomDescription[2];
        }

        internal void EnterRoom3()
        {
            CurrentLocation = _location.Background[3];
            MessageDisplay = _location.RoomDescription[3];
        }

        internal void EnterRoom4()
        {
            CurrentLocation = _location.Background[4];
            MessageDisplay = _location.RoomDescription[4];
        }

        internal void EnterRoom5()
        {
            CurrentLocation = _location.Background[5];
            MessageDisplay = _location.RoomDescription[5];
        }

        internal void EnterRoom6()
        {
            CurrentLocation = _location.Background[6];
            MessageDisplay = _location.RoomDescription[6];
        }

        internal void EnterRoom7()
        {
            CurrentLocation = _location.Background[7];
            MessageDisplay = _location.RoomDescription[7];
        }

        internal void EnterRoom8()
        {
            CurrentLocation = _location.Background[8];
            MessageDisplay = _location.RoomDescription[8];
        }

        internal void DoorLocked1()
        {
            MessageDisplay = _location.Locked[0];
        }
    }
}
