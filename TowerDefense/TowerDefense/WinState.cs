using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense
{
    class WinState : GameObjectList
    {
        public WinState()
        {
            this.Add(new SpriteGameObject("spr_win"));
        }
    }
}
