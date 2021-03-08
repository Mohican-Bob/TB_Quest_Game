using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Quest_Game.Models
{
    public class GameStatus
    {
        private bool _newGame;

        public bool NewGame
        {
            get { return _newGame; }
            set { _newGame = value; }
        }

        public GameStatus()
        {

        }

    }
}
