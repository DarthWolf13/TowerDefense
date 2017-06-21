using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense
{
    class homeBase : SpriteGameObject
    {
        Vector2 startPos;

        public homeBase() : base("spr_homebase")
        {
            this.origin = sprite.Center;
            startPos = new Vector2(900, 340);
            this.position = startPos;
        }
    }
}
