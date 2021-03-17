using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Quest_Game.Models
{
    public class Character
    {

        protected string _name;
        protected int _health;
        protected int _locationID;

        public int LocationID
        {
            get { return _locationID; }
            set { _locationID = value; }
        }


        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Character()
        {
            
        }

        public Character(string name, int health, int locationID)
        {
            _name = name;
            _health = health;
            _locationID = locationID;
        }

        public virtual string DefaultGreeting()
        {
            return $"Hello, my name is {_name} I have {_health} health";
        }
    }
}
