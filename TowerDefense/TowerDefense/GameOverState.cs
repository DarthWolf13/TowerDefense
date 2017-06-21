using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense
{
    class GameOverState : GameObjectList
    {
        public GameOverState()
        {
            this.Add(new SpriteGameObject("spr_gameover"));
        }
    }
}
