using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TB_Quest_Game.Models;

namespace TB_Quest_Game.PresentationLayer
{
    public class GameSessionViewModel
    {
        private Player _player;
        private List<string> _messages;



        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return string.Join("\n\n", _messages); }
        }

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(Player player, List<string> initialMessages)
        {
            _player = player;
            _messages = initialMessages;
        }
    }
}
