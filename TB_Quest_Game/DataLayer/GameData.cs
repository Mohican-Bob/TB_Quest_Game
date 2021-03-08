using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TB_Quest_Game.Models;

namespace TB_Quest_Game.DataLayer
{
    public class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                Name = "Garfunkel",
                Health = 120,
                LocationID = 0,
                Gun = false,
                Lives = 4
            };
        }

        public static List<string> InitializeMessages()
        {
            return new List<string>()
            {
                " A deadly murder has happened out at the old Gilford Mansion.\n The local police, fearing for their lives\n has hired you to investigate.",
                " Get into the mansion, gather evidence, \n and solve the mystery. without dying of course"
            };
        }
    }
}
