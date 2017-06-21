using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense
{
    class PlayingState : GameObjectList
    {
        homeBase home;

        public PlayingState()
        {
            home = new homeBase();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(home);
        }
    }
}
