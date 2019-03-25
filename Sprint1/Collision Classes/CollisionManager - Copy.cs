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
        Rectangle enemyBox;
        Rectangle secondEnemyBox;
        Rectangle itemBox;
        Rectangle blockBox;
        EnemyCollisionHandler enemyCollisionHandler;
        ItemCollisionHandler itemCollisionHandler;
        BlockCollisionHandler blockCollisionHandler;
        ProjectileCollisionHandler projectileCollisionHandler;


        Rectangle intersectRectangle;
        public CollisionManager()
        {
            enemyCollisionHandler = EnemyCollisionHandler.Instance;
            itemCollisionHandler = ItemCollisionHandler.Instance;
            blockCollisionHandler = BlockCollisionHandler.Instance;
            projectileCollisionHandler = ProjectileCollisionHandler.Instance;
        }
        public void Detection(IMario mario, Chunk currentChunk)
        {
            if (mario == null)
            {
                throw new ArgumentNullException("mario");
            }
            ICollision collisionType;
            Rectangle marioBox = mario.HitBox;

            
            

            IList<Tuple<IBlock, ICollision>> detectedCollisions = new List<Tuple<IBlock, ICollision>>();
            IList<Tuple<IBlock, ICollision>> validCollisions = new List<Tuple<IBlock, ICollision>>();

            foreach (IBlock block in currentChunk.ListOfGameBlocks)
            {
                blockBox = block.HitBox;
                if (marioBox.Intersects(blockBox))
                {

                    collisionType = GetCollisionType(marioBox, blockBox);
                    detectedCollisions.Add(new Tuple<IBlock, ICollision>(block, collisionType));
                }
                    
            }
            validCollisions = this.GetValidCollisions(detectedCollisions);
            foreach(Tuple<IBlock, ICollision> pair in validCollisions)
            {
                blockCollisionHandler.MarioBlockCollisionHandler(mario, pair.Item1, pair.Item2);
            }
            foreach (IProjectile projectile in currentChunk.ListOfGameProjectiles)
            {
                Rectangle projectileBox = projectile.HitBox;
                foreach (IEnemy enemy in currentChunk.ListOfGameEnemies)
                {
                    enemyBox = enemy.HitBox;
                    if (projectileBox.Intersects(enemyBox))
                    {
                        collisionType = GetCollisionType(projectileBox, enemyBox);
                        projectileCollisionHandler.ProjectileEnemyCollisionHandler(projectile, enemy);
                    }

                }
                detectedCollisions.Clear();
                validCollisions.Clear();
                foreach (IBlock block in currentChunk.ListOfGameBlocks)
                {
                    blockBox = block.HitBox;
                    if (projectileBox.Intersects(blockBox))
                    {
                        collisionType = GetCollisionType(projectileBox, blockBox);
                        detectedCollisions.Add(new Tuple<IBlock, ICollision>(block, collisionType));
                    }
                    

                }
                if (detectedCollisions.Count > 0)
                {
                    validCollisions = this.GetValidCollisions(detectedCollisions);
                }

                foreach (Tuple<IBlock, ICollision> pair in validCollisions)
                {
                    projectileCollisionHandler.ProjectileBlockCollisionHandler(projectile, pair.Item1, pair.Item2);
                }
            }
            foreach (IItem item in currentChunk.ListOfGameItems)
            {
                itemBox = item.HitBox;
                if (marioBox.Intersects(itemBox))
                {
                    collisionType = GetCollisionType(marioBox, itemBox);
                    itemCollisionHandler.MarioItemCollisionHandler(mario, item);
                }
                foreach (IEnemy enemy in currentChunk.ListOfGameEnemies)
                {
                    enemyBox = enemy.HitBox;
                    if (itemBox.Intersects(enemyBox))
                    {
                        collisionType = GetCollisionType(itemBox, enemyBox);
                        itemCollisionHandler.ItemEnemyCollisionHandler(item, enemy);
                    }

                }
                detectedCollisions.Clear();
                validCollisions.Clear();
                foreach (IBlock block in currentChunk.ListOfGameBlocks)
                {
                    blockBox = block.HitBox;
                    if (itemBox.Intersects(blockBox))
                    {
                        collisionType = GetCollisionType(itemBox, blockBox);
                        detectedCollisions.Add(new Tuple<IBlock, ICollision>(block, collisionType));
                    }

                }
                if(detectedCollisions.Count > 0)
                {
                    validCollisions = this.GetValidCollisions(detectedCollisions);
                }
                
                foreach (Tuple<IBlock, ICollision> pair in validCollisions)
                {
                    itemCollisionHandler.ItemBlockCollisionHandler(item, pair.Item1, pair.Item2);
                }
            }
            foreach (IEnemy enemy in currentChunk.ListOfGameEnemies)
            {
                enemyBox = enemy.HitBox;
                if (marioBox.Intersects(enemyBox))
                {
                    collisionType = GetCollisionType(marioBox, enemyBox);
                    enemyCollisionHandler.MarioEnemyCollisionHandler(mario, enemy, collisionType);

                }
                foreach (IEnemy secondEnemy in currentChunk.ListOfGameEnemies)
                {
                    secondEnemyBox = secondEnemy.HitBox;
                    if (secondEnemy != enemy && enemyBox.Intersects(secondEnemyBox))
                    {
                        collisionType = GetCollisionType(secondEnemyBox, enemyBox);
                        enemyCollisionHandler.EnemyEnemyCollisionHandler(secondEnemy, enemy, collisionType);
                    }

                }
                validCollisions.Clear();
                detectedCollisions.Clear();
                foreach (IBlock block in currentChunk.ListOfGameBlocks)
                {
                    blockBox = block.HitBox;
                    if (blockBox.Intersects(enemyBox))
                    {
                        collisionType = GetCollisionType(enemyBox, blockBox);
                        detectedCollisions.Add(new Tuple<IBlock, ICollision>(block, collisionType));
                    }

                }
                validCollisions = this.GetValidCollisions(detectedCollisions);
                foreach (Tuple<IBlock, ICollision> pair in validCollisions)
                {
                    blockCollisionHandler.EnemyBlockCollisionHandler(enemy, pair.Item1, pair.Item2);
                }

            }
        }
        public static ICollision GetCollisionType(IGameObject collidingObject, IGameObject collidedObject) {
            ICollision collisionType = new NullCollision(new Rectangle());
            Rectangle collidingObjectBox = collidingObject.HitBox;
            Rectangle collidedObjectBox = collidedObject.HitBox;
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
                IBlock block = pair.Item1;
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

                if (((block1.Location.X - block2.Location.X) % 32 == 0) && (block1.Location.Y == block2.Location.Y))
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

                else if (((block1.Location.Y - block2.Location.Y) % 32 == 0) && (block1.Location.X == block2.Location.X))
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
