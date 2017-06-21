using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense
{
    class PlayingState : GameObjectList
    {
        homeBase home;
        GameObjectList ufos;

        public PlayingState()
        {
            home = new homeBase();
            ufos = new GameObjectList();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(home);
            this.Add(ufos);

            this.ufos.Add(new Ufo(new Vector2(20, 20), home));
            this.ufos.Add(new Ufo(new Vector2(-100, 600), home));
            this.ufos.Add(new Ufo(new Vector2(-300, 300), home));
            this.ufos.Add(new Ufo(new Vector2(800, 500), home));
            this.ufos.Add(new Ufo(new Vector2(700, 1000), home));
        }
    }
}
