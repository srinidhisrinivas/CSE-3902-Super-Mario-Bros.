using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class Brick : Projectile
    {
        public enum BrickType {Left, Right};
        public enum BrickColor { Red, Blue};
        public Brick(Vector2 location, Brick.BrickType brickType, Brick.BrickColor brickColor, float xVelocity, float yVelocity): base(location)
        {
            this.xVelocity = xVelocity;
            this.yVelocity = yVelocity;
            switch (brickType)
            {
                case BrickType.Left:
                    this.ProjectileState = new LeftBrickState(this, brickColor);
                    break;
                case BrickType.Right:
                    this.ProjectileState = new RightBrickState(this, brickColor);
                    break;
            }
        }

    }
}
