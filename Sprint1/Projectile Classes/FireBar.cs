using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class FireBar: ILocateable
    {
        public enum FireBarDirections { Clockwise, CounterClockwise };
        private Vector2 FireBallLocation;
        public Vector2 Location { get; set ; }
        float AngularVelocity;
        Vector2 Origin;
        

        public IList<ElipticFireball> FireBallArray { get; }

        public FireBar(Vector2 location, int numOfFireBalls, float angularVelocity, double initAngle, FireBarDirections firebarDirection)
        {
            Location = location;
            Origin = location + BlockUtility.fireBarNewLocation;
            FireBallLocation = Origin;
            switch (firebarDirection)
            {
                case FireBarDirections.Clockwise:
                    this.AngularVelocity = angularVelocity;
                    break;
                case FireBarDirections.CounterClockwise:
                    this.AngularVelocity = -angularVelocity;
                    break;
            }
            FireBallArray = new List<ElipticFireball>();
            for (int j = BlockUtility.zeroCheck; j < numOfFireBalls; j++) {
                int Radius = j * BlockUtility.radius16;

                FireBallArray.Add(new ElipticFireball(FireBallLocation, Origin, AngularVelocity, Radius, initAngle));

                FireBallLocation  += new Vector2((float)Math.Cos(initAngle)* BlockUtility.eight, (float)Math.Sin(initAngle)* BlockUtility.eight);
            }

        }
        public void Update(GameTime gameTime)
        {
            foreach (ElipticFireball fireball in FireBallArray) {
                fireball.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch, Color color)
        {
            foreach (ElipticFireball fireball in FireBallArray)
            {
                fireball.Draw(spriteBatch, color);
            }
        }

    }
}