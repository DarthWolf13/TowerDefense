using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense
{
    class Ufo : RotatingSpriteGameObject
    {
        public Ufo(Vector2 startPosition, GameObject targetObject) : base("spr_ufo")
        {
            this.origin = sprite.Center;
            this.position = startPosition;
            LookAt(targetObject);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            this.velocity = AngularDirection * 50;
        }
    }
}
