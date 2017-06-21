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
        GameObjectList ufos, cannons, bullets;

        public PlayingState()
        {
            home = new homeBase();
            ufos = new GameObjectList();
            cannons = new GameObjectList();
            bullets = new GameObjectList();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(home);
            this.Add(ufos);
            this.Add(cannons);
            this.Add(bullets);

            this.ufos.Add(new Ufo(new Vector2(20, 20), home));
            this.ufos.Add(new Ufo(new Vector2(-100, 600), home));
            this.ufos.Add(new Ufo(new Vector2(-300, 300), home));
            this.ufos.Add(new Ufo(new Vector2(800, 500), home));
            this.ufos.Add(new Ufo(new Vector2(700, 1000), home));
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.MouseLeftButtonPressed())
            {
                this.cannons.Add(new AutoFireCannon(new Vector2(inputHelper.MousePosition.X, inputHelper.MousePosition.Y)));
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            foreach(AutoFireCannon autoFireCannon in cannons.Objects)
            {
                if(autoFireCannon.HasFired == true)
                {
                    this.bullets.Add(new Bullet(autoFireCannon.Position, autoFireCannon.AngularDirection * 120));
                }
            }
        }
    }
}
