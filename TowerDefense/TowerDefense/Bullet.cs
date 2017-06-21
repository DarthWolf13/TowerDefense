using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense
{
    class Bullet : SpriteGameObject
    {
        public Bullet(Vector2 startPos, Vector2 startVel) : base("spr_bullet")
        {
            this.position = startPos;
            this.velocity = startVel;
            this.origin = sprite.Center;
        }
    }
}
