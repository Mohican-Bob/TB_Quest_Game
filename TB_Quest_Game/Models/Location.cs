using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_Quest_Game.Models
{
    public class Location : ObservableObject
    {

        
        private List<string> _background = new List<string>();
        private List<string> _roomDescription = new List<string>();
        private List<string> _locked = new List<string>();
        private bool _doorLock1;

        public List<string> Locked
        {
            get { return _locked; }
            set
            {
                _locked = value;
                OnPropertyChanged(nameof(Locked));
            }
        }
        public bool DoorLock1
        {
            get { return _doorLock1; }
            set {
                _doorLock1 = value;
                OnPropertyChanged(nameof(DoorLock1));
            }
        }

        public List<string> RoomDescription
        {
            get { return _roomDescription; }
            set { _roomDescription = value; }
        }

        public List<string> Background
        {
            get { return _background; }
            set { _background = value; }
        }
        
        public void CreateLocations()
        {
            Background.Add("/TB_Quest_Game;component/Assets/0.jpg");
            Background.Add("/TB_Quest_Game;component/Assets/1.jpg");
            Background.Add("/TB_Quest_Game;component/Assets/2.jpg");
            Background.Add("/TB_Quest_Game;component/Assets/3.jpg");
            Background.Add("/TB_Quest_Game;component/Assets/4.jpg");
            Background.Add("/TB_Quest_Game;component/Assets/5.jpg");
            Background.Add("/TB_Quest_Game;component/Assets/6.jpg");
            Background.Add("/TB_Quest_Game;component/Assets/7.jpg");
            Background.Add("/TB_Quest_Game;component/Assets/8.jpg");
            Background.Add("/TB_Quest_Game;component/Assets/9.jpg");
            Background.Add("/TB_Quest_Game;component/Assets/10.jpg");
        }

        public void CreateDescriptions()
        {
            RoomDescription.Add(" A deadly murder has happened out at the old \n Gilford Mansion. The local police, fearing for \n their lives has hired you to investigate.");
            RoomDescription.Add(" The Room Smells like death, \n and its quiet, too quiet");
            RoomDescription.Add(" This room is a mess, was there a struggle?");
            RoomDescription.Add(" A lone chair by a fireplace, interesting.\n The ashes are fresh");
            RoomDescription.Add(" The walls are falling apart, I should be careful");
            RoomDescription.Add(" This place is very dilapidated,\n I should be careful");
            RoomDescription.Add(" Watch your step!");
            RoomDescription.Add(" This room feels recently inhabited,\n I should investigate deeper");
            RoomDescription.Add(" Jeez how big is this place!?");
            RoomDescription.Add(" I should dig through every drawer,\n can't miss a thing");
        }

        public void CreateLocked()
        {
            Locked.Add(" The handle wont budge, I must need a key");
        }


    }
}
