﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class LeftBrickState : ProjectileState
    {
        public LeftBrickState(IProjectile projectile, Brick.BrickColor brickColor) : base(projectile)
        {
            switch (brickColor)
            {
                case Brick.BrickColor.Red:
                    this.ProjectileSprite = ProjectileSpriteFactory.Instance.CreateLeftRedBrickSprite();
                    break;
                case Brick.BrickColor.Blue:
                    this.ProjectileSprite = ProjectileSpriteFactory.Instance.CreateLeftBlueBrickSprite();
                    break;

            }
        }
    }
}
