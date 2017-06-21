using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense
{
    class AutoFireCannon : RotatingSpriteGameObject
    {
        int cooldownTimer;

        public AutoFireCannon(Vector2 startPosition) : base("spr_cannon")
        {
            this.position = startPosition;
            this.origin = new Vector2(16, 16);
        }

        public Boolean HasFired
        {
            get
            {
                cooldownTimer++;
                if (cooldownTimer == 150)
                {
                    cooldownTimer = 0;
                    return true;
                }
                else return false;
            }
        }
    }
}
