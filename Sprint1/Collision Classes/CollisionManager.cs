using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class CollisionManager
    {
       
        public const float COLLISION_CHECK_RADIUS = CollisionUtility.collisionRadius;
        
        private EnemyCollisionManager enemyCollisionManager;
        private ItemCollisionManager itemCollisionManager;
        private MarioCollisionManager marioCollisionManager;
        private ProjectileCollisionManager projectileCollisionManager;
        
        public CollisionManager()
        {
            CollisionUtility.Initialize();
            enemyCollisionManager = EnemyCollisionManager.Instance;
            itemCollisionManager = ItemCollisionManager.Instance;
            marioCollisionManager = MarioCollisionManager.Instance;
            projectileCollisionManager = ProjectileCollisionManager.Instance;
        }
        public void Update(IMario mario, Chunk currentChunk, IList<IPortal> listOfGamePortals, IList<IFloorPiece> listOfFloorPieces)
        {
            marioCollisionManager.ManageMarioCollisions(mario, currentChunk, listOfGamePortals, listOfFloorPieces);
            itemCollisionManager.ManageItemCollisions(currentChunk, listOfFloorPieces);
            enemyCollisionManager.ManageEnemyCollisions(mario, currentChunk, listOfFloorPieces);
            projectileCollisionManager.ManageProjectileCollisions(currentChunk, listOfFloorPieces);
        }
        public static ICollision GetCollisionType(Rectangle collidingObjectBox, Rectangle collidedObjectBox) {
            ICollision collisionType = new NullCollision(new Rectangle());
            
            if (collidingObjectBox.Intersects(collidedObjectBox))
            {
                Rectangle intersectRectangle = Rectangle.Intersect(collidingObjectBox, collidedObjectBox);
                if (intersectRectangle.Height >= intersectRectangle.Width)
                {
                    if (collidingObjectBox.Left < collidedObjectBox.Left)
                    {
                        collisionType = new LeftCollision(intersectRectangle);
                    }
                    else
                    {
                        collisionType = new RightCollision(intersectRectangle);
                    }
                }
                else
                {
                    if (collidingObjectBox.Bottom > collidedObjectBox.Bottom)
                    {
                        collisionType = new BottomCollision(intersectRectangle);
                    }
                    else
                    {
                        collisionType = new TopCollision(intersectRectangle);
                    }
                }
            }
            return collisionType;
        }
        public static IList<Tuple<IBlock, ICollision>> GetValidBlockCollisions(IList<Tuple<IBlock, ICollision>> detectedCollisions)
        {
            IList<Tuple<IBlock, ICollision>> refinedCollisions = new List<Tuple<IBlock, ICollision>>();
            IList<Tuple<IBlock, ICollision>> validCollisions = new List<Tuple<IBlock, ICollision>>();

            IList<Tuple<IBlock, ICollision>>[] collisionTypes = new IList<Tuple<IBlock, ICollision>>[4];
            for (int i = 0; i < 2; i++)
            {
                collisionTypes[i] = new List<Tuple<IBlock, ICollision>>();
            }
            foreach (Tuple<IBlock, ICollision> pair in detectedCollisions)
            {
                ICollision side = pair.Item2;
                switch (side)
                {
                    case TopCollision _:
                    case BottomCollision _:
                        collisionTypes[0].Add(pair);
                        break;
                    default:
                        collisionTypes[1].Add(pair);
                        break;

                }

            }

            for (int i = 0; i < 2; i++)
            {
                IList<Tuple<IBlock, ICollision>> currentSide = collisionTypes[i];
                if (currentSide.Count > 0)
                {
                    Tuple<IBlock, ICollision> maxCollision = currentSide.ElementAt(0);
                    foreach (Tuple<IBlock, ICollision> pair in currentSide)
                    {
                        if (i == 0)
                        {
                            if (pair.Item2.IntersectingRectangle.Width > maxCollision.Item2.IntersectingRectangle.Width)
                            {
                                maxCollision = pair;
                            }
                        }
                        else
                        {
                            if (pair.Item2.IntersectingRectangle.Height > maxCollision.Item2.IntersectingRectangle.Height)
                            {
                                maxCollision = pair;
                            }
                        }
                    }
                    refinedCollisions.Add(maxCollision);
                }
            }
            if (refinedCollisions.Count < 2)
            {
                validCollisions = refinedCollisions;
            }
            else
            {
                Tuple<IBlock, ICollision> collision1 = refinedCollisions.ElementAt(0);
                Tuple<IBlock, ICollision> collision2 = refinedCollisions.ElementAt(1);
                IBlock block1 = collision1.Item1;
                IBlock block2 = collision2.Item1;

                if (((block1.Location.X - block2.Location.X) % CollisionUtility.blockMod == 0) && (block1.Location.Y == block2.Location.Y))
                {
                    if (collision1.Item2 is TopCollision || collision1.Item2 is BottomCollision)
                    {
                        validCollisions.Add(collision1);
                    }
                    else
                    {
                        validCollisions.Add(collision2);
                    }
                }

                else if (((block1.Location.Y - block2.Location.Y) % CollisionUtility.blockMod == 0) && (block1.Location.X == block2.Location.X))
                {
                    if (collision1.Item2 is RightCollision || collision1.Item2 is LeftCollision)
                    {
                        validCollisions.Add(collision1);
                    }
                    else
                    {
                        validCollisions.Add(collision2);
                    }
                }

                else
                {
                    validCollisions.Add(collision1);
                    validCollisions.Add(collision2);
                }
            }

            return validCollisions;
        }
        
    }
}
