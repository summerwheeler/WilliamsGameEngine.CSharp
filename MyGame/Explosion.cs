﻿using GameEngine;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class Explosion : AnimatedSprite
    {
        public Explosion(Vector2f pos) : base(pos)
        {
            Texture = Game.GetTexture("Resources/explosion-spritesheet.png");
            SetUpExplosionAnimation();
            PlayAnimation("explosion", AnimationMode.OnceForwards);
        }

        public override void Update(Time elapsed)
        {
            base.Update(elapsed);
            if (!IsPlaying())
            {
                MakeDead();
            }
        }

        private void SetUpExplosionAnimation()
        {
            var frames = new List<IntRect>
            {
                new IntRect(0, 0, 64, 64),
                new IntRect(64, 0, 64, 64),
                new IntRect(128, 0, 64, 64),
                new IntRect(192, 0, 64, 64),
                new IntRect(256, 0, 64, 64),
                new IntRect(320, 0, 64, 64),
                new IntRect(384, 0, 64, 64),
                new IntRect(448, 0, 64, 64),
                new IntRect(512, 0, 64, 64)
            };
            AddAnimation("explosion", frames);

        }
    }
}
