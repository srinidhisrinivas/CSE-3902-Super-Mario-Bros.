using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class ElipticFireball: ILocateable
    {
        ISprite ElipticFireballSprite;
        public Vector2 Location { get; set; }
        public Rectangle HitBox { get => ElipticFireballSprite.GetRectangle(this.Location); }
        Vector2 Origin;
        float AngularVelocity;
        int Radius;
        double Angle;
        public ElipticFireball(Vector2 location, Vector2 origin, float angularVelocity, int radius, double initAngle)
        {
            Location = location;
            AngularVelocity = angularVelocity;
            Radius = radius;
            Angle = initAngle;
            Origin = origin;
            ElipticFireballSprite = ProjectileSpriteFactory.Instance.CreateActiveFireballSprite();
        }
        public void Update(GameTime gameTime)
        {
            Angle += AngularVelocity % (BlockUtility.two * Math.PI);

            Location = new Vector2((float)(Math.Cos(Angle) * Radius + Origin.X), (float)(Math.Sin(Angle) * Radius + Origin.Y));

            ElipticFireballSprite.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            ElipticFireballSprite.Draw(spriteBatch, Location, color);
        }

    }
}