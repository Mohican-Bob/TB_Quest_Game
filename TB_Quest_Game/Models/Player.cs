using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Quest_Game.Models
{
    public class Player : Character
    {
        private int _lives;
        private bool _gun;

        public bool Gun
        {
            get { return _gun; }
            set { _gun = value; }
        }

        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }
        public override string DefaultGreeting()
        {
            return "They've sent me here to solve a mystery, I by god I will.";
        }
        public Player()
        {

        }
    }
}
